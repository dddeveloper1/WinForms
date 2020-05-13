using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Event_planer
{
    public partial class Form1 : Form
    {
        EventList list = new EventList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Event myEvent = new Event
            {
                EventName = tbEventName.Text,
                EventDate = dtpEventDate.Value,
                Place = tbEventPlace.Text,
            };

            if (comboBox1.SelectedItem != null)
                myEvent.Priority = comboBox1.SelectedItem.ToString();
            else
                myEvent.Priority = "Middle";
            list.AddEvent(myEvent);
            listBox1.Items.Add(myEvent);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbEventName.Text = String.Empty;
            tbEventPlace.Text = String.Empty;
            comboBox1.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file = dtpEventDate.Value.ToShortDateString() + "_EventPlanner.xml";
            XmlSerializer xml = new XmlSerializer(list.GetType());
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, list);
            }
            MessageBox.Show("Completed!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(EventList));
            string file = dtpEventDate.Value.ToShortDateString() + "_EventPlanner.xml";
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                list = (EventList)xml.Deserialize(stream);
            }
            MessageBox.Show("Compreted!");
            ShowInListBox();
        }

        private void ShowInListBox()
        {
            listBox1.Items.Clear();
            foreach (var item in list.Events)
            {
                listBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
