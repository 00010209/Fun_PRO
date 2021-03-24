using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW2._10209
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbout = new AboutForm();
            formAbout.ShowDialog();
        }

        private void allApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<ApplicantListForm>().Show();
        }

        private void allTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<TestListForm>().Show();
        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.CreateNewTests();
        }

        private void newApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ApplicantEditForm().CreateNewApplicant();
        }
    }
}
