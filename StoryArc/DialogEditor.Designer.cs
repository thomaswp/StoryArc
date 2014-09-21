namespace StoryArc
{
    partial class DialogEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDialog = new System.Windows.Forms.ComboBox();
            this.groupBoxDialog = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.actionList1 = new StoryArc.ActionList();
            this.groupBoxDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dialog:";
            // 
            // comboBoxDialog
            // 
            this.comboBoxDialog.FormattingEnabled = true;
            this.comboBoxDialog.Location = new System.Drawing.Point(61, 7);
            this.comboBoxDialog.Name = "comboBoxDialog";
            this.comboBoxDialog.Size = new System.Drawing.Size(252, 24);
            this.comboBoxDialog.TabIndex = 1;
            this.comboBoxDialog.SelectedIndexChanged += new System.EventHandler(this.comboBoxDialog_SelectedIndexChanged);
            // 
            // groupBoxDialog
            // 
            this.groupBoxDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDialog.Controls.Add(this.actionList1);
            this.groupBoxDialog.Controls.Add(this.textBoxName);
            this.groupBoxDialog.Controls.Add(this.labelName);
            this.groupBoxDialog.Location = new System.Drawing.Point(6, 37);
            this.groupBoxDialog.Name = "groupBoxDialog";
            this.groupBoxDialog.Size = new System.Drawing.Size(645, 415);
            this.groupBoxDialog.TabIndex = 2;
            this.groupBoxDialog.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(65, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(285, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name: ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(427, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 26);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(319, 7);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(102, 27);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Create New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // actionList1
            // 
            this.actionList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionList1.Location = new System.Drawing.Point(9, 52);
            this.actionList1.Name = "actionList1";
            this.actionList1.Size = new System.Drawing.Size(630, 357);
            this.actionList1.TabIndex = 2;
            // 
            // DialogEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.groupBoxDialog);
            this.Controls.Add(this.comboBoxDialog);
            this.Controls.Add(this.label1);
            this.Name = "DialogEditor";
            this.Size = new System.Drawing.Size(654, 455);
            this.groupBoxDialog.ResumeLayout(false);
            this.groupBoxDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDialog;
        private System.Windows.Forms.GroupBox groupBoxDialog;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private ActionList actionList1;
    }
}
