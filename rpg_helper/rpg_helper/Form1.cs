using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg_helper
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            //Set Defaults
            race_dropdown.SelectedIndex = 0;
            class_dropdown.SelectedIndex = 0;
            background_dropdown.SelectedIndex = 0;
            alignment_dropdown.SelectedIndex = 0;
            //Set combobox styling
            race_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            class_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            background_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            alignment_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void race_dropdown_SelectedValueChanged(object sender, EventArgs e)
        {
           // UpdateCharacterSheet();
        }

        private void UpdateCharacterSheet()
        {
            //Reset values first
            //Ability Modifiers
            str_abm_label.ResetText();
            dex_abm_label.ResetText();
            const_abm_label.ResetText();
            wis_abm_label.ResetText();
            char_abm_label.ResetText();
            proficiency_abm_label.ResetText();
            initative_abm_label.ResetText();
            speed_abm_label.ResetText();
            //Ability Scores Final
            char_final_label.ResetText();
            wis_final_label.ResetText();
            const_final_label.ResetText();
            dex_final_label.ResetText();
            str_final_label.ResetText();
            //Skills
            acro_label.ResetText();
            animal_label.ResetText();
            arcana_label.ResetText();
            athletics_label.ResetText();
            deception_label.ResetText();
            history_label.ResetText();
            insight_label.ResetText();
            intimidation_label.ResetText();
            investigation_label.ResetText();
            medicine_label.ResetText();
            nature_label.ResetText();
            perception_label.ResetText();
            performance_label.ResetText();
            persuasion_label.ResetText();
            religion_label.ResetText();
            sleightofhand_label.ResetText();
            stealth_label.ResetText();
            survival_label.ResetText();
            //Saving Throws
            strength_save_label.ResetText();
            dex_save_label.ResetText();
            const_save_label.ResetText();
            intel_save_label.ResetText();
            wisd_save_label.ResetText();
            char_save_label.ResetText();

            //Temp variables
            int strength = 0;
            int constitution = 0;
            int dexterity = 0;
            int wisdom = 0;
            int charisma = 0;
            //Add in racial bonuses
            switch(race_dropdown.SelectedIndex)
            {
                //Dwarf
                case 0:
                    break;
                //Elf
                case 1:
                    break;
                //Halfling
                case 2:
                    break;
                //Human
                case 3:
                    break;
                default:
                    break;
            }
            //Add in class bonuses
            switch(class_dropdown.SelectedIndex)
            {
                //Cleric
                case 0:
                    break;
                //Fighter
                case 1:
                    break;
                //Rogue
                case 2:
                    break;
                //Wizard
                case 3:
                    break;
                default:
                    break;
            }
            //Add in background bonuses
            switch(background_dropdown.SelectedIndex)
            {
                //Acolyte
                case 0:
                    break;
                //Criminal
                case 1:
                    break;
                //Folk Hero
                case 2:
                    break;
                //Noble
                case 3:
                    break;
                //Sage
                case 4:
                    break;
                //Soldier
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}
