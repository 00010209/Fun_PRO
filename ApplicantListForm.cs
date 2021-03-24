using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunPro_CW2_10209.DAL;

namespace FunPro.CW2._10209
{
    public partial class ApplicantListForm : Form
    {
        public ApplicantListForm()
        {
            InitializeComponent();
        }

        private void ApplicantListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new ApplicantList().GetAllApplicants();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                ByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Score;
                else if (cbxSort.SelectedIndex == 1)
                    selectedAttribute = ByAttribute.Name;
                else selectedAttribute = ByAttribute.TestsTaken;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new ApplicantList().Sort(selectedAttribute);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to search by");
            else if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Provide the search term");
            else
            {
                var selectedAttribute = cbxSearch.SelectedIndex == 0 ? ByAttribute.Name : ByAttribute.Score;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new ApplicantList().Search(tbxSearch.Text, selectedAttribute);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ApplicantEditForm().CreateNewApplicant();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an applicant");
            else
            {
                var c = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new ApplicantEditForm().UpdateApplicant(c);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an applicant");
            else
            {
                var c = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new ApplicantManager().Delete(c.Id);
                LoadData();
                MessageBox.Show("Deleted!");
            }
        }
    }
}
