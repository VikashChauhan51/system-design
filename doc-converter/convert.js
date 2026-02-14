import fs from "fs";
import MarkdownIt from "markdown-it";
import puppeteer from "puppeteer";

const md = new MarkdownIt();

const markdown = fs.readFileSync("input.md", "utf8");
const htmlContent = md.render(markdown);
const cssContent = fs.readFileSync("style.css", "utf8");

const html = `
<html>
<head>
<style>
${cssContent}
</style>
</head>
<body>
  ${htmlContent}
</body>
</html>`;

const browser = await puppeteer.launch();
const page = await browser.newPage();
await page.setContent(html, { waitUntil: "networkidle0" });
await page.pdf({ path: "output.pdf", format: "A4" });
await browser.close();
