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
    public partial class TestEditForm : Form
    {
        public TestEditForm()
        {
            InitializeComponent();
        }
        public Tests Tests { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewTests()
        {
            Mode = FormMode.CreateNew;
            Tests = new Tests();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateTests(Tests tests)
        {
            Mode = FormMode.Update;
            Tests = tests;
            InitializeControls();
            ShowTestsInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowTestsInControls()
        {
            tbxName.Text = Tests.Name;//Show populated data in Edit Form
            tbxQuestion1.Text = Tests.Question1;
            tbxQuestion2.Text = Tests.Question2;
            tbxQuestion3.Text = Tests.Question3;
            tbxAnswer1.Text = Tests.Question1Answer;
            tbxAnswer2.Text = Tests.Question2Answer;
            tbxAnswer3.Text = Tests.Question3Answer;
        }

        private void GrabUserInput()
        {
            Tests.Name = tbxName.Text;
            Tests.Question1 = tbxQuestion1.Text;
            Tests.Question1Answer = tbxAnswer1.Text;
            Tests.Question2 = tbxQuestion2.Text;
            Tests.Question2Answer = tbxAnswer2.Text;
            Tests.Question3 = tbxQuestion3.Text;
            Tests.Question3Answer = tbxAnswer3.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new TestsManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Tests);
                else
                    manager.Update(Tests);

                MyForms.GetForm<TestListForm>().LoadData();//This code instantly refreshes data everytime users hit save button
                MessageBox.Show("Saved!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
