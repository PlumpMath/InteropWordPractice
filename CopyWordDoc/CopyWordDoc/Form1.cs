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
            var imagePath = "F:\\Akhilesh Docs\\Github Projects\\InteropWordPractice\\CopyWordDoc\\images\\introspects.png";
            doc.Application.ActiveDocument.Shapes.AddPicture(imagePath, Type.Missing, Type.Missing, 140, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //adding first line. this didnt work. check insertafter method
            doc.Application.ActiveDocument.Characters.Last.Select();
            app.Selection.Collapse();
            app.Selection.TypeText("Description of Aptitudes and Inclination Report");
            doc.Application.ActiveDocument.Save();

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
