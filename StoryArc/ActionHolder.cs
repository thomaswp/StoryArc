using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoryArc.Actions;

namespace StoryArc
{
    public partial class ActionHolder : UserControl
    {
        private int dragStartY, dragStartMouseY;
        private bool dragging;

        public bool Dragging { get { return dragging; } }

        private DialogAction _action;
        public DialogAction Action
        {
            get { return _action; }
            set
            {
                _action = value;
                if (value != null) this.label1.Text = value.ToString();
            }
        }

        public ActionHolder()
        {
            InitializeComponent();
        }

        private void ActionHolder_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine(this.Location);
            dragStartY = this.Location.Y;
            dragStartMouseY = Cursor.Position.Y;
            dragging = true;
            DoDragDrop(this, DragDropEffects.Move | DragDropEffects.Scroll | DragDropEffects.All);
            dragging = false;
        }

        private void ActionHolder_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void ActionHolder_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void ActionHolder_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Location.X, dragStartY + Cursor.Position.Y - dragStartMouseY);
                Refresh();
            }
        }

        private void ActionHolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ActionHolder)))
            {
                e.Effect = DragDropEffects.Move | DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }
    }
}
