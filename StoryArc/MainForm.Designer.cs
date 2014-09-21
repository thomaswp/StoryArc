namespace StoryArc
{
    partial class MainForm
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFindReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDialog = new System.Windows.Forms.TabPage();
            this.tabPageCharacters = new System.Windows.Forms.TabPage();
            this.tabPageVariables = new System.Windows.Forms.TabPage();
            this.dialogEditor = new StoryArc.DialogEditor();
            this.characterEditor = new StoryArc.CharacterEditor();
            this.variablesEditor = new StoryArc.VariablesEditor();
            this.menuStrip.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageDialog.SuspendLayout();
            this.tabPageCharacters.SuspendLayout();
            this.tabPageVariables.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1148, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(228, 24);
            this.tsmiNew.Text = "New...";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(228, 24);
            this.tsmiOpen.Text = "Open...";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(228, 24);
            this.tsmiSave.Text = "Save";
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(228, 24);
            this.tsmiSaveAs.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(228, 24);
            this.tsmiExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiRedo,
            this.toolStripSeparator2,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.toolStripSeparator3,
            this.tsmiFindReplace});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(214, 24);
            this.tsmiUndo.Text = "Undo";
            // 
            // tsmiRedo
            // 
            this.tsmiRedo.Name = "tsmiRedo";
            this.tsmiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiRedo.Size = new System.Drawing.Size(214, 24);
            this.tsmiRedo.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(214, 24);
            this.tsmiCut.Text = "Cut";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(214, 24);
            this.tsmiCopy.Text = "Copy";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(214, 24);
            this.tsmiPaste.Text = "Paste";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(211, 6);
            // 
            // tsmiFindReplace
            // 
            this.tsmiFindReplace.Name = "tsmiFindReplace";
            this.tsmiFindReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiFindReplace.Size = new System.Drawing.Size(214, 24);
            this.tsmiFindReplace.Text = "Find/Replace";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageDialog);
            this.tabControlMain.Controls.Add(this.tabPageCharacters);
            this.tabControlMain.Controls.Add(this.tabPageVariables);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 28);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1148, 694);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageDialog
            // 
            this.tabPageDialog.BackColor = System.Drawing.Color.White;
            this.tabPageDialog.Controls.Add(this.dialogEditor);
            this.tabPageDialog.Location = new System.Drawing.Point(4, 25);
            this.tabPageDialog.Name = "tabPageDialog";
            this.tabPageDialog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDialog.Size = new System.Drawing.Size(1140, 665);
            this.tabPageDialog.TabIndex = 0;
            this.tabPageDialog.Text = "Dialog";
            // 
            // tabPageCharacters
            // 
            this.tabPageCharacters.Controls.Add(this.characterEditor);
            this.tabPageCharacters.Location = new System.Drawing.Point(4, 25);
            this.tabPageCharacters.Name = "tabPageCharacters";
            this.tabPageCharacters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharacters.Size = new System.Drawing.Size(1140, 665);
            this.tabPageCharacters.TabIndex = 1;
            this.tabPageCharacters.Text = "Characters";
            this.tabPageCharacters.UseVisualStyleBackColor = true;
            // 
            // tabPageVariables
            // 
            this.tabPageVariables.Controls.Add(this.variablesEditor);
            this.tabPageVariables.Location = new System.Drawing.Point(4, 25);
            this.tabPageVariables.Name = "tabPageVariables";
            this.tabPageVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariables.Size = new System.Drawing.Size(1140, 665);
            this.tabPageVariables.TabIndex = 2;
            this.tabPageVariables.Text = "Variables";
            this.tabPageVariables.UseVisualStyleBackColor = true;
            // 
            // dialogEditor
            // 
            this.dialogEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogEditor.Location = new System.Drawing.Point(3, 3);
            this.dialogEditor.Name = "dialogEditor";
            this.dialogEditor.Size = new System.Drawing.Size(1134, 659);
            this.dialogEditor.StoryGame = null;
            this.dialogEditor.TabIndex = 0;
            // 
            // characterEditor
            // 
            this.characterEditor.Characters = null;
            this.characterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterEditor.Location = new System.Drawing.Point(3, 3);
            this.characterEditor.Name = "characterEditor";
            this.characterEditor.Size = new System.Drawing.Size(1134, 659);
            this.characterEditor.TabIndex = 0;
            // 
            // variablesEditor
            // 
            this.variablesEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variablesEditor.Location = new System.Drawing.Point(3, 3);
            this.variablesEditor.Name = "variablesEditor";
            this.variablesEditor.Size = new System.Drawing.Size(1134, 659);
            this.variablesEditor.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 722);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "StoryArc";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDialog.ResumeLayout(false);
            this.tabPageCharacters.ResumeLayout(false);
            this.tabPageVariables.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindReplace;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDialog;
        private System.Windows.Forms.TabPage tabPageCharacters;
        private System.Windows.Forms.TabPage tabPageVariables;
        private DialogEditor dialogEditor;
        private CharacterEditor characterEditor;
        private VariablesEditor variablesEditor;
    }
}

