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
        public List<TextBox> FirstPageTextBoxs = new List<TextBox>();
        public List<NumericUpDown> FirstPageNumericUpDown = new List<NumericUpDown>();
        public List<TextBox> SecondPageTextBoxs = new List<TextBox>();

        public MainWindow()
        {
            InitializeComponent();
            _ = FillElementsLists();
        }

        private async Task FillElementsLists()
        {
            FirstPageTextBoxs.AddRange(new List<TextBox>()
            {
                //
                //  Character
                //
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
                CharacterSiblings,
                CharacterCurrentXP,
                CharacterTotalXP,
                CharacterMovementRetreat,
                CharacterCharge,
                CharacterSprint,
                CharacterHead,
                CharacterRightArm,
                CharacterRightLeg,
                CharacterLeftArm,
                CharacterLeftLeg,
                //
                //  Campaign
                //
                PlayerName,
                CampaignName,
                GameMaster,
                CampaignYear,
                //
                //  Weapons
                //
                WeaponName1,
                WeaponName2,
                WeaponName3,
                WeaponName4,
                WeaponName5,
                WeaponName6,
                WeaponWeight1,
                WeaponWeight2,
                WeaponWeight3,
                WeaponWeight4,
                WeaponWeight5,
                WeaponWeight6,
                WeaponCategory1,
                WeaponCategory2,
                WeaponCategory3,
                WeaponCategory4,
                WeaponCategory5,
                WeaponCategory6,
                WeaponStrength1,
                WeaponStrength2,
                WeaponStrength3,
                WeaponStrength4,
                WeaponStrength5,
                WeaponStrength6,
                WeaponRange1,
                WeaponRange2,
                WeaponRange3,
                WeaponRange4,
                WeaponRange5,
                WeaponRange6,
                WeaponReload1,
                WeaponReload2,
                WeaponReload3,
                WeaponReload4,
                WeaponReload5,
                WeaponReload6,
                WeaponTraits1,
                WeaponTraits2,
                WeaponTraits3,
                WeaponTraits4,
                WeaponTraits5,
                WeaponTraits6,
                //
                //  Armour
                //
                SimpleArmourType,
                SimpleArmorPZ,
                AdvancedArmorType1,
                AdvancedArmorType2,
                AdvancedArmorType3,
                AdvancedArmorType4,
                AdvancedArmorType5,
                AdvancedArmorType6,
                AdvancedArmorWeight1,
                AdvancedArmorWeight2,
                AdvancedArmorWeight3,
                AdvancedArmorWeight4,
                AdvancedArmorWeight5,
                AdvancedArmorWeight6,
                AdvancedArmorLocation1,
                AdvancedArmorLocation2,
                AdvancedArmorLocation3,
                AdvancedArmorLocation4,
                AdvancedArmorLocation5,
                AdvancedArmorLocation6,
                AdvancedArmorPZ1,
                AdvancedArmorPZ2,
                AdvancedArmorPZ3,
                AdvancedArmorPZ4,
                AdvancedArmorPZ5,
                AdvancedArmorPZ6
            });
            await Task.Delay(0);
            FirstPageNumericUpDown.AddRange(new List<NumericUpDown>()
            {
                //Main
                CharacterStartingWW,
                CharacterStartingUS,
                CharacterStartingK,
                CharacterStartingOdp,
                CharacterStartingZr,
                CharacterStartingInt,
                CharacterStartingSW,
                CharacterStartingOgd,
                CharacterGrowthWW,
                CharacterGrowthUS,
                CharacterGrowthK,
                CharacterGrowthOdp,
                CharacterGrowthZr,
                CharacterGrowthInt,
                CharacterGrowthSW,
                CharacterGrowthOgd,
                CharacterActualWW,
                CharacterActualUS,
                CharacterActualK,
                CharacterActualOdp,
                CharacterActualZr,
                CharacterActualInt,
                CharacterActualSW,
                CharacterActualOgd,
                //Secondary
                CharacterStartingA,
                CharacterStartingZyw,
                CharacterStartingS,
                CharacterStartingWt,
                CharacterStartingSz,
                CharacterStartingMag,
                CharacterStartingPO,
                CharacterStartingPP,
                CharacterGrowthA,
                CharacterGrowthZyw,
                CharacterGrowthS,
                CharacterGrowthWt,
                CharacterGrowthSz,
                CharacterGrowthMag,
                CharacterGrowthPO,
                CharacterGrowthPP,
                CharacterActualA,
                CharacterActualZyw,
                CharacterActualS,
                CharacterActualWt,
                CharacterActualSz,
                CharacterActualMag,
                CharacterActualPO,
                CharacterActualPP
            });
            await Task.Delay(0);
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
                foreach (var element in FirstPageNumericUpDown)
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
                foreach (var element in FirstPageNumericUpDown)
                {
                    element.Enabled = true;
                    element.Visible = true;
                    await Task.Delay(0);
                }
            }
        }

        private void NextPage_Click(object sender, EventArgs e) => _ = SwitchPage();

        private void TurnPageMenuStripOption_Click(object sender, EventArgs e) => _ = SwitchPage();
    }
}
