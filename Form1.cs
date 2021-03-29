using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerontCacheSimulator
{
    public partial class CacheSimForm : Form
    {
        
        ///////////////////////////////////////////////  GLOBAL VARIABLES  //////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// Main Memory to Pull from
        private string[] MainMemory = { "92", "70", "8C", "FD", "B9", "E2", "40", "C2",
                                        "0D", "9A", "D1", "F8", "43", "7E", "B7", "75",
                                        "FB", "44", "DD", "F6", "A6", "43", "11", "17",
                                        "98", "88", "08", "6A", "6D", "B8", "BC", "12",
                                        "0A", "F1", "4C", "45", "63", "2C", "40", "98",
                                        "91", "65", "0E", "76", "EE", "5D", "18", "29",
                                        "85", "13", "60", "C5", "56", "F2", "89", "9E",
                                        "06", "E2", "0B", "A2", "B2", "41", "B1", "7B" };

        /// Currently stored Cache
        private ArrayList CacheState = new ArrayList();

        ///// Initially all are set to false. When implemented, if SET_* is TRUE, it was the first to enter (i.e. it will be replaced next)
        private bool SET_001 = false;
        private bool SET_002 = false;
        private bool SET_011 = false;
        private bool SET_012 = false;
        private bool SET_101 = false;
        private bool SET_102 = false;
        private bool SET_111 = false;
        private bool SET_112 = false;

        /// Tags and Data names to find labels in GUI
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////   0          1          2          3          4          5          6         7   ///////////////////////////
        private string[] tags =  { "Tag_01",  "Tag_02",  "Tag_11",  "Tag_12",  "Tag_21",  "Tag_22",  "Tag_31",  "Tag_32"  };
        private string[] datas = { "Data_01", "Data_02", "Data_11", "Data_12", "Data_21", "Data_22", "Data_31", "Data_32" };
        ///////////////////////////   0          1          2          3          4          5          6         7   ///////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        //////////////////////////////////////////////////  GUI METHODS  ////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Init
        public CacheSimForm()
        {
            InitializeComponent();
        }

        // Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill Memory
            InsertMainMemory();

            // Fill Cache with empty values
            InitCache();
        }

        // Enable View of Memory Table
        private void ViewMemoryMenu_Click(object sender, EventArgs e)
        {

            if (ViewMemoryMenu.Checked)
            {
                ViewMemoryMenu.Checked = false;
            }
            else
            {
                ViewMemoryMenu.Checked = true;
            }

            if (ViewMemoryMenu.Checked)
            {
                Size = new Size(1009, 557);
                Memory_Panel.Visible = true;
            }
            else if (!ViewMemoryMenu.Checked)
            {
                Size = new Size(555, 557);
                Memory_Panel.Visible = false;
            }
        }

        // Clear Cache
        private void ClearCacheButton_Click(object sender, EventArgs e)
        {
            InitCache();
        }

        // Clear Cache (From Menu Select)
        private void ClearCacheMenu_Click(object sender, EventArgs e)
        {
            InitCache();
        }

        // Implement Cache Logic
        private void AddressInputButton_Click(object sender, EventArgs e)
        {

            // Get address input by user : Check for validity
            string S_address = AddressInput.Text;
            if((S_address == "") || (S_address == null))
            {
                AddressInput.Text = "";
                return;
            }

            // See if input is a number
            int number;
            bool canParse = int.TryParse(S_address, out number);
            if (!canParse)
            {
                AddressInput.Text = "";
                return;
            }

            // See if number is between 0-63
            int address = int.Parse(S_address);
            if((address < 0) || (address > 63))
            {
                AddressInput.Text = "";
                return;
            }


            // Implement Cache Logic

            // Check for Hit or Miss
            if (CacheState.Contains(address))
            {
                InfoUpdate(address, true);
                AddressInput.Text = "";
                return;
            }
            else
            {
                InfoUpdate(address, false);
            }

            // SET 00
            if (address%4 == 0)
            {
                if((!SET_001 && !SET_002) || (!SET_001 && SET_002))
                {
                    // Toggle FIFO
                    SET_001 = true;
                    SET_002 = false;

                    // Insert Cache
                    InsertCacheValue(address, 0);
                }
                else if (SET_001 && !SET_002)
                {
                    // Toggle FIFO
                    SET_001 = false;
                    SET_002 = true;

                    // Insert Cache
                    InsertCacheValue(address, 1);
                }
            }

            // SET 01
            else if(address%4 == 1)
            {
                if ((!SET_011 && !SET_012) || (!SET_011 && SET_012))
                {
                    // Toggle FIFO
                    SET_011 = true;
                    SET_012 = false;

                    // Insert Cache
                    InsertCacheValue(address, 2);
                }
                else if (SET_011 && !SET_012)
                {
                    // Toggle FIFO
                    SET_011 = false;
                    SET_012 = true;

                    // Insert Cache
                    InsertCacheValue(address, 3);
                }
            }

            // SET 10
            else if(address%4 == 2)
            {
                if ((!SET_101 && !SET_102) || (!SET_101 && SET_102))
                {
                    // Toggle FIFO
                    SET_101 = true;
                    SET_102 = false;

                    // Insert Cache
                    InsertCacheValue(address, 4);
                }
                else if (SET_101 && !SET_102)
                {
                    // Toggle FIFO
                    SET_101 = false;
                    SET_102 = true;

                    // Insert Cache
                    InsertCacheValue(address, 5);
                }
            }

            // SET 11
            else if(address%4 == 3)
            {
                if ((!SET_111 && !SET_112) || (!SET_111 && SET_112))
                {
                    // Toggle FIFO
                    SET_111 = true;
                    SET_112 = false;

                    // Insert Cache
                    InsertCacheValue(address, 6);
                }
                else if (SET_111 && !SET_112)
                {
                    // Toggle FIFO
                    SET_111 = false;
                    SET_112 = true;

                    // Insert Cache
                    InsertCacheValue(address, 7);
                }
            }

            // Clear Address Input Box
            TextBox ai = this.Controls.Find("AddressInput", true).FirstOrDefault() as TextBox;
            ai.Text = "";

        }

        // Execute AddressInputButton if "Enter" is pressed
        private void AddressInputCheckEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddressInputButton_Click(this, new EventArgs());

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Open Help Page
        private void ViewHelpMenu_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            form.Show();
        }

        // Open About Page
        private void AboutMenu_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        // Exit Program
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        ////////////////////////////////////////////////  CUSTOM METHODS  ///////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Fill Memory Table
        private void InsertMainMemory()
        {
            for (int i = 0; i < 64; i++)
            {
                string output = "";
                if (i < 16)
                {
                    if (i < 10)
                    {
                        int length = i.ToString("D").Length + 1;
                        output = i.ToString("D" + length.ToString());
                    }
                    else
                    {
                        output = i.ToString();
                    }
                    string[] row = { output, MainMemory[i] };
                    var listViewItem = new ListViewItem(row);
                    Mem1.Items.Add(listViewItem);
                }
                else if (i >= 16 && i < 32)
                {
                    output = i.ToString();
                    string[] row = { output, MainMemory[i] };
                    var listViewItem = new ListViewItem(row);
                    Mem2.Items.Add(listViewItem);
                }
                else if (i >= 32 && i < 48)
                {
                    output = i.ToString();
                    string[] row = { output, MainMemory[i] };
                    var listViewItem = new ListViewItem(row);
                    Mem3.Items.Add(listViewItem);
                }
                else if (i >= 48)
                {
                    output = i.ToString();
                    string[] row = { output, MainMemory[i] };
                    var listViewItem = new ListViewItem(row);
                    Mem4.Items.Add(listViewItem);
                }
            }
        }

        // Initialize Cache to empty
        private void InitCache()
        {
            // Clear Cache
            CacheState.Clear();

            // Reset FIFO
            BoolReset();

            // variables
            string tag = "Tag_";
            string data = "Data_";

            for (int i = 0; i < 4; i++)
            {
                // Init setNum
                string setNum = i.ToString();

                string tagOne = tag + setNum + "1";
                string dataOne = data + setNum + "1";
                string tagTwo = tag + setNum + "2";
                string dataTwo = data + setNum + "2";

                Label l_tagOne = this.Controls.Find(tagOne, true).FirstOrDefault() as Label;
                Label l_dataOne = this.Controls.Find(dataOne, true).FirstOrDefault() as Label;
                Label l_tagTwo = this.Controls.Find(tagTwo, true).FirstOrDefault() as Label;
                Label l_dataTwo = this.Controls.Find(dataTwo, true).FirstOrDefault() as Label;

                l_tagOne.Text = "-----";
                l_dataOne.Text = "-----";
                l_tagTwo.Text = "-----";
                l_dataTwo.Text = "-----";

            }
        }
    
        // Convert address to binary string and return the tag portion
        // i.e. 16 = 010000 returns 0100
        private string AddressToBinary(int address)
        {
            string binary = Convert.ToString(address, 2).PadLeft(6, '0');
            string tag = binary.Substring(0, 4);
            return tag;
        }

        // Inserts value into cache
        private void InsertCacheValue(int address, int loc)
        {
            // Insert Cache to the current Cache State
            CacheState.Add(address);

            Label l_tag = this.Controls.Find(tags[loc], true).FirstOrDefault() as Label;
            Label l_data = this.Controls.Find(datas[loc], true).FirstOrDefault() as Label;

            l_tag.Text = AddressToBinary(address);
            l_data.Text = MainMemory[address];
        }
    
        // Update Hit/Miss Info
        private void InfoUpdate(int address, bool isHit)
        {
            string output = address.ToString();
            if (address < 10)
            {
                int length = address.ToString("D").Length + 1;
                output = address.ToString("D" + length.ToString());
            }

            // Update Information
            Label l_lac = this.Controls.Find("LAC", true).FirstOrDefault() as Label;
            Label l_tag = this.Controls.Find("HM_Tag", true).FirstOrDefault() as Label;
            Label l_data = this.Controls.Find("HM_Data", true).FirstOrDefault() as Label;

            l_lac.Text = output;
            l_tag.Text = "Tag = " + AddressToBinary(address);
            l_data.Text = "Data = " + MainMemory[address];

            // Update Hit/Miss
            Label l_hit = this.Controls.Find("HM_Hit", true).FirstOrDefault() as Label;
            Label l_miss = this.Controls.Find("HM_Miss", true).FirstOrDefault() as Label;

            if (isHit)
            {
                l_miss.BackColor = SystemColors.GradientInactiveCaption;
                l_miss.ForeColor = SystemColors.ControlText;

                l_hit.BackColor = SystemColors.Window;
                l_hit.ForeColor = Color.OrangeRed;
            }
            else
            {
                l_hit.BackColor = SystemColors.GradientInactiveCaption;
                l_hit.ForeColor = SystemColors.ControlText;

                l_miss.BackColor = SystemColors.Window;
                l_miss.ForeColor = Color.OrangeRed;
            }
        }

        // Reset Cache Settings
        private void BoolReset()
        {
            SET_001 = false;
            SET_002 = false;
            SET_011 = false;
            SET_012 = false;
            SET_101 = false;
            SET_102 = false;
            SET_111 = false;
            SET_112 = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }

}
