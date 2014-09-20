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
    public partial class CharacterEditor : UserControl
    {
        private List<Character> _characters;
        public List<Character> Characters 
        {
            get
            {
                return _characters;
            }
            set
            {
                _characters = value;
                updateCharacters();
            }
        }

        private Character selectedCharacter;
        private Bindings bindings = new Bindings();

        public CharacterEditor()
        {
            InitializeComponent();
            bindings.AddBindings(new TextBoxBinding(this.textBoxFirstName, typeof(Character).GetProperty("FirstName")),
                    new TextBoxBinding(this.textBoxMiddleName, typeof(Character).GetProperty("MiddleName")),
                    new TextBoxBinding(this.textBoxLastName, typeof(Character).GetProperty("LastName")));

            bindings.OnControlEdited += new EventHandler(bindings_OnControlEdited);
        }

        private void updateCharacterName()
        {
            Character character = selectedCharacter;
            if (character == null) character = new Character();

            this.groupBoxCharacter.Text = character.Name;
            if (this.comboBoxCharacter.SelectedIndex >= 0)
            {
                if ((string) this.comboBoxCharacter.Items[this.comboBoxCharacter.SelectedIndex] != character.Name)
                {
                    this.comboBoxCharacter.Items[this.comboBoxCharacter.SelectedIndex] = character.Name;
                }
            }
        }

        private void updateCharacters()
        {
            int index = this.comboBoxCharacter.SelectedIndex;
            this.comboBoxCharacter.Items.Clear();
            this.comboBoxCharacter.Items.AddRange(Characters.Select(x => x.Name).ToArray());
            this.comboBoxCharacter.SelectedIndex = Math.Min(Math.Max(0, index), Characters.Count - 1);
            if (Characters.Count == 0) selectCharacter();
        }

        private void selectCharacter()
        {
            int index = comboBoxCharacter.SelectedIndex;
            if (index < 0 || index > Characters.Count) selectedCharacter = null;
            else selectedCharacter = Characters[index];
            bindings.Target = selectedCharacter;
            if (selectedCharacter == null) this.comboBoxCharacter.Text = "";
            updateCharacterName();
        }

        private void CharacterEditor_Leave(object sender, EventArgs e)
        {
        }

        private void bindings_OnControlEdited(object sender, EventArgs e)
        {
            updateCharacterName();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Characters.Add(new Character());
            updateCharacters();
            this.comboBoxCharacter.SelectedIndex = Characters.Count - 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Characters.Remove(selectedCharacter);
            updateCharacters();
        }

        private void comboBoxCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectCharacter();
        }
    }
}
