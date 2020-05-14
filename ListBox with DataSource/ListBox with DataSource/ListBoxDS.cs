using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ListBox_with_DataSource
{
    public partial class ListBoxDS : Form
    {
        List<Unit> kindUnits = new List<Unit>
            {
                new Unit{Name = "Archer"},
                new Unit{Name = "Swordman"},
                new Unit{Name = "Mage"}
            };
        List<Unit> teamRed = new List<Unit>();
        List<Unit> teamBlue = new List<Unit>();
        int timer = 0;

        public ListBoxDS()
        {
            InitializeComponent();
            lbAll.DataSource = kindUnits;
            lbAll.DisplayMember = "Name";
        }

        private void ClearDataSource(ListBox lb, bool flag)
        {
            lb.DataSource = null;
            if (flag) lb.DataSource = teamRed;
            else lb.DataSource = teamBlue;
            lb.DisplayMember = "Name";
            lb.SelectedIndex = -1;
        }

        private void DeleteExtra(List<Unit> units)
        {
            units.RemoveAt(units.Count - 1);
        }

        private bool CheckTeamsSize(List<Unit> units)
        {
            return units.Count < this.nudTeamSize.Value;
        }

        private void btnAddToRedTeam_Click(object sender, EventArgs e)
        {
            if (!CheckTeamsSize(teamRed))
                return;
            teamRed.Add(kindUnits[lbAll.SelectedIndex]);
            ClearDataSource(lbRedTeam, true);
        }

        private void btnAddToBlueTeam_Click(object sender, EventArgs e)
        {
            if (!CheckTeamsSize(teamBlue))
                return;
            teamBlue.Add(kindUnits[lbAll.SelectedIndex]);
            ClearDataSource(lbBlueTeam, false);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked && rb.Text == "Red team")
                ClearDataSource(lbSelectedTeam, true);
            else if (rb.Checked && rb.Text == "Blue team")
                ClearDataSource(lbSelectedTeam, false);
        }

        private void nudTeamSize_ValueChanged(object sender, EventArgs e)
        {
            if (teamRed.Count > nudTeamSize.Value)
            {
                DeleteExtra(teamRed);
                ClearDataSource(lbRedTeam, true);
            }
            if (teamBlue.Count > nudTeamSize.Value)
            {
                DeleteExtra(teamBlue);
                ClearDataSource(lbBlueTeam, false);
            }
        }

        private void SaveToXML(string filename, List<Unit> team)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Unit>));
            using (Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                xml.Serialize(stream, team);
            }
            label2.Visible = true;
            timer1.Start();
        }

        private void btnSaveRedXml_Click(object sender, EventArgs e)
        {
            string file = (sender as Button).Text == "Save to XML (Red team)" ? "red_team.xml" : "blue_team.xml";
            SaveToXML(file, (sender as Button).Text == "Save to XML (Red team)" ? teamRed : teamBlue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++timer;
            if(timer == 2)
            {
                timer1.Stop();
                label2.Visible = false;
                timer = 0;
            }
        }
    }
}
