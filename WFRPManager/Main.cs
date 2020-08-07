using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFRPManager.Logic;
using WFRPManager.Data;
using System.IO;

namespace WFRPManager.UI
{
    public partial class MainWindow : Form
    {
        private List<TextBox> FirstPageTextBoxsTemp = new List<TextBox>();
        private List<NumericUpDownNoScroll> FirstPageNumericUpDownTemp = new List<NumericUpDownNoScroll>();
        private List<TextBox> SecondPageTextBoxsTemp = new List<TextBox>();
        private List<CheckBox> SecondPageCheckBoxsTemp = new List<CheckBox>();
        private List<NumericUpDownNoScroll> SecondPageNumericUpDownTemp = new List<NumericUpDownNoScroll>();

        private LinkedList<TextBox> FirstPageTextBoxs = new LinkedList<TextBox>();
        private LinkedList<NumericUpDownNoScroll> FirstPageNumericUpDown = new LinkedList<NumericUpDownNoScroll>();
        private LinkedList<TextBox> SecondPageTextBoxs = new LinkedList<TextBox>();
        private LinkedList<CheckBox> SecondPageCheckBoxs = new LinkedList<CheckBox>();
        private LinkedList<NumericUpDownNoScroll> SecondPageNumericUpDown = new LinkedList<NumericUpDownNoScroll>();

        private Player CurrentPlayer = new Player();
        private Character CurrentCharacter = new Character();

        public MainWindow()
        {
            InitializeComponent();
            InitializeComponentOverride();
            _ = FillElementsToLinkedListAsync();
            _ = EnableSecondPageAsync(false);
            _ = EnableFirstPageAsync(true);
        }

        private void InitializeComponentOverride()
        {
            
        }
        private async Task FillElementsToLinkedListAsync()
        {
            _ = FillElementsListsAsync();
            foreach (var element in FirstPageTextBoxsTemp)
                FirstPageTextBoxs.AddLast(element);
            FirstPageTextBoxsTemp.Clear();

            foreach (var element in FirstPageNumericUpDownTemp)
                FirstPageNumericUpDown.AddLast(element);
            FirstPageNumericUpDownTemp.Clear();

            foreach (var element in SecondPageTextBoxsTemp)
                SecondPageTextBoxs.AddLast(element);
            SecondPageTextBoxsTemp.Clear();

            foreach (var element in SecondPageCheckBoxsTemp)
                SecondPageCheckBoxs.AddLast(element);
            SecondPageCheckBoxsTemp.Clear();

            foreach (var element in SecondPageNumericUpDownTemp)
                SecondPageNumericUpDown.AddLast(element);
            SecondPageNumericUpDownTemp.Clear();
        }

        private async Task FillElementsListsAsync()
        {
            FirstPageTextBoxsTemp.AddRange(new List<TextBox>()
            {
                //
                //  Character
                //
                CharacterName,
                CharacterRace,
                CharacterCurrentRole,
                CharacterPreviousRole,
                CharacterAge,
                CharacterEyeColor,
                CharacterHairColor,
                CharacterStarSign,
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
                SimpleArmorType,
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
            FirstPageNumericUpDownTemp.AddRange(new List<NumericUpDownNoScroll>()
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
            SecondPageTextBoxsTemp.AddRange(new List<TextBox>()
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
            SecondPageCheckBoxsTemp.AddRange(new List<CheckBox>()
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
            SecondPageNumericUpDownTemp.AddRange(new List<NumericUpDownNoScroll>()
            {
                //
                //  Character money
                //
                CharacterMoneyZK,
                CharacterMoneyS,
                CharacterMoneyP
            });
        }

        private async Task EnablePictureBoxAsync(bool enable, PictureBox picture)
        {
            if (enable)
            {
                picture.Enabled = true;
                picture.Visible = true;
            }
            else
            {
                picture.Enabled = false;
                picture.Visible = false;
            }
        }

        private async Task EnableFirstPageAsync(bool enable)
        {
            foreach (var element in FirstPageTextBoxs)
            {
                element.Visible = enable;
                element.Enabled = enable;
            }
            await Task.Delay(0);
            foreach (var element in FirstPageNumericUpDown)
            {
                element.Visible = enable;
                element.Enabled = enable;

            }
            await Task.Delay(0);
            if (enable)
                await EnablePictureBoxAsync(true, FirstPictureBox);
            else
                await EnablePictureBoxAsync(false, FirstPictureBox);
        }

        private async Task EnableSecondPageAsync(bool enable)
        {
            foreach (var element in SecondPageTextBoxs)
            {
                element.Visible = enable;
                element.Enabled = enable;
            }
            await Task.Delay(0);

            foreach (var element in SecondPageCheckBoxs)
            {
                element.Visible = enable;
                element.Enabled = enable;
            }
            await Task.Delay(0);

            foreach (var element in SecondPageNumericUpDown)
            {
                element.Visible = enable;
                element.Enabled = enable;
            }
            await Task.Delay(0);

            if (enable)
                await EnablePictureBoxAsync(true, SecondPictureBox);
            else
                await EnablePictureBoxAsync(false, SecondPictureBox);
        }

        private async Task SwitchPageAsync()
        {
            if (FirstPictureBox.Enabled)
            {
                await EnableFirstPageAsync(false);
                await EnableSecondPageAsync(true);
            }
            else
            {
                await EnableSecondPageAsync(false);
                await EnableFirstPageAsync(true);
            }
        }

        private async Task RefreshAsync()
        {
            await Task.Run(() =>
            {
                PlayerName.Text = CurrentPlayer.Name;
                GameMaster.Text = CurrentPlayer.GameMaster;
                CampaignName.Text = CurrentPlayer.Campaign;
                CampaignYear.Text = CurrentPlayer.CampaignYear;

                CharacterName.Text = CurrentCharacter.Name;
                CharacterRace.Text = CurrentCharacter.Race;
                CharacterCurrentRole.Text = CurrentCharacter.CurrentRole;
                CharacterPreviousRole.Text = CurrentCharacter.PreviousRole;
                CharacterAge.Text = CurrentCharacter.Age;
                CharacterEyeColor.Text = CurrentCharacter.EyeColor;
                CharacterHairColor.Text = CurrentCharacter.HairColor;
                CharacterStarSign.Text = CurrentCharacter.StarSign;
                CharacterBirthplace.Text = CurrentCharacter.Birthplace;
                CharacterFeatures.Text = CurrentCharacter.Features;
                CharacterSex.Text = CurrentCharacter.Sex;
                CharacterWeight.Text = CurrentCharacter.Weight;
                CharacterHeight.Text = CurrentCharacter.Height;
                CharacterSiblings.Text = CurrentCharacter.Siblings;
                CharacterHead.Text = CurrentCharacter.Head;
                CharacterBody.Text = CurrentCharacter.Body;
                CharacterLeftArm.Text = CurrentCharacter.LeftArm;
                CharacterRightArm.Text = CurrentCharacter.RightArm;
                CharacterLeftLeg.Text = CurrentCharacter.LeftLeg;
                CharacterRightLeg.Text = CurrentCharacter.RightLeg;
                CharacterCurrentXP.Text = CurrentCharacter.CurrentXP;
                CharacterTotalXP.Text = CurrentCharacter.TotalXP;
                CharacterMovementRetreat.Text = CurrentCharacter.MovementRetreat;
                CharacterCharge.Text = CurrentCharacter.Charge;
                CharacterSprint.Text = CurrentCharacter.Sprint;

                CharacterStartingWW.Value = CurrentCharacter.Traits[0].Starting;
                CharacterGrowthWW.Value = CurrentCharacter.Traits[0].Growth;
                CharacterActualWW.Value = CurrentCharacter.Traits[0].Actual;
                CharacterStartingUS.Value = CurrentCharacter.Traits[1].Starting;
                CharacterGrowthUS.Value = CurrentCharacter.Traits[1].Growth;
                CharacterActualUS.Value = CurrentCharacter.Traits[1].Actual;
                CharacterStartingK.Value = CurrentCharacter.Traits[2].Starting;
                CharacterGrowthK.Value = CurrentCharacter.Traits[2].Growth;
                CharacterActualK.Value = CurrentCharacter.Traits[2].Actual;
                CharacterStartingOdp.Value = CurrentCharacter.Traits[3].Starting;
                CharacterGrowthOdp.Value = CurrentCharacter.Traits[3].Growth;
                CharacterActualOdp.Value = CurrentCharacter.Traits[3].Actual;
                CharacterStartingZr.Value = CurrentCharacter.Traits[4].Starting;
                CharacterGrowthZr.Value = CurrentCharacter.Traits[4].Growth;
                CharacterActualZr.Value = CurrentCharacter.Traits[4].Actual;
                CharacterStartingInt.Value = CurrentCharacter.Traits[5].Starting;
                CharacterGrowthInt.Value = CurrentCharacter.Traits[5].Growth;
                CharacterActualInt.Value = CurrentCharacter.Traits[5].Actual;
                CharacterStartingSW.Value = CurrentCharacter.Traits[6].Starting;
                CharacterGrowthSW.Value = CurrentCharacter.Traits[6].Growth;
                CharacterActualSW.Value = CurrentCharacter.Traits[6].Actual;
                CharacterStartingOgd.Value = CurrentCharacter.Traits[7].Starting;
                CharacterGrowthOgd.Value = CurrentCharacter.Traits[7].Growth;
                CharacterActualOgd.Value = CurrentCharacter.Traits[7].Actual;
                CharacterStartingA.Value = CurrentCharacter.Traits[8].Starting;
                CharacterGrowthA.Value = CurrentCharacter.Traits[8].Growth;
                CharacterActualA.Value = CurrentCharacter.Traits[8].Actual;
                CharacterStartingZyw.Value = CurrentCharacter.Traits[9].Starting;
                CharacterGrowthZyw.Value = CurrentCharacter.Traits[9].Growth;
                CharacterActualZyw.Value = CurrentCharacter.Traits[9].Actual;
                CharacterStartingS.Value = CurrentCharacter.Traits[10].Starting;
                CharacterGrowthS.Value = CurrentCharacter.Traits[10].Growth;
                CharacterActualS.Value = CurrentCharacter.Traits[10].Actual;
                CharacterStartingWt.Value = CurrentCharacter.Traits[11].Starting;
                CharacterGrowthWt.Value = CurrentCharacter.Traits[11].Growth;
                CharacterActualWt.Value = CurrentCharacter.Traits[11].Actual;
                CharacterStartingSz.Value = CurrentCharacter.Traits[12].Starting;
                CharacterGrowthSz.Value = CurrentCharacter.Traits[12].Growth;
                CharacterActualSz.Value = CurrentCharacter.Traits[12].Actual;
                CharacterStartingMag.Value = CurrentCharacter.Traits[13].Starting;
                CharacterGrowthMag.Value = CurrentCharacter.Traits[13].Growth;
                CharacterActualMag.Value = CurrentCharacter.Traits[13].Actual;
                CharacterStartingPO.Value = CurrentCharacter.Traits[14].Starting;
                CharacterGrowthPO.Value = CurrentCharacter.Traits[14].Growth;
                CharacterActualPO.Value = CurrentCharacter.Traits[14].Actual;
                CharacterStartingPP.Value = CurrentCharacter.Traits[15].Starting;
                CharacterGrowthPP.Value = CurrentCharacter.Traits[15].Growth;
                CharacterActualPP.Value = CurrentCharacter.Traits[15].Actual;

                WeaponWeight1.Text = CurrentCharacter.Weapons[0].Weight;
                WeaponCategory1.Text = CurrentCharacter.Weapons[0].Category;
                WeaponStrength1.Text = CurrentCharacter.Weapons[0].Strength;
                WeaponRange1.Text = CurrentCharacter.Weapons[0].Range;
                WeaponReload1.Text = CurrentCharacter.Weapons[0].Reload;
                WeaponTraits1.Text = CurrentCharacter.Weapons[0].Traits;
                WeaponName2.Text = CurrentCharacter.Weapons[1].Name;
                WeaponWeight2.Text = CurrentCharacter.Weapons[1].Weight;
                WeaponCategory2.Text = CurrentCharacter.Weapons[1].Category;
                WeaponStrength2.Text = CurrentCharacter.Weapons[1].Strength;
                WeaponRange2.Text = CurrentCharacter.Weapons[1].Range;
                WeaponReload2.Text = CurrentCharacter.Weapons[1].Reload;
                WeaponTraits2.Text = CurrentCharacter.Weapons[1].Traits;
                WeaponName3.Text = CurrentCharacter.Weapons[2].Name;
                WeaponWeight3.Text = CurrentCharacter.Weapons[2].Weight;
                WeaponCategory3.Text = CurrentCharacter.Weapons[2].Category;
                WeaponStrength3.Text = CurrentCharacter.Weapons[2].Strength;
                WeaponRange3.Text = CurrentCharacter.Weapons[2].Range;
                WeaponReload3.Text = CurrentCharacter.Weapons[2].Reload;
                WeaponTraits3.Text = CurrentCharacter.Weapons[2].Traits;
                WeaponName4.Text = CurrentCharacter.Weapons[3].Name;
                WeaponWeight4.Text = CurrentCharacter.Weapons[3].Weight;
                WeaponCategory4.Text = CurrentCharacter.Weapons[3].Category;
                WeaponStrength4.Text = CurrentCharacter.Weapons[3].Strength;
                WeaponRange4.Text = CurrentCharacter.Weapons[3].Range;
                WeaponReload4.Text = CurrentCharacter.Weapons[3].Reload;
                WeaponTraits4.Text = CurrentCharacter.Weapons[3].Traits;
                WeaponName5.Text = CurrentCharacter.Weapons[4].Name;
                WeaponWeight5.Text = CurrentCharacter.Weapons[4].Weight;
                WeaponCategory5.Text = CurrentCharacter.Weapons[4].Category;
                WeaponStrength5.Text = CurrentCharacter.Weapons[4].Strength;
                WeaponRange5.Text = CurrentCharacter.Weapons[4].Range;
                WeaponReload5.Text = CurrentCharacter.Weapons[4].Reload;
                WeaponTraits5.Text = CurrentCharacter.Weapons[4].Traits;
                WeaponName6.Text = CurrentCharacter.Weapons[5].Name;
                WeaponWeight6.Text = CurrentCharacter.Weapons[5].Weight;
                WeaponCategory6.Text = CurrentCharacter.Weapons[5].Category;
                WeaponStrength6.Text = CurrentCharacter.Weapons[5].Strength;
                WeaponRange6.Text = CurrentCharacter.Weapons[5].Range;
                WeaponReload6.Text = CurrentCharacter.Weapons[5].Reload;
                WeaponTraits6.Text = CurrentCharacter.Weapons[5].Traits;

                SimpleArmorType.Text = CurrentCharacter.SArmor.Type;
                SimpleArmorPZ.Text = CurrentCharacter.SArmor.PZ;

                AdvancedArmorType1.Text = CurrentCharacter.Armors[0].Type;
                AdvancedArmorWeight1.Text = CurrentCharacter.Armors[0].Weight;
                AdvancedArmorLocation1.Text = CurrentCharacter.Armors[0].Location;
                AdvancedArmorPZ1.Text = CurrentCharacter.Armors[0].PZ;
                AdvancedArmorType2.Text = CurrentCharacter.Armors[1].Type;
                AdvancedArmorWeight2.Text = CurrentCharacter.Armors[1].Weight;
                AdvancedArmorLocation2.Text = CurrentCharacter.Armors[1].Location;
                AdvancedArmorPZ2.Text = CurrentCharacter.Armors[1].PZ;
                AdvancedArmorType3.Text = CurrentCharacter.Armors[2].Type;
                AdvancedArmorWeight3.Text = CurrentCharacter.Armors[2].Weight;
                AdvancedArmorLocation3.Text = CurrentCharacter.Armors[2].Location;
                AdvancedArmorPZ3.Text = CurrentCharacter.Armors[2].PZ;
                AdvancedArmorType4.Text = CurrentCharacter.Armors[3].Type;
                AdvancedArmorWeight4.Text = CurrentCharacter.Armors[3].Weight;
                AdvancedArmorLocation4.Text = CurrentCharacter.Armors[3].Location;
                AdvancedArmorPZ4.Text = CurrentCharacter.Armors[3].PZ;
                AdvancedArmorType5.Text = CurrentCharacter.Armors[4].Type;
                AdvancedArmorWeight5.Text = CurrentCharacter.Armors[4].Weight;
                AdvancedArmorLocation5.Text = CurrentCharacter.Armors[4].Location;
                AdvancedArmorPZ5.Text = CurrentCharacter.Armors[4].PZ;
                AdvancedArmorType6.Text = CurrentCharacter.Armors[5].Type;
                AdvancedArmorWeight6.Text = CurrentCharacter.Armors[5].Weight;
                AdvancedArmorPZ6.Text = CurrentCharacter.Armors[5].PZ;
                AdvancedArmorLocation6.Text = CurrentCharacter.Armors[5].Location;

                CharacterSkill1_1.Checked = CurrentCharacter.Skills[0].Skill1;
                CharacterSkill1_2.Checked = CurrentCharacter.Skills[0].Skill2;
                CharacterSkill1_3.Checked = CurrentCharacter.Skills[0].Skill3;
                CharacterConnectedSkill1.Text = CurrentCharacter.Skills[0].ConnectedSkill;
            });
        }

        private void NextPage_Click(object sender, EventArgs e) => _ = SwitchPageAsync();

        private void TurnPageMenuStripOption_Click(object sender, EventArgs e) => _ = SwitchPageAsync();

        private void PlaceholderToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if Debug
            MessageBox.Show("Dane testowe zapisane w pliku.");

            CurrentCharacter.Debug();
#endif
        }

        private void EksportujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.FileName = $"Karta-{DateTime.Now.Date.ToShortDateString().Replace('/', '-')}";
            SaveFileDialog.ShowDialog();
            Serialization.ExportToJSON(CurrentCharacter, Path.GetFullPath(SaveFileDialog.FileName));
        }

        private void ImportujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.FileName = $"Karta-{DateTime.Now.Date.ToShortDateString().Replace('/', '-')}";
            OpenFileDialog.ShowDialog();
            if (SaveFileDialog.CheckFileExists) CurrentCharacter = Serialization.ImportFromJSON(Path.GetFullPath(OpenFileDialog.FileName));
            _ = RefreshAsync();
        }

        //
        //  Update data localy on input
        //
        #region firstpage
        private void CharacterName_TextChanged(object sender, EventArgs e) => CurrentCharacter.Name = CharacterName.Text;

        private void CharacterRace_TextChanged(object sender, EventArgs e) => CurrentCharacter.Race = CharacterRace.Text;

        private void CharacterCurrentRole_TextChanged(object sender, EventArgs e) => CurrentCharacter.CurrentRole = CharacterCurrentRole.Text;

        private void CharacterPreviousRole_TextChanged(object sender, EventArgs e) => CurrentCharacter.PreviousRole = CharacterPreviousRole.Text;

        private void CharacterAge_TextChanged(object sender, EventArgs e) => CurrentCharacter.Age = CharacterAge.Text;

        private void CharacterEyeColour_TextChanged(object sender, EventArgs e) => CurrentCharacter.EyeColor = CharacterEyeColor.Text;

        private void CharacterHairColor_TextChanged(object sender, EventArgs e) => CurrentCharacter.HairColor = CharacterHairColor.Text;

        private void CharacterStartSign_TextChanged(object sender, EventArgs e) => CurrentCharacter.StarSign = CharacterStarSign.Text;

        private void CharacterBirthplace_TextChanged(object sender, EventArgs e) => CurrentCharacter.Birthplace = CharacterBirthplace.Text;

        private void CharacterFeatures_TextChanged(object sender, EventArgs e) => CurrentCharacter.Features = CharacterFeatures.Text;

        private void CharacterSex_TextChanged(object sender, EventArgs e) => CurrentCharacter.Sex = CharacterSex.Text;

        private void CharacterWeight_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weight = CharacterWeight.Text;

        private void CharacterHeight_TextChanged(object sender, EventArgs e) => CurrentCharacter.Height = CharacterHeight.Text;

        private void CharacterSiblings_TextChanged(object sender, EventArgs e) => CurrentCharacter.Siblings = CharacterSiblings.Text;

        private void CharacterStartingWW_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[0].Starting = (int)CharacterStartingWW.Value;

        private void CharacterGrowthWW_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[0].Growth = (int)CharacterGrowthWW.Value;

        private void CharacterActualWW_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[0].Actual = (int)CharacterActualWW.Value;

        private void CharacterStartingUS_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[1].Starting = (int)CharacterStartingUS.Value;

        private void CharacterGrowthUS_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[1].Growth = (int)CharacterGrowthUS.Value;

        private void CharacterActualUS_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[1].Actual = (int)CharacterActualUS.Value;

        private void CharacterStartingK_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[2].Starting = (int)CharacterStartingK.Value;

        private void CharacterGrowthK_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[2].Growth = (int)CharacterGrowthK.Value;

        private void CharacterActualK_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[2].Actual = (int)CharacterActualK.Value;

        private void CharacterStartingOdp_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[3].Starting = (int)CharacterStartingOdp.Value;

        private void CharacterGrowthOdp_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[3].Growth = (int)CharacterGrowthOdp.Value;

        private void CharacterActualOdp_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[3].Actual = (int)CharacterActualOdp.Value;

        private void CharacterStartingZr_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[4].Starting = (int)CharacterStartingZr.Value;

        private void CharacterGrowthZr_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[4].Growth = (int)CharacterGrowthZr.Value;

        private void CharacterActualZr_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[4].Actual = (int)CharacterActualZr.Value;

        private void CharacterStartingInt_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[5].Starting = (int)CharacterStartingInt.Value;

        private void CharacterGrowthInt_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[5].Growth = (int)CharacterGrowthInt.Value;

        private void CharacterActualInt_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[5].Actual = (int)CharacterActualInt.Value;

        private void CharacterStartingSW_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[6].Starting = (int)CharacterStartingSW.Value;

        private void CharacterGrowthSW_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[6].Growth = (int)CharacterGrowthSW.Value;

        private void CharacterActualSW_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[6].Actual = (int)CharacterActualSW.Value;

        private void CharacterStartingOgd_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[7].Starting = (int)CharacterStartingOgd.Value;

        private void CharacterGrowthOgd_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[7].Growth = (int)CharacterGrowthOgd.Value;

        private void CharacterActualOgd_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[7].Actual = (int)CharacterActualOgd.Value;

        private void CharacterStartingA_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[8].Starting = (int)CharacterStartingA.Value;

        private void CharacterGrowthA_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[8].Growth = (int)CharacterGrowthA.Value;

        private void CharacterActualA_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[8].Actual = (int)CharacterActualA.Value;

        private void CharacterStartingZyw_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[9].Starting = (int)CharacterStartingZyw.Value;

        private void CharacterGrowthZyw_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[9].Growth = (int)CharacterGrowthZyw.Value;

        private void CharacterActualZyw_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[9].Actual = (int)CharacterActualZyw.Value;

        private void CharacterStartingS_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[10].Starting = (int)CharacterStartingS.Value;

        private void CharacterGrowthS_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[10].Growth = (int)CharacterGrowthS.Value;

        private void CharacterActualS_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[10].Actual = (int)CharacterActualS.Value;

        private void CharacterStartingWt_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[11].Starting = (int)CharacterStartingWt.Value;

        private void CharacterGrowthWt_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[11].Growth = (int)CharacterGrowthWt.Value;

        private void CharacterActualWt_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[11].Actual = (int)CharacterActualWt.Value;

        private void CharacterStartingSz_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[12].Starting = (int)CharacterStartingSz.Value;

        private void CharacterGrowthSz_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[12].Growth = (int)CharacterGrowthSz.Value;

        private void CharacterActualSz_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[12].Actual = (int)CharacterActualSz.Value;

        private void CharacterStartingMag_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[13].Starting = (int)CharacterStartingMag.Value;

        private void CharacterGrowthMag_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[13].Growth = (int)CharacterGrowthMag.Value;

        private void CharacterActualMag_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[13].Actual = (int)CharacterActualMag.Value;

        private void CharacterStartingPO_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[14].Starting = (int)CharacterStartingPO.Value;

        private void CharacterGrowthPO_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[14].Growth = (int)CharacterGrowthPO.Value;

        private void CharacterActualPO_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[14].Actual = (int)CharacterActualPO.Value;

        private void CharacterStartingPP_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[15].Starting = (int)CharacterStartingPP.Value;

        private void CharacterGrowthPP_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[15].Growth = (int)CharacterGrowthPP.Value;

        private void CharacterActualPP_ValueChanged(object sender, EventArgs e) => CurrentCharacter.Traits[15].Actual = (int)CharacterActualPP.Value;

        private void WeaponName1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[0].Name = WeaponName1.Text;

        private void WeaponWeight1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[0].Weight = WeaponWeight1.Text;

        private void WeaponCategory1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[0].Category = WeaponCategory1.Text;

        private void WeaponStrength1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[0].Strength = WeaponStrength1.Text;

        private void WeaponRange1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[0].Range = WeaponRange1.Text;

        private void WeaponReload1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[0].Reload = WeaponReload1.Text;

        private void WeaponTraits1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[0].Traits = WeaponTraits1.Text;

        private void WeaponName2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[1].Name = WeaponName2.Text;

        private void WeaponWeight2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[1].Weight = WeaponWeight2.Text;

        private void WeaponCategory2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[1].Category = WeaponCategory2.Text;

        private void WeaponStrength2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[1].Strength = WeaponStrength2.Text;

        private void WeaponRange2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[1].Range = WeaponRange2.Text;

        private void WeaponReload2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[1].Reload = WeaponReload2.Text;

        private void WeaponTraits2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[1].Traits = WeaponTraits2.Text;

        private void WeaponName3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[2].Name = WeaponName3.Text;

        private void WeaponWeight3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[2].Weight = WeaponWeight3.Text;

        private void WeaponCategory3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[2].Category = WeaponCategory3.Text;

        private void WeaponStrength3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[2].Strength = WeaponStrength3.Text;

        private void WeaponRange3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[2].Range = WeaponRange3.Text;

        private void WeaponReload3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[2].Reload = WeaponReload3.Text;

        private void WeaponTraits3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[2].Traits = WeaponTraits3.Text;

        private void WeaponName4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[3].Name = WeaponName4.Text;

        private void WeaponWeight4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[3].Weight = WeaponWeight4.Text;

        private void WeaponCategory4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[3].Category = WeaponCategory4.Text;

        private void WeaponStrength4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[3].Strength = WeaponStrength4.Text;

        private void WeaponRange4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[3].Range = WeaponRange4.Text;

        private void WeaponReload4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[3].Reload = WeaponReload4.Text;

        private void WeaponTraits4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[3].Traits = WeaponTraits4.Text;

        private void WeaponName5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[4].Name = WeaponName5.Text;

        private void WeaponWeight5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[4].Weight = WeaponWeight5.Text;

        private void WeaponCategory5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[4].Category = WeaponCategory5.Text;

        private void WeaponStrength5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[4].Strength = WeaponStrength5.Text;

        private void WeaponRange5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[4].Range = WeaponRange5.Text;

        private void WeaponReload5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[4].Reload = WeaponReload5.Text;

        private void WeaponTraits5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[4].Traits = WeaponTraits5.Text;

        private void WeaponName6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[5].Name = WeaponName6.Text;

        private void WeaponWeight6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[5].Weight = WeaponWeight6.Text;

        private void WeaponCategory6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[5].Category = WeaponCategory6.Text;
        
        private void WeaponStrength6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[5].Strength = WeaponStrength6.Text;

        private void WeaponRange6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[5].Range = WeaponRange6.Text;

        private void WeaponReload6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[5].Reload = WeaponReload6.Text;

        private void WeaponTraits6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Weapons[5].Traits = WeaponTraits6.Text;

        private void PlayerName_TextChanged(object sender, EventArgs e) => CurrentPlayer.Name = PlayerName.Text;

        private void GameMaster_TextChanged(object sender, EventArgs e) => CurrentPlayer.GameMaster = GameMaster.Text;

        private void CampaignName_TextChanged(object sender, EventArgs e) => CurrentPlayer.Campaign = CampaignName.Text;

        private void CampaignYear_TextChanged(object sender, EventArgs e) => CurrentPlayer.CampaignYear = CampaignYear.Text;

        private void CharacterCurrentXP_TextChanged(object sender, EventArgs e) => CurrentCharacter.CurrentXP = CharacterCurrentXP.Text;

        private void CharacterTotalXP_TextChanged(object sender, EventArgs e) => CurrentCharacter.TotalXP = CharacterTotalXP.Text;

        private void CharacterMovementRetreat_TextChanged(object sender, EventArgs e) => CurrentCharacter.MovementRetreat = CharacterMovementRetreat.Text;

        private void CharacterCharge_TextChanged(object sender, EventArgs e) => CurrentCharacter.Charge = CharacterCharge.Text;

        private void CharacterSprint_TextChanged(object sender, EventArgs e) => CurrentCharacter.Sprint = CharacterSprint.Text;

        private void CharacterHead_TextChanged(object sender, EventArgs e) => CurrentCharacter.Head = CharacterHead.Text;

        private void CharacterBody_TextChanged(object sender, EventArgs e) => CurrentCharacter.Body = CharacterBody.Text;

        private void CharacterRightArm_TextChanged(object sender, EventArgs e) => CurrentCharacter.RightArm = CharacterRightArm.Text;

        private void CharacterLeftArm_TextChanged(object sender, EventArgs e) => CurrentCharacter.LeftArm = CharacterLeftArm.Text;

        private void CharacterRightLeg_TextChanged(object sender, EventArgs e) => CurrentCharacter.RightLeg = CharacterRightLeg.Text;

        private void CharacterLeftLeg_TextChanged(object sender, EventArgs e) => CurrentCharacter.LeftLeg = CharacterLeftLeg.Text;

        private void SimpleArmourType_TextChanged(object sender, EventArgs e) => CurrentCharacter.SArmor.Type = SimpleArmorType.Text;

        private void SimpleArmorPZ_TextChanged(object sender, EventArgs e) => CurrentCharacter.SArmor.PZ = SimpleArmorPZ.Text;

        private void AdvancedArmorType1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[0].Type = AdvancedArmorType1.Text;

        private void AdvancedArmorWeight1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[0].Weight = AdvancedArmorWeight1.Text;

        private void AdvancedArmorLocation1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[0].Location = AdvancedArmorLocation1.Text;

        private void AdvancedArmorPZ1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[0].PZ = AdvancedArmorPZ1.Text;

        private void AdvancedArmorType2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[1].Type = AdvancedArmorType2.Text;

        private void AdvancedArmorWeight2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[1].Weight = AdvancedArmorWeight2.Text;

        private void AdvancedArmorLocation2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[1].Location = AdvancedArmorLocation2.Text;

        private void AdvancedArmorPZ2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[1].PZ = AdvancedArmorPZ2.Text;

        private void AdvancedArmorType3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[2].Type = AdvancedArmorType3.Text;

        private void AdvancedArmorWeight3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[2].Weight = AdvancedArmorWeight3.Text;

        private void AdvancedArmorLocation3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[2].Location = AdvancedArmorLocation3.Text;

        private void AdvancedArmorPZ3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[2].PZ = AdvancedArmorPZ3.Text;

        private void AdvancedArmorType4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[3].Type = AdvancedArmorType4.Text;

        private void AdvancedArmorWeight4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[3].Weight = AdvancedArmorWeight4.Text;

        private void AdvancedArmorLocation4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[3].Location = AdvancedArmorLocation4.Text;

        private void AdvancedArmorPZ4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[3].PZ = AdvancedArmorPZ4.Text;

        private void AdvancedArmorType5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[4].Type = AdvancedArmorType5.Text;

        private void AdvancedArmorWeight5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[4].Weight = AdvancedArmorWeight5.Text;

        private void AdvancedArmorLocation5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[4].Location = AdvancedArmorLocation5.Text;

        private void AdvancedArmorPZ5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[4].PZ = AdvancedArmorPZ5.Text;

        private void AdvancedArmorType6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[5].Type = AdvancedArmorType6.Text;

        private void AdvancedArmorWeight6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[5].Weight = AdvancedArmorWeight6.Text;

        private void AdvancedArmorLocation6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[5].PZ = AdvancedArmorPZ6.Text;

        private void AdvancedArmorPZ6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Armors[5].PZ = AdvancedArmorPZ6.Text;
        #endregion

        private void CharacterSkill1_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[0].Skill1 = CharacterSkill1_1.Checked;

        private void CharacterSkill1_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[0].Skill2 = CharacterSkill1_2.Checked;

        private void CharacterSkill1_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[0].Skill3 = CharacterSkill1_3.Checked;

        private void CharacterConnectedSkill1_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[0].ConnectedSkill = CharacterConnectedSkill1.Text;

        private void CharacterSkill2_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[1].Skill1 = CharacterSkill2_1.Checked;

        private void CharacterSkill2_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[1].Skill2 = CharacterSkill2_2.Checked;

        private void CharacterSkill2_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[1].Skill3 = CharacterSkill2_3.Checked;

        private void CharacterConnectedSkill2_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[1].ConnectedSkill = CharacterConnectedSkill2.Text;

        private void CharacterSkill3_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[2].Skill1 = CharacterSkill3_1.Checked;

        private void CharacterSkill3_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[2].Skill2 = CharacterSkill3_2.Checked;

        private void CharacterSkill3_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[2].Skill3 = CharacterSkill3_3.Checked;

        private void CharacterConnectedSkill3_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[2].ConnectedSkill = CharacterConnectedSkill3.Text;

        private void CharacterSkill4_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[3].Skill1 = CharacterSkill4_1.Checked;

        private void CharacterSkill4_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[3].Skill2 = CharacterSkill4_2.Checked;

        private void CharacterSkill4_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[3].Skill3 = CharacterSkill4_3.Checked;

        private void CharacterConnectedSkill4_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[3].ConnectedSkill = CharacterConnectedSkill4.Text;

        private void CharacterSkill5_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[4].Skill1 = CharacterSkill5_1.Checked;

        private void CharacterSkill5_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[4].Skill2 = CharacterSkill5_2.Checked;

        private void CharacterSkill5_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[4].Skill3 = CharacterSkill5_3.Checked;

        private void CharacterConnectedSkill5_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[4].ConnectedSkill = CharacterConnectedSkill5.Text;

        private void CharacterSkill6_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[5].Skill1 = CharacterSkill6_1.Checked;

        private void CharacterSkill6_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[5].Skill2 = CharacterSkill6_2.Checked;

        private void CharacterSkill6_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[5].Skill3 = CharacterSkill6_3.Checked;

        private void CharacterConnectedSkill6_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[5].ConnectedSkill = CharacterConnectedSkill6.Text;

        private void CharacterSkill7_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[6].Skill1 = CharacterSkill7_1.Checked;

        private void CharacterSkill7_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[6].Skill2 = CharacterSkill7_2.Checked;

        private void CharacterSkill7_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[6].Skill3 = CharacterSkill7_3.Checked;

        private void CharacterConnectedSkill7_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[6].ConnectedSkill = CharacterConnectedSkill7.Text;

        private void CharacterSkill8_1_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[7].Skill1 = CharacterSkill8_1.Checked;

        private void CharacterSkill8_2_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[7].Skill2 = CharacterSkill8_2.Checked;

        private void CharacterSkill8_3_CheckedChanged(object sender, EventArgs e) => CurrentCharacter.Skills[7].Skill3 = CharacterSkill8_3.Checked;

        private void CharacterConnectedSkill8_TextChanged(object sender, EventArgs e) => CurrentCharacter.Skills[7].ConnectedSkill = CharacterConnectedSkill8.Text;
    }
}
