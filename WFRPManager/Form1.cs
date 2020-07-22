using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRPManager
{
    public partial class MainWindow : Form
    {
        private List<TextBox> FirstPage = new List<TextBox>();

        public MainWindow()
        {
            InitializeComponent();
            FirstPage.AddRange(new List<TextBox>()
            {
                CharacterName,
                CharacterRace,
                CharacterCurrentRole,
                CharacterPreviousRole,
                CharacterAge,
                CharacterEyeColour,
                CharacterHairColor,
                CharacterStartSign,
                CharacterBirthplace,
                CharacterFeatures,
                CharacterSex,
                CharacterWeight,
                CharacterHeight,
                CharacterSiblings
            });
        }



        private void NextPage_Click(object sender, EventArgs e)
        {
            if (FirstPictureBox.Visible)
            {
                FirstPictureBox.Visible = false;
                foreach (var element in FirstPage)
                {
                    element.Enabled = false;
                    element.Visible = false;
                }
                    
            }
            else
            {
                FirstPictureBox.Visible = true;
                foreach (var element in FirstPage)
                {
                    element.Enabled = true;
                    element.Visible = true;
                }
            }
                
        }
    }
}
