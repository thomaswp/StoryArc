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
    public partial class DialogEditor : UserControl
    {
        private StoryGame _storyGame;
        public StoryGame StoryGame 
        {
            get
            {
                return _storyGame;
            }
            set
            {
                _storyGame = value;
                if (value != null) updateDialogs();
            }
        }

        private List<Dialog> Dialogs
        {
            get { return StoryGame.Dialogs; }
        }

        private Dialog selectedDialog;
        private Bindings bindings = new Bindings();

        public DialogEditor()
        {
            InitializeComponent();
            bindings.AddBindings(new TextBoxBinding(this.textBoxName, new PropertyAccessor(typeof(Dialog).GetProperty("Name"))));

            bindings.OnControlEdited += new EventHandler(bindings_OnControlEdited);
        }

        private void updateDialogName()
        {
            string name = selectedDialog == null ? "" : selectedDialog.Name;

            this.groupBoxDialog.Text = name;
            if (this.comboBoxDialog.SelectedIndex >= 0)
            {
                if ((string) this.comboBoxDialog.Items[this.comboBoxDialog.SelectedIndex] != name)
                {
                    this.comboBoxDialog.Items[this.comboBoxDialog.SelectedIndex] = name;
                }
            }
        }

        private void updateDialogs()
        {
            int index = this.comboBoxDialog.SelectedIndex;
            this.comboBoxDialog.Items.Clear();
            this.comboBoxDialog.Items.AddRange(Dialogs.Select(x => x.Name).ToArray());
            this.comboBoxDialog.SelectedIndex = Math.Min(Math.Max(0, index), Dialogs.Count - 1);
            if (Dialogs.Count == 0) selectDialog();
        }

        private void selectDialog()
        {
            int index = comboBoxDialog.SelectedIndex;
            if (index < 0 || index > Dialogs.Count) selectedDialog = null;
            else selectedDialog = Dialogs[index];
            bindings.Target = selectedDialog;
            if (selectedDialog == null) this.comboBoxDialog.Text = "";
            updateDialogName();
        }

        private void DialogEditor_Leave(object sender, EventArgs e)
        {
        }

        private void bindings_OnControlEdited(object sender, EventArgs e)
        {
            updateDialogName();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            StoryGame.AddDialog();
            updateDialogs();
            this.comboBoxDialog.SelectedIndex = Dialogs.Count - 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Dialogs.Remove(selectedDialog);
            updateDialogs();
        }

        private void comboBoxDialog_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDialog();
        }
    }
}
