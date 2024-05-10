using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergePDF
{
    public class PdfMerger
    {
        public void MergePdfFiles(string firstPdfPath, string secondPdfPath, string outputPdfPath)
        {
            using (FileStream outputStream = new FileStream(outputPdfPath, FileMode.Create))
            {
                Document document = new Document();
                PdfCopy pdfCopy = new PdfCopy(document, outputStream);
                document.Open();

                AddPdfToMerge(pdfCopy, firstPdfPath);
                AddPdfToMerge(pdfCopy, secondPdfPath);

                document.Close();
            }
        }

        private void AddPdfToMerge(PdfCopy pdfCopy, string pdfFilePath)
        {
            PdfReader pdfReader = new PdfReader(pdfFilePath);
            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
            {
                PdfImportedPage importedPage = pdfCopy.GetImportedPage(pdfReader, page);
                pdfCopy.AddPage(importedPage);
            }
            pdfReader.Close();
        }
    }
}
