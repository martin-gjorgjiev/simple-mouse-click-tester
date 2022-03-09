namespace simple_mouse_click_tester
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            richTextBox1.MouseWheel += richTextBox1_MouseWheel;
            richTextBox1.Text = "Simple mouse click tester that is indended for personal use." +
                "\nFeatures:" +
                "\n#1. Three modes for testing: Realtime, Highlight and Double Click mode." +
                "\n#2. Continuity test: Select RT mode, hold down the desired click and check if the mouse click counter increases." +
                "\n#3. Scroll test:Select HL mode, scroll in one direction and check if it highlights the scroll in the other direction." +
                "\n#4. Simultaneous click test: Select RT mode, press combinations of clicks (especially LMB+MB3 and MMB+MB4 if your mouse has MB3 and 4) and check if they both highlight at the same time." +
                "\n#5. Double click test: Select DC mode and perform single clicks to check if the mouse would perform a faulty doubleclick or check if you can perform double clicks" +
                " with that mouse. Works for all buttons and the click counter only records the number of double clicks.\n When you are testing the mouse keep the mouse within this textbox.";


            //richTextBox1.DoubleClick += richTextBox1_DoubleClick; //experimental
        }

        private bool singleClick;
        
        //handle which button needs to be highlighted and what label needs to be updated, for the clicks
        public void HandleHighlight(MouseEventArgs a)
        {
            if (a.Button == MouseButtons.Left)
            {
                leftMB.BackColor = Color.Blue;
                leftLbl.Text = Convert.ToString(Convert.ToInt32(leftLbl.Text) + 1);
            }
            if (a.Button == MouseButtons.Middle)
            {
                middleMB.BackColor = Color.Blue;
                middleLbl.Text = Convert.ToString(Convert.ToInt32(middleLbl.Text) + 1);
            }
            if (a.Button == MouseButtons.Right)
            {
                rightMB.BackColor = Color.Blue;
                rightLbl.Text = Convert.ToString(Convert.ToInt32(rightLbl.Text) + 1);
            }
            if (a.Button == MouseButtons.XButton1)
            {
                threeMB.BackColor = Color.Blue;
                threeLbl.Text = Convert.ToString(Convert.ToInt32(threeLbl.Text) + 1);
            }
            if (a.Button == MouseButtons.XButton2)
            {
                fourMB.BackColor = Color.Blue;
                fourLbl.Text = Convert.ToString(Convert.ToInt32(fourLbl.Text) + 1);
            }
        }

        //for scrollling
        private void richTextBox1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (timer1.Enabled)
            {
                timer1.Stop();
            }

            //int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            if (realtimeRB.Checked || highlightRB.Checked)
            {
                if ((e.Delta * SystemInformation.MouseWheelScrollLines / 120) > 0)
                {
                    scrollU.BackColor = Color.Blue;
                }
                if ((e.Delta * SystemInformation.MouseWheelScrollLines / 120) < 0)
                {
                    scrollD.BackColor = Color.Blue;
                }
            }            

            if (realtimeRB.Checked)
            {
                timer1.Start();
            }
        }

        //double click experimental
        /*private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click!");
        }*/

        //when you click
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (realtimeRB.Checked||highlightRB.Checked)
            {
                HandleHighlight(e);                
            }

            if (doubleClickRB.Checked)
            {
                if (!singleClick)
                {
                    timer2.Start();
                    singleClick=true;                   
                }
                else
                {
                    HandleHighlight(e);
                    singleClick=false;
                }
                
            }

            //in case you need to troubleshoot which button was pressed
            //richTextBox1.Text+=" "+Convert.ToString(e.Button);
        }

        //when you release the click
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (realtimeRB.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    leftMB.BackColor = Control.DefaultBackColor;
                }
                if (e.Button == MouseButtons.Middle)
                {
                    middleMB.BackColor = Control.DefaultBackColor;
                }
                if (e.Button == MouseButtons.Right)
                {
                    rightMB.BackColor = Control.DefaultBackColor;
                }
                if (e.Button == MouseButtons.XButton1)
                {
                    threeMB.BackColor = Control.DefaultBackColor;
                }
                if (e.Button == MouseButtons.XButton2)
                {
                    fourMB.BackColor = Control.DefaultBackColor;
                }
                /* switch alternative, deemed flawed
                switch (e.Button)
                {
                    case MouseButtons.Left: leftMB.BackColor = Control.DefaultBackColor; 
                        break;
                    case MouseButtons.Middle: middleMB.BackColor = Control.DefaultBackColor;
                        break;
                    case MouseButtons.Right: rightMB.BackColor = Control.DefaultBackColor;
                        break;
                    case MouseButtons.XButton1: threeMB.BackColor = Control.DefaultBackColor;
                        break;
                    case MouseButtons.XButton2: fourMB.BackColor = Control.DefaultBackColor;
                        break;
                }*/
            }
        }

        //clear fields
        private void clearBtn_Click(object sender, EventArgs e)
        {
            leftMB.BackColor = Control.DefaultBackColor;
            middleMB.BackColor = Control.DefaultBackColor;
            rightMB.BackColor = Control.DefaultBackColor;
            threeMB.BackColor = Control.DefaultBackColor;
            fourMB.BackColor = Control.DefaultBackColor;
            scrollU.BackColor = Control.DefaultBackColor;
            scrollD.BackColor = Control.DefaultBackColor;
            leftLbl.Text = "0";
            middleLbl.Text = "0";
            rightLbl.Text = "0";
            threeLbl.Text = "0";
            fourLbl.Text = "0";
        }

        //simple way to clear out the scroll buttons when it stops scrolling
        private void timer1_Tick(object sender, EventArgs e)
        {
            scrollU.BackColor = Control.DefaultBackColor;
            scrollD.BackColor = Control.DefaultBackColor;
            timer1.Stop();          
        }

        //to accomodate the doubleclick mode
        private void doubleClickRB_CheckedChanged(object sender, EventArgs e)
        {
            if (doubleClickRB.Checked)
            {
                singleClick = false;
                timer2.Interval = SystemInformation.DoubleClickTime;
            }
            else
            {
                if(timer2.Enabled)
                timer2.Stop();
                clearBtn.PerformClick();
            }
        }

        //reset timer if there is no doubleclick
        private void timer2_Tick(object sender, EventArgs e)
        {
            singleClick = false;
            timer2.Stop();
        }

        //reset highlights when out of highlight mode
        private void highlightRB_CheckedChanged(object sender, EventArgs e)
        {
            clearBtn.PerformClick();
        }
    }
}