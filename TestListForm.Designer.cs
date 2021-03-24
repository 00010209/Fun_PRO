namespace FunPro.CW2._10209
{
    partial class TestListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question1AnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question2AnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question3AnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.question1DataGridViewTextBoxColumn,
            this.question1AnswerDataGridViewTextBoxColumn,
            this.question2DataGridViewTextBoxColumn,
            this.question2AnswerDataGridViewTextBoxColumn,
            this.question3DataGridViewTextBoxColumn,
            this.question3AnswerDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.testsBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(874, 470);
            this.dgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // question1DataGridViewTextBoxColumn
            // 
            this.question1DataGridViewTextBoxColumn.DataPropertyName = "Question1";
            this.question1DataGridViewTextBoxColumn.HeaderText = "Question1";
            this.question1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.question1DataGridViewTextBoxColumn.Name = "question1DataGridViewTextBoxColumn";
            this.question1DataGridViewTextBoxColumn.ReadOnly = true;
            this.question1DataGridViewTextBoxColumn.Width = 125;
            // 
            // question1AnswerDataGridViewTextBoxColumn
            // 
            this.question1AnswerDataGridViewTextBoxColumn.DataPropertyName = "Question1Answer";
            this.question1AnswerDataGridViewTextBoxColumn.HeaderText = "Question1Answer";
            this.question1AnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.question1AnswerDataGridViewTextBoxColumn.Name = "question1AnswerDataGridViewTextBoxColumn";
            this.question1AnswerDataGridViewTextBoxColumn.ReadOnly = true;
            this.question1AnswerDataGridViewTextBoxColumn.Width = 125;
            // 
            // question2DataGridViewTextBoxColumn
            // 
            this.question2DataGridViewTextBoxColumn.DataPropertyName = "Question2";
            this.question2DataGridViewTextBoxColumn.HeaderText = "Question2";
            this.question2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.question2DataGridViewTextBoxColumn.Name = "question2DataGridViewTextBoxColumn";
            this.question2DataGridViewTextBoxColumn.ReadOnly = true;
            this.question2DataGridViewTextBoxColumn.Width = 125;
            // 
            // question2AnswerDataGridViewTextBoxColumn
            // 
            this.question2AnswerDataGridViewTextBoxColumn.DataPropertyName = "Question2Answer";
            this.question2AnswerDataGridViewTextBoxColumn.HeaderText = "Question2Answer";
            this.question2AnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.question2AnswerDataGridViewTextBoxColumn.Name = "question2AnswerDataGridViewTextBoxColumn";
            this.question2AnswerDataGridViewTextBoxColumn.ReadOnly = true;
            this.question2AnswerDataGridViewTextBoxColumn.Width = 125;
            // 
            // question3DataGridViewTextBoxColumn
            // 
            this.question3DataGridViewTextBoxColumn.DataPropertyName = "Question3";
            this.question3DataGridViewTextBoxColumn.HeaderText = "Question3";
            this.question3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.question3DataGridViewTextBoxColumn.Name = "question3DataGridViewTextBoxColumn";
            this.question3DataGridViewTextBoxColumn.ReadOnly = true;
            this.question3DataGridViewTextBoxColumn.Width = 125;
            // 
            // question3AnswerDataGridViewTextBoxColumn
            // 
            this.question3AnswerDataGridViewTextBoxColumn.DataPropertyName = "Question3Answer";
            this.question3AnswerDataGridViewTextBoxColumn.HeaderText = "Question3Answer";
            this.question3AnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.question3AnswerDataGridViewTextBoxColumn.Name = "question3AnswerDataGridViewTextBoxColumn";
            this.question3AnswerDataGridViewTextBoxColumn.ReadOnly = true;
            this.question3AnswerDataGridViewTextBoxColumn.Width = 125;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataSource = typeof(FunPro_CW2_10209.DAL.Tests);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(942, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(942, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(942, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 61);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(942, 425);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 57);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 582);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Name = "TestListForm";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.TestListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn question1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn question1AnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn question2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn question2AnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn question3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn question3AnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testsBindingSource;
    }
}