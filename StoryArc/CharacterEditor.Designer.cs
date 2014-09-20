namespace StoryArc
{
    partial class CharacterEditor
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
            this.comboBoxCharacter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCharacter = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.variablesEditor = new StoryArc.VariablesEditor();
            this.groupBoxCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character: ";
            // 
            // comboBoxCharacter
            // 
            this.comboBoxCharacter.FormattingEnabled = true;
            this.comboBoxCharacter.Location = new System.Drawing.Point(87, 6);
            this.comboBoxCharacter.Name = "comboBoxCharacter";
            this.comboBoxCharacter.Size = new System.Drawing.Size(189, 24);
            this.comboBoxCharacter.TabIndex = 1;
            this.comboBoxCharacter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            // 
            // groupBoxCharacter
            // 
            this.groupBoxCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCharacter.Controls.Add(this.label6);
            this.groupBoxCharacter.Controls.Add(this.textBoxLastName);
            this.groupBoxCharacter.Controls.Add(this.label5);
            this.groupBoxCharacter.Controls.Add(this.textBoxMiddleName);
            this.groupBoxCharacter.Controls.Add(this.label4);
            this.groupBoxCharacter.Controls.Add(this.variablesEditor);
            this.groupBoxCharacter.Controls.Add(this.label3);
            this.groupBoxCharacter.Controls.Add(this.textBoxFirstName);
            this.groupBoxCharacter.Controls.Add(this.label2);
            this.groupBoxCharacter.Location = new System.Drawing.Point(0, 38);
            this.groupBoxCharacter.Name = "groupBoxCharacter";
            this.groupBoxCharacter.Size = new System.Drawing.Size(699, 456);
            this.groupBoxCharacter.TabIndex = 3;
            this.groupBoxCharacter.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(407, 46);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(165, 22);
            this.textBoxLastName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Middle";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(236, 46);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(165, 22);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "First";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Variables:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(65, 46);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(165, 22);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(291, 4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(102, 27);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Create New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(399, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 26);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // variablesEditor
            // 
            this.variablesEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.variablesEditor.Location = new System.Drawing.Point(9, 93);
            this.variablesEditor.Name = "variablesEditor";
            this.variablesEditor.Size = new System.Drawing.Size(684, 357);
            this.variablesEditor.TabIndex = 5;
            this.variablesEditor.TabStop = false;
            // 
            // CharacterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.groupBoxCharacter);
            this.Controls.Add(this.comboBoxCharacter);
            this.Controls.Add(this.label1);
            this.Name = "CharacterEditor";
            this.Size = new System.Drawing.Size(702, 497);
            this.Leave += new System.EventHandler(this.CharacterEditor_Leave);
            this.groupBoxCharacter.ResumeLayout(false);
            this.groupBoxCharacter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCharacter;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private VariablesEditor variablesEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label label4;
    }
}
