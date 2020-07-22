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
        private List<TextBox> FirstPageTextBoxs = new List<TextBox>();
        private List<NumericUpDown> FirstPageNumericUpDown = new List<NumericUpDown>();
        private List<TextBox> SecondPageTextBoxs = new List<TextBox>();

        public MainWindow()
        {
            InitializeComponent();
            FirstPageTextBoxs.AddRange(new List<TextBox>()
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
            FirstPageNumericUpDown.AddRange(new List<NumericUpDown>()
            {

            });
            SecondPageTextBoxs.AddRange(new List<TextBox>()
            {

            });
        }

        private async Task SwitchPage()
        {
            if (FirstPictureBox.Visible)
            {
                FirstPictureBox.Visible = false;
                foreach (var element in FirstPageTextBoxs)
                {
                    element.Enabled = false;
                    element.Visible = false;
                    await Task.Delay(0);
                }

            }
            else
            {
                FirstPictureBox.Visible = true;
                foreach (var element in FirstPageTextBoxs)
                {
                    element.Enabled = true;
                    element.Visible = true;
                    await Task.Delay(0);
                }
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            SwitchPage();
        }
    }
}
