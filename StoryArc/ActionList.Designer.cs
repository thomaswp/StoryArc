namespace StoryArc
{
    partial class ActionList
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.actionHolder2 = new StoryArc.ActionHolder();
            this.actionHolder1 = new StoryArc.ActionHolder();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.actionHolder2);
            this.panel1.Controls.Add(this.actionHolder1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 511);
            this.panel1.TabIndex = 5;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.panel1_DragOver);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // actionHolder2
            // 
            this.actionHolder2.Action = null;
            this.actionHolder2.AllowDrop = true;
            this.actionHolder2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionHolder2.AutoSize = true;
            this.actionHolder2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.actionHolder2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionHolder2.Location = new System.Drawing.Point(6, 89);
            this.actionHolder2.Margin = new System.Windows.Forms.Padding(6);
            this.actionHolder2.Name = "actionHolder2";
            this.actionHolder2.Padding = new System.Windows.Forms.Padding(6);
            this.actionHolder2.Size = new System.Drawing.Size(783, 71);
            this.actionHolder2.TabIndex = 1;
            // 
            // actionHolder1
            // 
            this.actionHolder1.Action = null;
            this.actionHolder1.AllowDrop = true;
            this.actionHolder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionHolder1.AutoSize = true;
            this.actionHolder1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.actionHolder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionHolder1.Location = new System.Drawing.Point(6, 6);
            this.actionHolder1.Margin = new System.Windows.Forms.Padding(6);
            this.actionHolder1.Name = "actionHolder1";
            this.actionHolder1.Padding = new System.Windows.Forms.Padding(6);
            this.actionHolder1.Size = new System.Drawing.Size(783, 71);
            this.actionHolder1.TabIndex = 0;
            // 
            // ActionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ActionList";
            this.Size = new System.Drawing.Size(797, 511);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private ActionHolder actionHolder2;
        private ActionHolder actionHolder1;
    }
}
