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
    public partial class TestListForm : Form
    {
        public TestListForm()
        {
            InitializeComponent();
        }

        private void TestListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new TestsList().GetAllTests();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.CreateNewTests();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a course");
            else
            {
                var c = (Tests)dgv.SelectedRows[0].DataBoundItem;
                new TestEditForm().UpdateTests(c);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a course");
            else
            {
                var c = (Tests)dgv.SelectedRows[0].DataBoundItem;
                new TestsManager().Delete(c.Id);
                LoadData();
                MessageBox.Show("Deleted!");            }

        }
    }
}
