import fs from "fs";
import path from "path";
import puppeteer from "puppeteer";

const outputPath = "converted-from-html.pdf";

// Read the HTML file
const htmlContent = fs.readFileSync("markdowntohtmlproblem.html", "utf8");

// Extract all styles from the HTML (both <style> tags and inline styles are preserved)
// We'll wrap the content to ensure proper styling
const html = `
<html>
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
${htmlContent.includes("<style>") ? "" : "<style>body { margin: 20px; font-family: Arial, sans-serif; }</style>"}
</head>
<body>
${htmlContent.replace(/<html>|<\/html>|<head>.*?<\/head>/gis, "")}
</body>
</html>`;

async function convertHtmlToPdf() {
  try {
    const browser = await puppeteer.launch();
    const page = await browser.newPage();

    // Set content with proper waiting
    await page.setContent(html, { waitUntil: "networkidle0" });

    // Generate PDF with A4 format and proper margins
    await page.pdf({
      path: outputPath,
      format: "A4",
      margin: { top: "1cm", right: "1cm", bottom: "1cm", left: "1cm" }
    });

    await browser.close();
    console.log(`✓ PDF generated successfully: ${outputPath}`);
  } catch (error) {
    console.error("Error converting HTML to PDF:", error);
  }
}

convertHtmlToPdf();
