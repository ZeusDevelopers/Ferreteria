using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    class cls_reporte
    {
        public void Genera(DataTable tb,string usu,string sub,string iva,string tot)
        {            
            MyClass m = new MyClass();
            m.CreatePDF(tb,usu,sub,iva,tot);
            System.Diagnostics.Process.Start(@".\cotizar.pdf");
        }
    }
}
class MyClass
{


    public void CreatePDF(DataTable dt,string usuario,string sub,string iva,string tot)
    {
        string fileName = "uno";

        DateTime fileCreationDatetime = DateTime.Now;

        fileName = string.Format("{0}.pdf", fileCreationDatetime.ToString(@"yyyyMMdd") + "_" + fileCreationDatetime.ToString(@"HHmmss"));

        //string pdfPath= @"C:\Users\salaz\Downloads\ASS4SSINSCR33DFLL\mio.pdf";
        string pdfPath = @".\cotizar.pdf";
        using (FileStream msReport = new FileStream(pdfPath, FileMode.Create))
        {
            //step 1
            using (Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 140f, 10f))
            {
                try
                {
                    // step 2
                    PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, msReport);
                    ITextEvents it = new ITextEvents();
                    it.Usu = usuario;
                    pdfWriter.PageEvent = it;
                        
                    

                    //open the stream 
                    pdfDoc.Open();
                      Paragraph para = new Paragraph("Cotizacion   ", new Font(Font.FontFamily.HELVETICA, 16,Font.NORMAL,BaseColor.RED));
                    Paragraph para2 = new Paragraph(Environment.NewLine, new Font(Font.FontFamily.HELVETICA, 16, Font.NORMAL, BaseColor.RED));
                    para.Alignment = Element.ALIGN_CENTER;

                        pdfDoc.Add(para);
                    pdfDoc.Add(para2);                    

                    ////////////////Agregar Datatable/////////////////////
                    Font font5 =FontFactory.GetFont(FontFactory.HELVETICA, 13);
                    Font font6= FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 15);
                    PdfPTable table = new PdfPTable(dt.Columns.Count);
                    PdfPRow row = null;
                    float[] widths = new float[] { 4f, 4f, 4f, 4f };

                  //  table.SetWidths(widths);

                    table.WidthPercentage = 90;
                    int iCol = 0;
                    string colname = "";
                    PdfPCell cell = new PdfPCell(new Phrase("Products"));

                    cell.Colspan = dt.Columns.Count;

                    foreach (DataColumn c in dt.Columns)
                    {

                        table.AddCell(new Phrase(c.ColumnName, font6));
                    }
                    int conta = 0;
                    foreach (DataRow r in dt.Rows)
                    {
                        if (conta < 29)
                        {
                            conta++;
                            table.AddCell(new Phrase(r[0].ToString(), font5));
                            table.AddCell(new Phrase(r[1].ToString(), font5));
                            table.AddCell(new Phrase(r[2].ToString(), font5));
                            table.AddCell(new Phrase(r[3].ToString(), font5));
                        }
                        else
                        {
                            pdfDoc.Add(table);
                            table.DeleteBodyRows();
                            pdfDoc.NewPage();
                            conta = 0;
                        }
                    }
                    pdfDoc.Add(table);
                    Paragraph para3 = new Paragraph("                   "+"                   "+"                   "+"Subtotal: " +sub.ToString(), new Font(Font.FontFamily.HELVETICA, 16, Font.NORMAL, BaseColor.RED));
                    Paragraph para4 = new Paragraph("                   " + "                   " + "                   " + "   I.V.A: " + iva.ToString(), new Font(Font.FontFamily.HELVETICA, 16, Font.NORMAL, BaseColor.RED));
                    Paragraph para5 = new Paragraph("                   " + "                   " + "                   " + "     Total: " + tot.ToString(), new Font(Font.FontFamily.HELVETICA, 16, Font.NORMAL, BaseColor.RED));
                    para3.Alignment = Element.ALIGN_CENTER;
                    para4.Alignment = Element.ALIGN_CENTER;
                    para5.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(para3);
                    pdfDoc.Add(para4);
                    pdfDoc.Add(para5);
                    /////////////////////////////////////

                    pdfDoc.Close();

                }
                catch (Exception ex)
                {
                    //handle exception
                    MessageBox.Show(ex.Message);
                }

                finally
                {


                }

            }

        }
    }
}
public class ITextEvents : PdfPageEventHelper
{

    // This is the contentbyte object of the writer
    PdfContentByte cb;

    // we will put the final number of pages in a template
    PdfTemplate headerTemplate, footerTemplate;

    // this is the BaseFont we are going to use for the header / footer
    BaseFont bf = null;
   
    // This keeps track of the creation time
    DateTime PrintTime = DateTime.Now;


    #region Fields
    private string _header,_usu;
    #endregion

    #region Properties
    public string Header
    {
        get { return _header; }
        set { _header = value; }
    }
    public string Usu
    {
        get { return _usu; }
        set { _usu = value; }
    }
    #endregion


    public override void OnOpenDocument(PdfWriter writer, Document document)
    {
        try
        {
            PrintTime = DateTime.Now;
            bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb = writer.DirectContent;
            headerTemplate = cb.CreateTemplate(10, 100);
            footerTemplate = cb.CreateTemplate(50, 50);
        }
        catch (DocumentException de)
        {

        }
        catch (System.IO.IOException ioe)
        {

        }
    }

    public override void OnEndPage(iTextSharp.text.pdf.PdfWriter writer, iTextSharp.text.Document document)
    {
        base.OnEndPage(writer, document);

        Font baseFontNormal = new Font(Font.FontFamily.HELVETICA, 08f,Font.NORMAL,BaseColor.BLACK);
        Font baseFonttitulo = new Font(Font.FontFamily.HELVETICA, 21f, Font.BOLD, BaseColor.BLUE);
        Font baseFontBig = new Font(Font.FontFamily.HELVETICA, 12f,Font.BOLD,BaseColor.BLACK);
        Font baseFont = new Font(Font.FontFamily.HELVETICA, 17f, Font.BOLD, BaseColor.BLACK);

        Phrase p1Header = new Phrase("                 "+"PLOMERIA Y FERRETERIA VEGA", baseFonttitulo);

        //Create PdfTable object
        PdfPTable pdfTab = new PdfPTable(1);
        
        //We will have to create separate cells to include image logo and 2 separate strings
        //Row 1
        //PdfPCell pdfCell1 = new PdfPCell();
        PdfPCell pdfCell1 = new PdfPCell(p1Header);
        PdfPCell pdfCell3 = new PdfPCell();
       
        //Add paging to footer
        {
            //cb.BeginText();
            //cb.SetFontAndSize(bf, 12);
            //cb.SetTextMatrix(document.PageSize.GetRight(180), document.PageSize.GetBottom(30));
            //cb.ShowText(text);
            //cb.EndText();
            //float len = bf.GetWidthPoint(text, 12);
            //cb.AddTemplate(footerTemplate, document.PageSize.GetRight(180) + len, document.PageSize.GetBottom(30));
        }
        //Row 2
        PdfPCell pdfCell4 = new PdfPCell(new Phrase("MARITZA FELIX QUINONEZ                                                                                                            "+ "Fecha: " + PrintTime.ToShortDateString()+
            Environment.NewLine+
 "R.F.C FEQM - 661228 - 1MA                                                                                                            " + "Hora: " + string.Format("{0:t}", DateTime.Now) + Environment.NewLine +
 "REGIMEN FISCAL: INCORPORACION FISCAL", baseFontNormal));
        
        //Row 3        
        PdfPCell pdfCell6 = new PdfPCell(new Phrase("                       " +
            "                         " +
            "            Empleado: "+_usu,baseFont));
         


        //set the alignment of all three cells and set border to 0
        pdfCell1.HorizontalAlignment = Element.ALIGN_LEFT;
        pdfCell3.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell4.HorizontalAlignment = Element.ALIGN_LEFT;        
        pdfCell6.HorizontalAlignment = Element.ALIGN_CENTER;
                
        pdfCell3.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell4.VerticalAlignment = Element.ALIGN_TOP;
        pdfCell6.VerticalAlignment = Element.ALIGN_MIDDLE;       


        pdfCell4.Colspan = 30;   
        pdfCell1.Border = 0;     
        pdfCell3.Border = 4;
        pdfCell4.Border = 0;    
        pdfCell6.Border = 0;      


        //add all three cells into PdfTable
        pdfTab.AddCell(pdfCell1);        
       //pdfTab.AddCell(pdfCell6);
        //pdfTab.AddCell(pdfCell6);
        pdfTab.AddCell(pdfCell4);
        //pdfTab.AddCell(pdfCell6);        
        pdfTab.AddCell(pdfCell6);
        pdfTab.TotalWidth = document.PageSize.Width - 80f;
        pdfTab.WidthPercentage = 70;
        //pdfTab.HorizontalAlignment = Element.ALIGN_CENTER;


        //call WriteSelectedRows of PdfTable. This writes rows from PdfWriter in PdfTable
        //first param is start row. -1 indicates there is no end row and all the rows to be included to write
        //Third and fourth param is x and y position to start writing
        pdfTab.WriteSelectedRows(0, -1, 40, document.PageSize.Height - 30, writer.DirectContent);
        //set pdfContent value

        //Move the pointer and draw line to separate header section from rest of page
        cb.MoveTo(40, document.PageSize.Height - 110);
        cb.LineTo(document.PageSize.Width - 40, document.PageSize.Height - 110);
        cb.Stroke();

        //Move the pointer and draw line to separate footer section from rest of page
        cb.MoveTo(40, document.PageSize.GetBottom(50));
        cb.LineTo(document.PageSize.Width - 40, document.PageSize.GetBottom(50));
        cb.Stroke();
    }

    public override void OnCloseDocument(PdfWriter writer, Document document)
    {
        base.OnCloseDocument(writer, document);

        headerTemplate.BeginText();
        headerTemplate.SetFontAndSize(bf, 12);
        headerTemplate.SetTextMatrix(0, 0);
        headerTemplate.ShowText((writer.PageNumber - 1).ToString());
        headerTemplate.EndText();

        footerTemplate.BeginText();
        footerTemplate.SetFontAndSize(bf, 12);
        footerTemplate.SetTextMatrix(0, 0);
        footerTemplate.ShowText((writer.PageNumber - 1).ToString());
        footerTemplate.EndText();


    }
}