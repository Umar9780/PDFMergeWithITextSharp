using MergePDF;

string firstPdfPath = "C:\\Users\\Muham\\Downloads\\TourConfirmation.pdf";
string secondPdfPath = "C:\\Users\\Muham\\Downloads\\Terms & Conditions.pdf";

// Specify the output path for the merged PDF
string outputPdfPath = "C:\\Users\\Muham\\Downloads\\outputMergedPdf.pdf";

// Create an instance of the PdfMerger class
PdfMerger pdfMerger = new PdfMerger();

// Call the MergePdfFiles method to merge the PDF files
pdfMerger.MergePdfFiles(firstPdfPath, secondPdfPath, outputPdfPath);

// Output a message indicating the merge process is complete
Console.WriteLine("PDF files merged successfully!");