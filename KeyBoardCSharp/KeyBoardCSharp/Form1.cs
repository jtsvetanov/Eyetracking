using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Coords For the array of buttons
 * Q(0,0)    W   E   R   T   Y   U   I   O   P
 * A(1,0)    S   D   F   G   H   J   K   L   ;
 * Z(2,0)   X   C   V   B   N   M   ,   .   /(2,9)
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
namespace KeyBoardCSharp
{
    public partial class Form1 : Form
    {
        public int bWidth = 10;
        public int bHeight = 3;
        public Button[,] myButtonArray;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                    param.ExStyle |= 0x08000000;
                return param;
            }
        }
        public Form1()
        {
            InitializeComponent();
            
            myButtonArray = new Button[,] { { this.buttonQ, this.buttonW, this.buttonE, this.buttonR, this.buttonT, this.buttonY, this.buttonU, this.buttonI, this.buttonO, this.buttonP }, { this.buttonA, this.buttonS, this.buttonD, this.buttonF, this.buttonG, this.buttonH, this.buttonJ, this.buttonK, this.buttonL, this.buttonColon }, { this.buttonZ, this.buttonX, this.buttonC, this.buttonV, this.buttonB, this.buttonN, this.buttonM, this.buttonLessThen, this.buttonGreaterThen, this.buttonQuestionMarkSlash } };
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("Q");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;

            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void sizeChangeNeighbor(int x, int y, int direction)
        {
            myButtonArray[y, x].Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            myButtonArray[y, x].BringToFront();
            myButtonArray[y, x].Size = new Size(myButtonArray[y, x].Size.Width + (25 * direction), myButtonArray[y, x].Size.Height + (25 * direction));
            if (x - 1 >= 0)//left
            {
                myButtonArray[y, x - 1].Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                myButtonArray[y, x - 1].BringToFront();
                myButtonArray[y, x - 1].Size = new Size(myButtonArray[y, x-1].Size.Width + (25 * direction), myButtonArray[y, x-1].Size.Height + (25 * direction));
                myButtonArray[y, x - 1].Location = new Point(myButtonArray[y, x - 1].Location.X - 25*direction, myButtonArray[y, x - 1].Location.Y);
            }
            if (x + 1 < bWidth)//right
            {
                myButtonArray[y, x + 1].Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                myButtonArray[y, x + 1].BringToFront();
                myButtonArray[y, x + 1].Size = new Size(myButtonArray[y, x+1].Size.Width + (25 * direction), myButtonArray[y, x+1].Size.Height + (25 * direction));
                myButtonArray[y, x + 1].Location = new Point(myButtonArray[y, x + 1].Location.X + 25 * direction, myButtonArray[y, x + 1].Location.Y);
            }
            if (y - 1 >= 0) //up
            {
                myButtonArray[y - 1, x].Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                myButtonArray[y - 1, x].BringToFront();
                myButtonArray[y - 1, x].Size = new Size(myButtonArray[y - 1, x].Size.Width + (25 * direction), myButtonArray[y - 1, x].Size.Height + (25 * direction));
                myButtonArray[y - 1, x].Location = new Point(myButtonArray[y - 1, x].Location.X, myButtonArray[y - 1, x].Location.Y - 25 * direction);
            }
            if (y + 1 < bHeight)//down
            {
                myButtonArray[y + 1, x].Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                myButtonArray[y + 1, x].BringToFront();
                myButtonArray[y + 1, x].Size = new Size(myButtonArray[y + 1, x].Size.Width + (25 * direction), myButtonArray[y + 1, x].Size.Height+(25*direction));
                myButtonArray[y + 1, x].Location = new Point(myButtonArray[y + 1, x].Location.X, myButtonArray[y + 1, x].Location.Y + 25 * direction);
            }

        }

        private void buttonQ_MouseEnter(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonQ_MouseLeave(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("W");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void buttonW_MouseEnter(object sender, EventArgs e)
        {
            int x = 1;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonW_MouseLeave(object sender, EventArgs e)
        {
            int x = 1;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("E");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void buttonE_MouseEnter(object sender, EventArgs e)
        {
            int x = 2;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonE_MouseLeave(object sender, EventArgs e)
        {
            int x = 2;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("R");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void buttonR_MouseEnter(object sender, EventArgs e)
        {
            int x = 3;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonR_MouseLeave(object sender, EventArgs e)
        {
            int x = 3;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("T");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void buttonT_MouseEnter(object sender, EventArgs e)
        {
            int x = 4;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonT_MouseLeave(object sender, EventArgs e)
        {
            int x = 4;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("Y");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void buttonY_MouseEnter(object sender, EventArgs e)
        {
            int x = 5;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonY_MouseLeave(object sender, EventArgs e)
        {
            int x = 5;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("U");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void buttonU_MouseEnter(object sender, EventArgs e)
        {
            int x = 6;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonU_MouseLeave(object sender, EventArgs e)
        {
            int x = 6;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("I");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void buttonI_MouseEnter(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonI_MouseLeave(object sender, EventArgs e)
        {
            int x = 7;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("O");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void buttonO_MouseEnter(object sender, EventArgs e)
        {
            int x = 8;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonO_MouseLeave(object sender, EventArgs e)
        {
            int x = 8;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("P");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void buttonP_MouseEnter(object sender, EventArgs e)
        {
            int x = 9;
            int y = 0;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonP_MouseLeave(object sender, EventArgs e)
        {
            int x = 9;
            int y = 0;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("A");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void buttonA_MouseEnter(object sender, EventArgs e)
        {
            int x = 0;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonA_MouseLeave(object sender, EventArgs e)
        {
            int x = 0;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("S");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void buttonS_MouseEnter(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonS_MouseLeave(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("F");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
            }
        }
        private void buttonF_MouseEnter(object sender, EventArgs e)
        {
            int x = 3;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonF_MouseLeave(object sender, EventArgs e)
        {
            int x = 3;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("G");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void buttonG_MouseEnter(object sender, EventArgs e)
        {
            int x = 4;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonG_MouseLeave(object sender, EventArgs e)
        {
            int x = 4;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("H");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
            }
        }
        private void buttonH_MouseEnter(object sender, EventArgs e)
        {
            int x = 5;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonH_MouseLeave(object sender, EventArgs e)
        {
            int x = 5;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("J");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void buttonJ_MouseEnter(object sender, EventArgs e)
        {
            int x = 6;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonJ_MouseLeave(object sender, EventArgs e)
        {
            int x = 6;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("K");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void buttonK_MouseEnter(object sender, EventArgs e)
        {
            int x = 7;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonK_MouseLeave(object sender, EventArgs e)
        {
            int x = 7;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("L");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void buttonL_MouseEnter(object sender, EventArgs e)
        {
            int x = 8;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonL_MouseLeave(object sender, EventArgs e)
        {
            int x = 8;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("Z");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void buttonZ_MouseEnter(object sender, EventArgs e)
        {
            int x = 0;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonZ_MouseLeave(object sender, EventArgs e)
        {
            int x = 0;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("X");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void buttonX_MouseEnter(object sender, EventArgs e)
        {
            int x = 1;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonX_MouseLeave(object sender, EventArgs e)
        {
            int x = 1;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("C");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void buttonC_MouseEnter(object sender, EventArgs e)
        {
            int x = 2;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonC_MouseLeave(object sender, EventArgs e)
        {
            int x = 2;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("V");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void buttonV_MouseEnter(object sender, EventArgs e)
        {
            int x = 3;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonV_MouseLeave(object sender, EventArgs e)
        {
            int x = 3;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("B");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void buttonB_MouseEnter(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonB_MouseLeave(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("N");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void buttonN_MouseEnter(object sender, EventArgs e)
        {
            int x = 5;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonN_MouseLeave(object sender, EventArgs e)
        {
            int x = 5;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("M");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void buttonM_MouseEnter(object sender, EventArgs e)
        {
            int x = 6;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonM_MouseLeave(object sender, EventArgs e)
        {
            int x = 6;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("D");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void buttonD_MouseEnter(object sender, EventArgs e)
        {
            int x = 2;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonD_MouseLeave(object sender, EventArgs e)
        {
            int x = 2;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonCurlyBracketOpen_Click(object sender, EventArgs e)
        {
            if(checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{{}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void buttonCurlyBracketClose_Click(object sender, EventArgs e)
        {
            if (checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{}}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("]");
            }

        }
    //
   //Implementation of Enter, esc, Fs
   //
   
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void buttonEsc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        //setting up all function keys
        private void buttonF1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void buttonF3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void buttonF4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void buttonF5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void buttonF6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void buttonF7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void buttonF8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void buttonF9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void buttonF10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void buttonF11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void buttonF12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void buttonPrntScr_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

    
        private void buttonPageUp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void buttonPageDown_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");            
        }



        private void buttonTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void buttonLessThen_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("<");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void buttonLessThen_MouseEnter(object sender, EventArgs e)
        {
            int x = 7;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonLessThen_MouseLeave(object sender, EventArgs e)
        {
            int x = 7;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }



        private void buttonGreaterThen_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send(">");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void buttonGreaterThen_MouseEnter(object sender, EventArgs e)
        {
            int x = 8;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonGreaterThen_MouseLeave(object sender, EventArgs e)
        {
            int x = 8;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonQuestionMarkSlash_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("?");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{/}");
            }
        }

        private void buttonQuestionMarkSlash_MouseEnter(object sender, EventArgs e)
        {
            int x = 9;
            int y = 2;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonQuestionMarkSlash_MouseLeave(object sender, EventArgs e)
        {
            int x = 9;
            int y = 2;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonColon_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send(":");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send(";");
            }
        }

        private void buttonColon_MouseEnter(object sender, EventArgs e)
        {
            int x = 9;
            int y = 1;
            sizeChangeNeighbor(x, y, 1);

        }
        private void buttonColon_MouseLeave(object sender, EventArgs e)
        {
            int x = 9;
            int y = 1;
            sizeChangeNeighbor(x, y, -1);
        }

        private void buttonQuotesComaRight_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("\"");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("'");
            }
        }

        private void buttonVerticalBarRigthSlash_Click(object sender, EventArgs e)
        {

            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("|");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("\\");
            }
        }

        private void buttonTildeComma_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{~}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("`");
            }
        }

        private void buttonNumOne_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("!");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void buttonNumTwo_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("@");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }
        }

        private void buttonNumThree_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("#");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
            }
        }

        private void buttonNumFour_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("$");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
            }
        }

        private void buttonNumFive_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{%}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
            }
        }

        private void buttonNumSix_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{^}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
            }
        }

        private void buttonNumSeven_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("&");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
            }
        }

        private void buttonNumEight_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{*}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
            }
        }

        private void buttonNUmNine_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{(}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
            }
        }

        private void buttonNumZero_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{)}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("_");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{+}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("=");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
         
            SendKeys.Send("{DELETE}");
        
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      int x = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
      int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
      this.Location = new Point(x, y);
      this.TopMost = true;
      this.Opacity = 0.9;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Visible = false;
    }

    private void checkBoxRightShift_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void buttonStartRight_Click(object sender, EventArgs e)
    {

    }

    private void buttonCtrlRight_Click(object sender, EventArgs e)
    {

    }

    private void buttonAltRight_Click(object sender, EventArgs e)
    {

    }

    private void buttonAltLeft_Click(object sender, EventArgs e)
    {

    }

    private void buttonStartLeft_Click(object sender, EventArgs e)
    {

    }

    private void checkBoxCtrlLeft_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBoxLeftShift_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBoxCapLock_CheckedChanged(object sender, EventArgs e)
    {

    }

 


        //helpful:

        //SendKeys.Send("{HOME}");
        //SendKeys.Send("{END}");


    }
}
