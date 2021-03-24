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
    public partial class ApplicantEditForm : Form
    {
        public ApplicantEditForm()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewApplicant()
        {
            Mode = FormMode.CreateNew;
            Applicant = new Applicant();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            Mode = FormMode.Update;
            Applicant = applicant;
            InitializeControls();
            ShowApplicantInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
           cbxTest.DataSource = new TestsManager().GetAll();
        }

        private void ShowApplicantInControls()
        {
            tbxName.Text = Applicant.Name;
            nudScore.Value = Applicant.Score;
            cbxTest.SelectedItem = Applicant.TestTaken.ToString();//Fix up later
        }

        private void GrabUserInput()
        {
            Applicant.Name = tbxName.Text;
            Applicant.Score = Convert.ToInt32(nudScore.Value);//Watch out for this piece of code
            Applicant.TestTaken = Convert.ToString((Tests)cbxTest.SelectedItem);
            //Applicant.TestTaken = (Tests)cbxTest.SelectedItem; Fix up later
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new ApplicantManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Applicant);
                else
                    manager.Update(Applicant);

                MyForms.GetForm<ApplicantListForm>().LoadData();
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
