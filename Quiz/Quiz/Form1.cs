using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Quiz
{
    public partial class testingSystem : Form
    {
        List<Questions> questions = new List<Questions>();
        public testingSystem()
        {
            InitializeComponent();
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Questions>));
                string file = openFileDialog1.FileName;
                using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    questions = (List<Questions>)xml.Deserialize(stream);
                testingForm testingForm = new testingForm(questions);
                DialogResult dr = testingForm.ShowDialog();
            }
            Application.Exit();
        }

        private void QuizSystem_Load(object sender, EventArgs e)
        {

        }

    }
}
