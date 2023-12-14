using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace htmlXML
{
    public partial class Form1 : Form
    {

        private string path = "C:\\sheva\\oop\\lab22\\university.xml";
        private object myClub;

        public Form1()
        {
            InitializeComponent();

            buildBox(comboBox_faculty_SelectedIndexChanged, comboBox_day_SelectedIndexChanged, comboBox_leader_SelectedIndexChanged, comboBox_orientation_SelectedIndexChanged);
        }

        private void buildBox(Action<object, EventArgs> comboBox_faculty_SelectedIndexChanged, Action<object, EventArgs> comboBox_day_SelectedIndexChanged, Action<object, EventArgs> comboBox_leader_SelectedIndexChanged, Action<object, EventArgs> comboBox_orientation_SelectedIndexChanged)
        {
            throw new NotImplementedException();
        }

        private void buildBox(ComboBox comboBox_faculty, ComboBox comboBox_day, ComboBox comboBox_leader, ComboBox comboBox_orientation)
        {
            IParse p = new LinqToXml();
            List<Search> res = p.AnalazeFiles(new Search(), path);
            List<string> faculty = new List<string>();
            List<string> day = new List<string>();
            List<string> leader = new List<string>();
            List<string> orientation = new List<string>();

            foreach (Search elem in res)
            {
                if (!faculty.Contains(elem.faculty))
                {
                    faculty.Add(elem.faculty);
                }
                if (!day.Contains(elem.day))
                {
                    day.Add(elem.day);
                }
                if (!leader.Contains(elem.leader))
                {
                    faculty.Add(elem.leader);
                }
                if (!orientation.Contains(elem.orientation))
                {
                    faculty.Add(elem.orientation);
                }
            }

            faculty = faculty.OrderBy(x => x).ToList();
            day = day.OrderBy(x => x).ToList();
            leader = leader.OrderBy(x => x).ToList();
            orientation = orientation.OrderBy(x => x).ToList();

            comboBox_faculty.Items.AddRange(faculty.ToArray());
            comboBox_day.Items.AddRange(day.ToArray());
            comboBox_leader.Items.AddRange(leader.ToArray());
            comboBox_orientation.Items.AddRange(orientation.ToArray());
        }

        private void ParsingNames(object sender)
        {
            CheckBox temp = sender as CheckBox;
            switch (temp.Text)
            {
                case "Faculty":
                    comboBox_faculty_SelectedIndexChanged = " ";
                    if (temp.CheckState == CheckState.Checked)
                    {
                        comboBox_faculty_SelectedIndexChanged.Enabled = false;
                    }
                    else
                    {
                        comboBox_faculty_SelectedIndexChanged.Disabled = true;
                        myClub = null;
                    }
                    break;


                case "Day":
                    comboBox_day_SelectedIndexChanged = " ";
                    if (temp.CheckState == CheckState.Checked)
                    {
                        comboBox_day_SelectedIndexChanged.Enabled = false;
                    }
                    else
                    {
                        comboBox_day_SelectedIndexChanged.Disabled = true;
                        myDay = null;
                    }
                    break;


                case "Leader":
                    comboBox_leader_SelectedIndexChanged = " ";
                    if (temp.CheckState == CheckState.Checked)
                    {
                        comboBox_faculty_SelectedIndexChanged.Enabled = false;
                    }
                    else
                    {
                        comboBox_faculty_SelectedIndexChanged.Disabled = true;
                        myLeader = null;
                    }
                    break;

                case "Orientation":
                    comboBox_orientation_SelectedIndexChanged = " ";
                    if (temp.CheckState == CheckState.Checked)
                    {
                        comboBox_orientation_SelectedIndexChanged.Enabled = false;
                    }
                    else
                    {
                        comboBox_orientation_SelectedIndexChanged.Disabled = true;
                        myOrientation = null;
                    }
                    break;


            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_day_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_orientation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_leader_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_orientation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
