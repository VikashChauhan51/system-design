import fs from "fs";
import path from "path";
import puppeteer from "puppeteer";

const outputPath = "converted-from-html.pdf";

// Read the HTML file - use full path
const inputPath = "c:\\Users\\vikas\\Downloads\\markdowntohtmlproblem.html";
const htmlContent = fs.readFileSync(inputPath, "utf8");

// Preserve the entire HTML structure with all styles intact
// Add print media styles to ensure colors and backgrounds render in PDF
const html = `
${htmlContent}
<style>
  @media print {
    * {
      -webkit-print-color-adjust: exact !important;
      color-adjust: exact !important;
      print-color-adjust: exact !important;
    }
   body {
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Helvetica, Arial, sans-serif;
  font-size: 16px;
  line-height: 1.7;
  color: #1e293b;
  background: #ffffff;
  padding: 2rem;
  max-width: 880px;
  margin: 0 auto;
}
code:not(pre code) {
  background: #eef2f6;
  color: #0d2b3e;
  padding: 0.2rem 0.7rem;
  border-radius: 9999px;           /* pill shape */
  font-family: 'SF Mono', 'Monaco', 'Fira Code', 'Consolas', monospace;
  font-size: 0.85em;
  font-weight: 500;
  border: 1px solid #d1d9e6;
  box-shadow: 0 1px 3px rgba(0,0,0,0.05);
  white-space: nowrap;
  transition: all 0.2s ease;
}
code:not(pre code):hover {
  background: #e6edf5;
  border-color: #2563eb;
  box-shadow: 0 2px 5px rgba(37,99,235,0.2);
  transform: translateY(-1px);
}
pre {
  position: relative;
  margin: 2rem 0;
  border-radius: 18px;              /* large rounded corners */
  background: #0f172a;               /* dark background for contrast */
  border: 1px solid #334155;
  box-shadow: 0 10px 15px -3px rgba(0,0,0,0.1), 0 4px 6px -2px rgba(0,0,0,0.05);
  overflow: hidden;
  transition: box-shadow 0.3s ease, border-color 0.2s ease;
}
pre:hover {
  box-shadow: 0 20px 25px -5px rgba(0,0,0,0.2), 0 10px 10px -5px rgba(0,0,0,0.1);
  border-color: #3b82f6;
}

pre::before {
  content: attr(data-language);
  display: block;
  background: linear-gradient(90deg, #1a2639, #1e293b);
  color: #94a3b8;
  font-size: 0.75rem;
  font-weight: 600;
  padding: 0.6rem 1.2rem;
  border-bottom: 1px solid #334155;
  text-transform: uppercase;
  letter-spacing: 1px;
}

 pre code {
  display: block;
  padding: 1.8rem;
  background: #0f172a;
  color: #e2e8f0;
  font-family: 'SF Mono', 'Monaco', 'Fira Code', 'Consolas', monospace;
  font-size: 0.9rem;
  line-height: 1.6;
  overflow-x: auto;
  tab-size: 2;
  white-space: pre;
}

h1 {
  font-size: 2.5rem;
  font-weight: 700;
  margin-top: 2rem;
  margin-bottom: 1rem;
  padding-bottom: 0.5rem;
  border-bottom: 2px solid #2563eb;
  letter-spacing: -0.02em;
}

 h2 {
  font-size: 1.8rem;
  font-weight: 600;
  margin-top: 2rem;
  margin-bottom: 0.75rem;
}

h3 {
  font-size: 1.5rem;
  font-weight: 600;
  margin-top: 1.5rem;
  margin-bottom: 0.5rem;
}

a {
  color: #2563eb;
  text-decoration: none;
  font-weight: 500;
  border-bottom: 1px solid transparent;
  transition: border-color 0.2s ease;
}

 a:hover {
  border-bottom-color: #2563eb;
}

blockquote {
  padding: 0.5rem 1.5rem;
  margin: 1.5rem 0;
  background: #f8fafc;
  border-left: 5px solid #2563eb;
  border-radius: 0 8px 8px 0;
  color: #475569;
  font-style: italic;
}

 ul,t ol {
  padding-left: 2rem;
  margin: 1rem 0;
}

 li {
  margin: 0.5rem 0;
}

 table {
  width: 100%;
  border-collapse: collapse;
  margin: 1.5rem 0;
  border-radius: 12px;
  overflow: hidden;
  box-shadow: 0 4px 6px -1px rgba(0,0,0,0.1);
}

th {
  background: #f1f5f9;
  font-weight: 600;
  padding: 0.75rem 1rem;
  border: 1px solid #e2e8f0;
}

td {
  padding: 0.75rem 1rem;
  border: 1px solid #e2e8f0;
}

img {
  max-width: 100%;
  border-radius: 12px;
  box-shadow: 0 4px 6px -1px rgba(0,0,0,0.1);
  border: 1px solid #e2e8f0;
}

hr {
  height: 2px;
  background: linear-gradient(90deg, transparent, #2563eb, transparent);
  border: 0;
  margin: 2rem 0;
}

  }
</style>
`;

async function convertHtmlToPdf() {
  let browser;
  try {
    // Check if input file exists
    if (!fs.existsSync(inputPath)) {
      console.error(`Input file not found: ${inputPath}`);
      return;
    }

    console.log(`Reading HTML from: ${inputPath}`);

    // Write HTML to a temporary file in the current directory
    const tempHtmlPath = path.join(process.cwd(), "temp-convert.html");
    fs.writeFileSync(tempHtmlPath, html, "utf8");
    console.log(`Temporary HTML written to: ${tempHtmlPath}`);

    browser = await puppeteer.launch();
    const page = await browser.newPage();

    console.log("Loading HTML...");
    // Load from file:// URL to preserve styles
    const fileUrl = `file://${tempHtmlPath.replace(/\\/g, "/")}`;
    await page.goto(fileUrl, {
      waitUntil: "domcontentloaded",
      timeout: 10000
    });

    // Wait for CSS to fully render
    await new Promise(resolve => setTimeout(resolve, 1000));

    console.log("Generating PDF...");
    // Generate PDF with A4 format, proper margins, and background colors
    await page.pdf({
      path: outputPath,
      format: "A4",
      margin: { top: "1cm", right: "1cm", bottom: "1cm", left: "1cm" },
      printBackground: true,  // This renders all background colors and CSS effects
      scale: 1
    });

    await browser.close();

    // Clean up temporary file
    fs.unlinkSync(tempHtmlPath);
    console.log(`✓ PDF generated successfully: ${outputPath}`);
  } catch (error) {
    console.error("Error converting HTML to PDF:", error.message);
    if (browser) {
      await browser.close();
    }
    process.exit(1);
  }
}

convertHtmlToPdf();
