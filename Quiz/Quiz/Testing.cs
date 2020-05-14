using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quiz
{
    public partial class testingForm : Form
    {
        List<Questions> questions;
        int iterator = 0;
        public testingForm()
        {
            InitializeComponent();
        }

        public testingForm(List<Questions> questions)
        {
            InitializeComponent();
            this.questions = questions;
            NextQuestion();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach(var item in checkedListBox1.CheckedItems)
            {
                if (((Answer)item).check)
                    questions[iterator - 1].check = true;
                else
                    questions[iterator - 1].check = false;
            }
            if (iterator == questions.Count)
                button2.Visible = true;
            NextQuestion();
        }
        private void NextQuestion()
        {
            while (iterator <= questions.Count - 1)
            {
                checkedListBox1.Items.Clear();
                label2.Text = $"{iterator + 1}/{questions.Count}";
                lblQuestion.Text = questions[iterator].Question;

                for (int i = 0; i < questions[iterator].answers.Count; i++)
                    checkedListBox1.Items.Add(questions[iterator].answers[i]);
                iterator++;
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int checkTrueAnswers = 0;
            foreach (var item in questions)
                if (item.check)
                    checkTrueAnswers++;

            DialogResult dr = MessageBox.Show($" Testing complete \n Correct answers: {checkTrueAnswers}", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            if (dr == DialogResult.OK)
                this.Close();
        }

        private void Testing_Load(object sender, EventArgs e)
        {}

        private void label2_Click(object sender, EventArgs e)
        {}

        private void label3_Click(object sender, EventArgs e)
        {}

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}
    }
}
