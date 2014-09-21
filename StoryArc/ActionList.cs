using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoryArc
{
    public partial class ActionList : UserControl
    {
        private List<ActionHolder> holders = new List<ActionHolder>();
        private ActionHolder draggingHolder;

        private Dialog _dialog;
        public Dialog Dialog
        {
            get { return _dialog; }
            set
            {
                _dialog = value;
                holders.Clear();
            }
        }

        public ActionList()
        {
            InitializeComponent();
            holders.Add(this.actionHolder1);
            holders.Add(this.actionHolder2);
        }

        private void addActionHolder()
        {
            ActionHolder holder = new ActionHolder();
            this.panel1.Controls.Add(holder);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ActionHolder)))
            {
                e.Effect = DragDropEffects.Move | DragDropEffects.Copy | DragDropEffects.Scroll;
                draggingHolder = (ActionHolder)e.Data.GetData(typeof(ActionHolder));
                
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (draggingHolder != null && !draggingHolder.Dragging) draggingHolder = null;
            if (draggingHolder != null)
            {
                holders.Remove(draggingHolder);
                for (int i = 0; i < holders.Count + 1; i++)
                {
                    if (i == holders.Count || holders[i].Location.Y > draggingHolder.Location.Y)
                    {
                        holders.Insert(i, draggingHolder);
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            int padding = 6;
            int y = padding;
            foreach (ActionHolder holder in holders)
            {
                if (holder != draggingHolder)
                {
                    holder.Location = new Point(holder.Location.X, y);
                }
                y += holder.Size.Height + padding;
            }
        }
    }
}
