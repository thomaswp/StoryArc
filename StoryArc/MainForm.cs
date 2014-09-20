using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoryArc
{
    public partial class MainForm : Form
    {
        StoryGame game = new StoryGame();

        public MainForm()
        {
            InitializeComponent();
            this.characterEditor.Characters = game.Characters;
        }
    }
}
