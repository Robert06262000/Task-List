namespace Task_List_Finals
{
    partial class Task_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTask = new System.Windows.Forms.TextBox();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.taskListView = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxTask
            // 
            this.tbxTask.Location = new System.Drawing.Point(4, 59);
            this.tbxTask.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxTask.Name = "tbxTask";
            this.tbxTask.Size = new System.Drawing.Size(713, 20);
            this.tbxTask.TabIndex = 1;
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(4, 95);
            this.tbxDesc.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(713, 20);
            this.tbxDesc.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(4, 81);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(710, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // lblTask
            // 
            this.lblTask.Location = new System.Drawing.Point(4, 46);
            this.lblTask.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(710, 13);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Task";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 119);
            this.btnNew.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 27);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(189, 119);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 27);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 119);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(565, 119);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // taskListView
            // 
            this.taskListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskListView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskListView.Location = new System.Drawing.Point(6, 161);
            this.taskListView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.taskListView.Name = "taskListView";
            this.taskListView.RowHeadersWidth = 123;
            this.taskListView.RowTemplate.Height = 46;
            this.taskListView.Size = new System.Drawing.Size(708, 262);
            this.taskListView.TabIndex = 9;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(460, 19);
            this.lblCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 13);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "Task Count: ";
            // 
            // Task_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(764, 452);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.taskListView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.tbxTask);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Task_List";
            this.Text = "Task List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Task_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTask;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView taskListView;
        private System.Windows.Forms.Label lblCount;
    }
}

