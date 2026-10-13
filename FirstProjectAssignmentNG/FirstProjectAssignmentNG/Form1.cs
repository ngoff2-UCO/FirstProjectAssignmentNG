namespace FirstProjectAssignmentNG
{
    public partial class Form1 : Form
    {
        String font = "Segoe UI"; // default font
        String[] clipboard = { "", "", "", "" };
        String[] clipboardFonts = { "", "", "", "", "", "", "", "" };
        int[] clipboardSlots = { 0, 0, 0, 0 };

        int clipIndex = 0;

        int size = 9; // default size
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateFont() // helper for changing the font in the textbox
        {
            EditBox.Font = new Font(font, size);
        }
        private void ClearEdit() // helper for resetting the text
        {
            EditBox.Text = "";
        }
        private void AddClip(int slot) // add to appropriate spot in the clipboard
        {
            if (slot == 0)
            {
                Clip1.Text = clipboard[0];
                Clip1.Font = new Font(clipboardFonts[0], int.Parse(clipboardFonts[1]));
            }
            else if (slot == 1)
            {
                Clip2.Text = clipboard[1];
                Clip2.Font = new Font(clipboardFonts[2], int.Parse(clipboardFonts[3]));
            }
            else if (slot == 2)
            {
                Clip3.Text = clipboard[2];
                Clip3.Font = new Font(clipboardFonts[4], int.Parse(clipboardFonts[5]));
            }
            else if (slot == 3)
            {
                Clip4.Text = clipboard[3];
                Clip4.Font = new Font(clipboardFonts[6], int.Parse(clipboardFonts[7]));
            }
        }
        private void copyClip(int slot) // copy the clipboard text into the textbox
        {
            ClearEdit();
            EditBox.Text += clipboard[slot];

            EditBox.Font = new Font(clipboardFonts[slot*2], int.Parse(clipboardFonts[slot*2+1]));

            SizeNumeric.Value = decimal.Parse(clipboardFonts[slot * 2 + 1]); //enter the correct number in the selector
            // check the corresponding radio button
            if (clipboardFonts[slot * 2].Equals("Segoe UI"))
            {
                FontButton1.Checked = true;
            }
            if (clipboardFonts[slot * 2].Equals("Showcard Gothic"))
            {
                FontButton2.Checked = true;
            }
            if (clipboardFonts[slot * 2].Equals("Times New Roman"))
            {
                FontButton3.Checked = true;
            }
            if (clipboardFonts[slot * 2].Equals("Montserrat"))
            {
                FontButton4.Checked = true;
            }

            clipboardSlots[slot] = 0;
            clipboard[slot] = "";
            clipboardFonts[slot * 2] = "";
            clipboardFonts[slot * 2 + 1] = "";

        }
        // font changers for all the radiobuttons
        private void FontButton1_CheckedChanged(object sender, EventArgs e)
        {
            font = FontButton1.Text;
            UpdateFont();
        }

        private void FontButton2_CheckedChanged(object sender, EventArgs e)
        {
            font = FontButton2.Text;
            UpdateFont();
        }
        private void FontButton3_CheckedChanged(object sender, EventArgs e)
        {
            font = FontButton3.Text;
            UpdateFont();
        }

        private void FontButton4_CheckedChanged(object sender, EventArgs e)
        {
            font = FontButton4.Text;
            UpdateFont();
        }

        private void SizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            size = (int)SizeNumeric.Value;
            UpdateFont();
        }

        private void EditBox_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter && (EditBox.Text != null && EditBox.Text != "") && EditBox.Font != null)
            {
                int full = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (clipboardSlots[i] == 0)
                    {
                        clipboard[i] = EditBox.Text;
                        clipboardFonts[i * 2] = font.ToString();
                        clipboardFonts[i * 2 + 1] = size.ToString();

                        clipboardSlots[i] = 1;
                        ClearEdit();
                        AddClip(i);
                        break;
                    }
                    full++;
                }
                if (full == 4) // rolling overwrite for the clipboard if all full
                {
                    clipboard[clipIndex] = EditBox.Text;
                    clipboardFonts[clipIndex * 2] = font.ToString();
                    clipboardFonts[clipIndex * 2 + 1] = size.ToString();

                    clipboardSlots[clipIndex] = 1;
                    ClearEdit();
                    AddClip(clipIndex);

                    clipIndex = (clipIndex + 1) % 4; // roll over to the start
                }
            }
        }
        // sending the clipboard data to the textbox
        private void Clip1_DoubleClick(object sender, EventArgs e)
        {
            if (clipboardSlots[0] != 0)
            {
                copyClip(0);
                Clip1.Font = new Font("Agency FB", 9);
                Clip1.Text = "-";
            }
        }

        private void Clip2_DoubleClick(object sender, EventArgs e)
        {
            if (clipboardSlots[1] != 0)
            {
                copyClip(1);
                Clip2.Font = new Font("Agency FB", 9);
                Clip2.Text = "-";
            }
        }

        private void Clip3_DoubleClick(object sender, EventArgs e)
        {
            if (clipboardSlots[2] != 0)
            {
                copyClip(2);
                Clip3.Font = new Font("Agency FB", 9);
                Clip3.Text = "-";
            }
        }

        private void Clip4_DoubleClick(object sender, EventArgs e)
        {
            if (clipboardSlots[3] != 0)
            {
                copyClip(3);
                Clip4.Font = new Font("Agency FB", 9);
                Clip4.Text = "-";
            }
        }
    }
}
