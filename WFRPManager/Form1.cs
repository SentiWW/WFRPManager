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
        public List<NumericUpDownNoScroll> FirstPageNumericUpDown = new List<NumericUpDownNoScroll>();
        public List<TextBox> SecondPageTextBoxs = new List<TextBox>();
        public List<CheckBox> SecondPageCheckBoxs = new List<CheckBox>();
        public List<NumericUpDownNoScroll> SecondPageNumericUpDown = new List<NumericUpDownNoScroll>();

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
                CharacterBody,
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
            FirstPageNumericUpDown.AddRange(new List<NumericUpDownNoScroll>()
            {
                //
                //  Main
                //
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
                //
                //  Secondary
                //
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
                //
                //  Character skills
                //
                CharacterConnectedSkill1,
                CharacterConnectedSkill2,
                CharacterConnectedSkill3,
                CharacterConnectedSkill4,
                CharacterConnectedSkill5,
                CharacterConnectedSkill6,
                CharacterConnectedSkill7,
                CharacterConnectedSkill8,
                CharacterConnectedSkill9,
                CharacterConnectedSkill10,
                CharacterConnectedSkill11,
                CharacterConnectedSkill12,
                CharacterConnectedSkill13,
                CharacterConnectedSkill14,
                CharacterConnectedSkill15,
                CharacterConnectedSkill16,
                CharacterConnectedSkill17,
                CharacterConnectedSkill18,
                CharacterConnectedSkill19,
                CharacterConnectedSkill20,
                //
                //  Character advanced skills
                //
                CharacterAdvancedSkill1,
                CharacterAdvancedSkill2,
                CharacterAdvancedSkill3,
                CharacterAdvancedSkill4,
                CharacterAdvancedSkill5,
                CharacterAdvancedSkill6,
                CharacterAdvancedSkill7,
                CharacterAdvancedSkill8,
                CharacterAdvancedSkill9,
                CharacterAdvancedSkill10,
                CharacterAdvancedSkill11,
                CharacterAdvancedSkill12,
                CharacterAdvancedSkill13,
                CharacterAdvancedSkill14,
                CharacterAdvancedSkill15,
                CharacterConnectedAdvancedSkill1,
                CharacterConnectedAdvancedSkill2,
                CharacterConnectedAdvancedSkill3,
                CharacterConnectedAdvancedSkill4,
                CharacterConnectedAdvancedSkill5,
                CharacterConnectedAdvancedSkill6,
                CharacterConnectedAdvancedSkill7,
                CharacterConnectedAdvancedSkill8,
                CharacterConnectedAdvancedSkill9,
                CharacterConnectedAdvancedSkill10,
                CharacterConnectedAdvancedSkill11,
                CharacterConnectedAdvancedSkill12,
                CharacterConnectedAdvancedSkill13,
                CharacterConnectedAdvancedSkill14,
                CharacterConnectedAdvancedSkill15,
                //
                //  Character abilities
                //
                CharacterAbility1,
                CharacterAbility2,
                CharacterAbility3,
                CharacterAbility4,
                CharacterAbility5,
                CharacterAbility6,
                CharacterAbility7,
                CharacterAbility8,
                CharacterAbility9,
                CharacterAbility10,
                CharacterAbility11,
                CharacterAbility12,
                CharacterAbility13,
                CharacterAbility14,
                CharacterAbility15,
                CharacterAbilityDescription1,
                CharacterAbilityDescription2,
                CharacterAbilityDescription3,
                CharacterAbilityDescription4,
                CharacterAbilityDescription5,
                CharacterAbilityDescription6,
                CharacterAbilityDescription7,
                CharacterAbilityDescription8,
                CharacterAbilityDescription9,
                CharacterAbilityDescription10,
                CharacterAbilityDescription11,
                CharacterAbilityDescription12,
                CharacterAbilityDescription13,
                CharacterAbilityDescription14,
                CharacterAbilityDescription15,
                //
                //  Character items
                //
                CharacterItem1,
                CharacterItem2,
                CharacterItem3,
                CharacterItem4,
                CharacterItem5,
                CharacterItem6,
                CharacterItem7,
                CharacterItem8,
                CharacterItem9,
                CharacterItem10,
                CharacterItem11,
                CharacterItem12,
                CharacterItem13,
                CharacterItem14,
                CharacterItemWeight1,
                CharacterItemWeight2,
                CharacterItemWeight3,
                CharacterItemWeight4,
                CharacterItemWeight5,
                CharacterItemWeight6,
                CharacterItemWeight7,
                CharacterItemWeight8,
                CharacterItemWeight9,
                CharacterItemWeight10,
                CharacterItemWeight11,
                CharacterItemWeight12,
                CharacterItemWeight13,
                CharacterItemWeight14,
                CharacterItemDescription1,
                CharacterItemDescription2,
                CharacterItemDescription3,
                CharacterItemDescription4,
                CharacterItemDescription5,
                CharacterItemDescription6,
                CharacterItemDescription7,
                CharacterItemDescription8,
                CharacterItemDescription9,
                CharacterItemDescription10,
                CharacterItemDescription11,
                CharacterItemDescription12,
                CharacterItemDescription13,
                CharacterItemDescription14
            });
            await Task.Delay(0);
            SecondPageCheckBoxs.AddRange(new List<CheckBox>()
            {
                //
                //  Character skills
                //
                CharacterSkill1_1,
                CharacterSkill2_1,
                CharacterSkill3_1,
                CharacterSkill4_1,
                CharacterSkill5_1,
                CharacterSkill6_1,
                CharacterSkill7_1,
                CharacterSkill8_1,
                CharacterSkill9_1,
                CharacterSkill10_1,
                CharacterSkill11_1,
                CharacterSkill12_1,
                CharacterSkill13_1,
                CharacterSkill14_1,
                CharacterSkill15_1,
                CharacterSkill16_1,
                CharacterSkill17_1,
                CharacterSkill18_1,
                CharacterSkill19_1,
                CharacterSkill20_1,
                CharacterSkill1_2,
                CharacterSkill2_2,
                CharacterSkill3_2,
                CharacterSkill4_2,
                CharacterSkill5_2,
                CharacterSkill6_2,
                CharacterSkill7_2,
                CharacterSkill8_2,
                CharacterSkill9_2,
                CharacterSkill10_2,
                CharacterSkill11_2,
                CharacterSkill12_2,
                CharacterSkill13_2,
                CharacterSkill14_2,
                CharacterSkill15_2,
                CharacterSkill16_2,
                CharacterSkill17_2,
                CharacterSkill18_2,
                CharacterSkill19_2,
                CharacterSkill20_2,
                CharacterSkill1_3,
                CharacterSkill2_3,
                CharacterSkill3_3,
                CharacterSkill4_3,
                CharacterSkill5_3,
                CharacterSkill6_3,
                CharacterSkill7_3,
                CharacterSkill8_3,
                CharacterSkill9_3,
                CharacterSkill10_3,
                CharacterSkill11_3,
                CharacterSkill12_3,
                CharacterSkill13_3,
                CharacterSkill14_3,
                CharacterSkill15_3,
                CharacterSkill16_3,
                CharacterSkill17_3,
                CharacterSkill18_3,
                CharacterSkill19_3,
                CharacterSkill20_3,
                //
                //  Character advanced skills
                //
                CharacterAdvancedSkill1_1,
                CharacterAdvancedSkill2_1,
                CharacterAdvancedSkill3_1,
                CharacterAdvancedSkill4_1,
                CharacterAdvancedSkill5_1,
                CharacterAdvancedSkill6_1,
                CharacterAdvancedSkill7_1,
                CharacterAdvancedSkill8_1,
                CharacterAdvancedSkill9_1,
                CharacterAdvancedSkill10_1,
                CharacterAdvancedSkill11_1,
                CharacterAdvancedSkill12_1,
                CharacterAdvancedSkill13_1,
                CharacterAdvancedSkill14_1,
                CharacterAdvancedSkill15_1,
                CharacterAdvancedSkill1_2,
                CharacterAdvancedSkill2_2,
                CharacterAdvancedSkill3_2,
                CharacterAdvancedSkill4_2,
                CharacterAdvancedSkill5_2,
                CharacterAdvancedSkill6_2,
                CharacterAdvancedSkill7_2,
                CharacterAdvancedSkill8_2,
                CharacterAdvancedSkill9_2,
                CharacterAdvancedSkill10_2,
                CharacterAdvancedSkill11_2,
                CharacterAdvancedSkill12_2,
                CharacterAdvancedSkill13_2,
                CharacterAdvancedSkill14_2,
                CharacterAdvancedSkill15_2,
                CharacterAdvancedSkill1_3,
                CharacterAdvancedSkill2_3,
                CharacterAdvancedSkill3_3,
                CharacterAdvancedSkill4_3,
                CharacterAdvancedSkill5_3,
                CharacterAdvancedSkill6_3,
                CharacterAdvancedSkill7_3,
                CharacterAdvancedSkill8_3,
                CharacterAdvancedSkill9_3,
                CharacterAdvancedSkill10_3,
                CharacterAdvancedSkill11_3,
                CharacterAdvancedSkill12_3,
                CharacterAdvancedSkill13_3,
                CharacterAdvancedSkill14_3,
                CharacterAdvancedSkill15_3
            });
            await Task.Delay(0);
            SecondPageNumericUpDown.AddRange(new List<NumericUpDownNoScroll>()
            {
                //
                //  Character money
                //
                CharacterMoneyZK,
                CharacterMoneyS,
                CharacterMoneyP
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