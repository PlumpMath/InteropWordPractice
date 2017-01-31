using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace CopyWordDoc
{
    public partial class Form1 : Form
    {
        Word.Application app = new Word.Application();
        //doc.SaveAs2("F:\\Akhilesh Docs\\Github Projects\\InteropWordPractice\\CopyWordDoc\\sample_output.docx");
        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Word.Document doc = app.Documents.Add();
            //adding image
            //var imagePath = "F:\\Akhilesh Docs\\Github Projects\\InteropWordPractice\\CopyWordDoc\\images\\introspects.png";
            var imagePath = "D:\\Learning\\My Projects\\InteropWordPractice\\CopyWordDoc\\images\\introspects.png";
            //doc.Application.ActiveDocument.Shapes.AddPicture(imagePath, Type.Missing, Type.Missing, 140, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            var paraImage = doc.Paragraphs.Add();
            paraImage.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            doc.InlineShapes.AddPicture(imagePath, Range: paraImage.Range);

            //adding first line.
            var paraText = doc.Paragraphs.Add();
            paraText.Range.Text = "Description of Aptitudes and Inclination Report ";
            paraText.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            Word.Range range = doc.Range(paraText.Range.Start, paraText.Range.End);
            range.Font.Size = 16;
            range.Font.Name = "Calibri";
            paraText.Range.InsertParagraphAfter();

            //adding table
            var paraTable = doc.Paragraphs.Add();
            var table = doc.Tables.Add(paraTable.Range, 4, 2);
            object[,] array = new object[4, 2];
            array[0, 0] = "Code:7";
            array[0, 1] = "";
            array[1, 0] = "Tester Tester";
            array[1,1] = "Code:7";

            https://kellyschronicles.wordpress.com/2011/08/01/write-datatable-to-an-ms-word-table-efficiently-with-c-using-a-dynamic-type/
        http://stackoverflow.com/questions/12718044/how-to-add-items-one-at-a-time-to-to-a-new-line-a-word-document-using-word-inter
            //showing the document
            app.Visible = true;
            Application.Exit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
