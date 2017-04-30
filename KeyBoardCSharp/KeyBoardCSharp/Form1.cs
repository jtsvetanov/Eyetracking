using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardCSharp
{
    public partial class Form1 : Form
    {

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


        /// <summary>
        ///Numbers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void buttonNum0_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{0}");
            }
        }

        private void buttonnum1_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{1}");
            }
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{2}");
            }
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{3}");
            }
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{4}");
            }
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{5}");
            }
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{6}");
            }
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{7}");
            }
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{8}");
            }
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{9}");
            }
        }

        private void buttonNumRightSlash_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{/}");
            }
        }

        private void buttonNumMultilication_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{*}");
            }
        }

        private void buttonNumMinus_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{-}");
            }
        }

        private void buttonNumPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxNumLock.Checked)
            {
                SendKeys.Send("{+}");
            }
        }

        private void buttonNumEnter_Click(object sender, EventArgs e)
        {            
                SendKeys.Send("{ENTER}");           
        }

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

        private void buttonScrlLock_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SCROLLLOCK}");
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











        //helpful:

        //SendKeys.Send("{HOME}");
        //SendKeys.Send("{END}");


    }
}
