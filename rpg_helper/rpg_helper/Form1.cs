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
        Player_Collection p = new Player_Collection();
        NPC_Collection npc = new NPC_Collection();
        BindingSource bs = new BindingSource();

        public main_form()
        {
            InitializeComponent();
            bs.DataSource = p.playerList;
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

            //Set list here?
            try {
                lb_CurrentPlayers.DisplayMember = "name";
                lb_CurrentPlayers.ValueMember = "id";
                lb_CurrentPlayers.DataSource = bs;
            }
            catch
            {
                Console.WriteLine("Blehhhh");
            }



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
            //Skills checkboxes
            acro_checkbox.Checked = false;
            animal_checkbox.Checked = false;
            arcana_checkbox.Checked = false;
            athletics_checkbox.Checked = false;
            deception_checkbox.Checked = false;
            history_checkbox.Checked = false;
            insight_checkbox.Checked = false;
            intimidation_checkbox.Checked = false;
            investigation_checkbox.Checked = false;
            medicine_checkbox.Checked = false;
            nature_checkbox.Checked = false;
            perception_checkbox.Checked = false;
            performance_checkbox.Checked = false;
            persuasion_checkbox.Checked = false;
            religion_checkbox.Checked = false;
            sleightofhand_checkbox.Checked = false;
            stealth_checkbox.Checked = false;
            survival_checkbox.Checked = false;
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
                    insight_checkbox.Checked = true;
                    religion_checkbox.Checked = true;
                    break;
                //Criminal
                case 1:
                    deception_checkbox.Checked = true;
                    stealth_checkbox.Checked = true;
                    break;
                //Folk Hero
                case 2:
                    animal_checkbox.Checked = true;
                    survival_checkbox.Checked = true;
                    break;
                //Noble
                case 3:
                    history_checkbox.Checked = true;
                    persuasion_checkbox.Checked = true;
                    break;
                //Sage
                case 4:
                    arcana_checkbox.Checked = true;
                    history_checkbox.Checked = true;
                    break;
                //Soldier
                case 5:
                    athletics_checkbox.Checked = true;
                    intimidation_checkbox.Checked = true;
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
            speed_abm_label.Text = speed.ToString();

            //calculate modifier
            str_abm_label.Text = Math.Floor(((float)strength - 10) / 2).ToString();
            const_abm_label.Text = Math.Floor(((float)constitution - 10) / 2).ToString();
            wis_abm_label.Text = Math.Floor(((float)wisdom - 10) / 2).ToString();
            dex_abm_label.Text = Math.Floor(((float)dexterity - 10) / 2).ToString();
            char_abm_label.Text = Math.Floor(((float)charisma - 10) / 2).ToString();
        }

        private void OpenMap_Click(object sender, EventArgs e)
        {
            string fileName;
            openFileDialog1.InitialDirectory = "This PC";
            openFileDialog1.Title = "Open a map image file";
            openFileDialog1.ShowDialog();

            fileName = openFileDialog1.FileName;

            map = Image.FromFile(fileName);
           
            GenerateMap();
            
        }

        private void GenerateMap()
        {
           Form form = new Form();
           Panel p = new Panel();
           PictureBox pb = new PictureBox();

           form.StartPosition = FormStartPosition.CenterScreen;
           form.WindowState = FormWindowState.Normal;
           form.FormBorderStyle = FormBorderStyle.Fixed3D;
           form.WindowState = FormWindowState.Maximized;

           p.AutoScroll = true;
           p.AutoSize = true;
           p.Size = form.Size;
           p.Dock = DockStyle.Fill;
           p.HorizontalScroll.Enabled = true;
           p.HorizontalScroll.Visible = true;
           p.HorizontalScroll.Maximum = 0;
            
           pb.Dock = DockStyle.None;
           pb.Size = map.Size;
           pb.Image = map;

           p.Controls.Add(pb);
            
           form.Controls.Add(p);
           form.ShowDialog();
            
        }
        
       

        private void btn_AddPlayer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("adding player");
            Player tempP = new Player();
            //Get all the feilds from the form and populate player object from them.
            //Then add the player object through the collection class instance declared above.
            tempP.name = charname_txtbx.Text;
            tempP.id = p.playerCount;
            p.addPlayer(tempP);

            bs.ResetBindings(false);
            Console.WriteLine(p.playerList.Count);
        }
    }
}
