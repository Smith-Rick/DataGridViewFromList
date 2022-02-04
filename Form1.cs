using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DataGridViewFromList
{
    public partial class Form1 : Form
    {

        private List<MemberRecord> _memberRecords;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {

            if (FilterBox.Text != String.Empty)
            {
                var tempMemberRecords = new List<MemberRecord>();
                
                foreach (var member in _memberRecords)
                {
                    if (member.LastName == FilterBox.Text)
                    {
                        tempMemberRecords.Add(member);
                    }
                }

                dataGridView1.DataSource = tempMemberRecords;
            }
            else
            {
                dataGridView1.DataSource = _memberRecords;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                _memberRecords = new List<MemberRecord>
                {
                    new MemberRecord()
                    {
                        FirstName = "Joseph",
                        LastName = "Smith"
                    },
                    new MemberRecord()
                    {
                        FirstName = "Oliver",
                        LastName = "Cowdery"
                    },
                    new MemberRecord()
                    {
                        FirstName = "David",
                        LastName = "Whitmer"
                    },
                    new MemberRecord()
                    {
                        FirstName = "Martin",
                        LastName = "Harris"
                    },
                    new MemberRecord()
                    {
                        FirstName = "Hyrum",
                        LastName = "Smith"
                    },
                    new MemberRecord()
                    {
                        FirstName = "Samuel",
                        LastName = "Smith"
                    },
                    new MemberRecord()
                    {
                        FirstName = "Jacob",
                        LastName = "Whitmer"
                    }
                };

                dataGridView1.DataSource = _memberRecords;


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            FilterBox.Text = String.Empty;
            dataGridView1.DataSource = _memberRecords;
        }
    }
}
