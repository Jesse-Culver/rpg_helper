using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace rpg_helper
{
    public partial class main_form : Form
    {
        Image map;

        

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

        /**********
         * Begin Character Tab Functions
         **********/
        private void update_btn_Click(object sender, EventArgs e)
        {
            UpdateCharacterSheet();
        }
        private void UpdateCharacterSheet()
        {
            //Reset values first
            //Ability Modifiers
            str_abm_label.Text = "0";
            dex_abm_label.Text = "0";
            const_abm_label.Text = "0";
            wis_abm_label.Text = "0";
            char_abm_label.Text = "0";
            proficiency_abm_label.Text = "0";
            initative_abm_label.Text = "0";
            speed_abm_label.Text = "0";
            //Ability Scores Final
            char_final_label.Text = "0";
            wis_final_label.Text = "0";
            const_final_label.Text = "0";
            dex_final_label.Text = "0";
            str_final_label.Text = "0";
            //Skills
            acro_label.Text = "0";
            animal_label.Text = "0";
            arcana_label.Text = "0";
            athletics_label.Text = "0";
            deception_label.Text = "0";
            history_label.Text = "0";
            insight_label.Text = "0";
            intimidation_label.Text = "0";
            investigation_label.Text = "0";
            medicine_label.Text = "0";
            nature_label.Text = "0";
            perception_label.Text = "0";
            performance_label.Text = "0";
            persuasion_label.Text = "0";
            religion_label.Text = "0";
            sleightofhand_label.Text = "0";
            stealth_label.Text = "0";
            survival_label.Text = "0";
            //Saving Throws
            strength_save_label.Text = "0";
            dex_save_label.Text = "0";
            const_save_label.Text = "0";
            intel_save_label.Text = "0";
            wisd_save_label.Text = "0";
            char_save_label.Text = "0";
            wis_save_checkbox.Checked = false;
            intel_save_checkbox.Checked = false;
            dex_save_checkbox.Checked = false;
            str_save_checkbox.Checked = false;
            const_save_checkbox.Checked = false;
            char_save_checkbox.Checked = false;
            //Abilities
            features_textbox.ResetText();
            

            //Temp variables
            int strength = Convert.ToInt32(str_abs_numbox.Value);
            int constitution = Convert.ToInt32(cons_abs_numbox.Value);
            int dexterity = Convert.ToInt32(dex_abs_numbox.Value);
            int wisdom = Convert.ToInt32(wis_abs_numbox.Value);
            int charisma = Convert.ToInt32(char_abs_numbox.Value);
            int speed = 0;
            //Add in racial bonuses
            switch(race_dropdown.SelectedIndex)
            {
                //Dwarf
                case 0:
                    constitution = constitution + 2;
                    speed = speed + 25;
                    features_textbox.AppendText("Darkvision\n");
                    features_textbox.AppendText("Dwarven Resilience\n");
                    features_textbox.AppendText("Dwarven Combat Training\n");
                    features_textbox.AppendText("Tool Proficiency\n");
                    features_textbox.AppendText("Stonecunning\n");
                    features_textbox.AppendText("Common\n");
                    features_textbox.AppendText("Dwarvish\n");
                    break;
                //Elf
                case 1:
                    dexterity = dexterity + 2;
                    speed = speed + 30;
                    features_textbox.AppendText("Darkvision\n");
                    features_textbox.AppendText("Keen Senses\n");
                    features_textbox.AppendText("Fey Ancestry\n");
                    features_textbox.AppendText("Trance\n");
                    features_textbox.AppendText("Common\n");
                    features_textbox.AppendText("Elvish\n");
                    break;
                //Halfling
                case 2:
                    dexterity = dexterity + 2;
                    speed = speed + 25;
                    features_textbox.AppendText("Lucky\n");
                    features_textbox.AppendText("Brave\n");
                    features_textbox.AppendText("Halfling Nimbleness\n");
                    features_textbox.AppendText("Common\n");
                    features_textbox.AppendText("Halfling\n");
                    break;
                //Human
                case 3:
                    dexterity++;
                    strength++;
                    constitution++;
                    wisdom++;
                    charisma++;
                    speed = speed + 30;
                    features_textbox.AppendText("Common\n");
                    features_textbox.AppendText("Language of choice\n");
                    break;
                default:
                    break;
            }
            //Add in class bonuses
            switch(class_dropdown.SelectedIndex)
            {
                //Cleric
                case 0:
                    hitdie_label.Text = "d8";
                    wis_save_checkbox.Checked = true;
                    char_save_checkbox.Checked = true;
                    break;
                //Fighter
                case 1:
                    hitdie_label.Text = "d10";
                    str_save_checkbox.Checked = true;
                    const_save_checkbox.Checked = true;
                    break;
                //Rogue
                case 2:
                    hitdie_label.Text = "d8";
                    dex_save_checkbox.Checked = true;
                    intel_save_checkbox.Checked = true;
                    break;
                //Wizard
                case 3:
                    hitdie_label.Text = "d6";
                    wis_save_checkbox.Checked = true;
                    intel_save_checkbox.Checked = true;
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

            //Set final ability scores
            str_final_label.Text = strength.ToString();
            const_final_label.Text = constitution.ToString();
            wis_final_label.Text = wisdom.ToString();
            dex_final_label.Text = dexterity.ToString();
            char_final_label.Text = charisma.ToString();
        }

        private void OpenMap_Click(object sender, EventArgs e)
        {
            string fileName;
            openFileDialog1.InitialDirectory = "This PC";
            openFileDialog1.Title = "Open a map image file";
            openFileDialog1.ShowDialog();

            fileName = openFileDialog1.FileName;

            map = Image.FromFile(fileName);

            int width = map.Width * 100 / 50;
            int height = map.Height * 100 / 100;
            resize(width, height);
            
        }

        private void resize(int width, int height)
        {
            Bitmap image = new Bitmap(width, height);
            Rectangle rect = new Rectangle(0, 0, width, height);
            
            image.SetResolution(map.HorizontalResolution, map.VerticalResolution);
            using (var g = Graphics.FromImage(image))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                
                using (var wrapmode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapmode.SetWrapMode(WrapMode.TileFlipXY);
                    g.DrawImage(map, rect, 0, 0, map.Width, map.Height, GraphicsUnit.Pixel, wrapmode);

                }
            }

            pictureBox1.Image = image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


           

        }

        private void ResizeBar_Scroll(object sender, EventArgs e)
        {
            int width = (map.Width * ResizeBar.Value) / 50;
            int height = (map.Height * ResizeBar.Value) / 100;

            resize(width, height);
        }
    }
}
