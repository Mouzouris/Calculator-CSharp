using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculator : Form
    {

        string no1 = "";//global variables used to store the 2 operands and the operators
        string op = ""; 
        string no2 = "";     
        bool optr = true;        //bool for the operators (+,-,/,*).
        bool dcml = true;        //boolean for the decimal point (.)
        double sum = 0;              //result.
        
        public Calculator()
        {
            InitializeComponent();
        }

        
        
        private void button0_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textbox input.

            textBox_input.AppendText(button0.Text); //inputs 0 to textBox_input.             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text == "0")  //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textBox_input.

            textBox_input.AppendText(button1.Text); //inputs 1 to textBox_input.
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0")  //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textBox_input.

            textBox_input.AppendText(button2.Text); //inputs 2 to textBox_input.
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textBox_input.

            textBox_input.AppendText(button3.Text); //inputs 3 to textBox_input.
        }

        private void button4_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textBox_input.

            textBox_input.AppendText(button4.Text); //inputs 4 to textBox_input.
        }
        private void button5_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textbox_input.

            textBox_input.AppendText(button5.Text); //inputs 5 to textBox_input.
        }

        private void button6_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textbox_input.

            textBox_input.AppendText(button6.Text); //inputs 6 to textBox_input.
        }

        private void button7_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textbox_input.

            textBox_input.AppendText(button7.Text); //inputs 7 to textBox_input.
        }

        private void button8_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textBox_input.

            textBox_input.AppendText(button8.Text); //inputs 8 to textBox_input.
        }

        private void button9_Click(object sender, EventArgs e) 
        {
            if (textBox_input.Text == "0") //checks if there is a zero in textBox_input.
                textBox_input.Clear();      //clears the textbox_input.

            textBox_input.AppendText(button9.Text); //inputs 9 to textBox_input.
        }

        private void btn_clear_Click(object sender, EventArgs e) //Clears both textboxes and empties variables, also turning booleans to their original state of true and outputs 0 in textBox_input.
        {
            textBox_input.Clear();
            textBox_output.Clear();
            textBox_input.Text = "0";
            optr = true;
            no1 = "";
            op = "";
            no2 = "";
            sum = 0;
            dcml= true;
        }

        private void btn_dp_Click(object sender, EventArgs e) 
        {
            if ((dcml == true) && (textBox_output.Text != "") && (textBox_input.Text == "")) // checks if decimal is true also if textBox_output is not empty which means the sum button is pressed and if textBox_input is empty.
            {
                textBox_input.AppendText("0" + btn_dp.Text); // it then appends the 0 and decimal point (.) and turns the boolean value (dcml) to false.
                dcml = false;
            }

            if (dcml == true) //checks if a decimal point is inserted and if not then it appends the (.) point then turns the boolean value (dcml) to false.
            {
                textBox_input.AppendText(btn_dp.Text);
                dcml = false;
            }   
        }

        private void btn_sub_Click(object sender, EventArgs e) 
        {
            dcml = true;// Re-enables the decimal.

            if (optr == true)//checks if an operator is pressed before & if not outputs (-) also turns the optr to false so that you can't append again.
            {
                textBox_input.AppendText(btn_sub.Text);
                optr = false;
            }
            
            if ((optr == false)) //checks if an operator is pressed. If it is pressed then it performs the button btn_sum.
            {
                btn_sum.PerformClick();
            }

            if ((optr == true) && (textBox_input.Text == "")) //checks if an operator is pressed if not and if the textBox_input is empty it then outputs (-) to be used for further mathematical equations.
               {
                    textBox_input.AppendText(btn_sub.Text);
                   optr = false;
               }

            if ((optr == false) && (textBox_input.Text.Contains("+") || textBox_input.Text.Contains("/") || textBox_input.Text.Contains("*"))) // checks if optr is false & replaces with (-) in input_textbox.
           {
               textBox_input.Text = textBox_input.Text.Replace("+", "-").Replace("/", "-").Replace("*", "-");
           }

        }

        private void btn_add_Click(object sender, EventArgs e) 
        {
            dcml = true; //Re-enabled the decimal point.

            if (optr == true) //checks if an operator is pressed before & if not outputs (+) also turns the optr to false so that you can't append again.
            {
                textBox_input.AppendText(btn_add.Text);
                optr = false;
            }

            if (optr == false) //checks if an operator is pressed. If it is pressed then it performs the button btn_sum.
                {
                btn_sum.PerformClick();
                }

            if ((optr == true) && (textBox_input.Text == "")) //checks if an operator is pressed if not and if the textBox_input is empty it then outputs (+) to be used for further mathematical equations.
                {
                    textBox_input.AppendText(btn_add.Text);
                    optr = false;
                }

            if ((optr == false) && (textBox_input.Text.Contains("/") || textBox_input.Text.Contains("-") || textBox_input.Text.Contains("*"))) // checks if optr is false & replaces with (+) in input_textbox.
            {
                textBox_input.Text = textBox_input.Text.Replace("/", "+").Replace("-", "+").Replace("*", "+");
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)  
        {
            dcml = true; //Re-enables the decimal.

            if (optr == true) //checks if an operator is pressed before & if not outputs (*) also turns the optr to false so that you can't append again.
            {
                textBox_input.AppendText(btn_mult.Text);
                optr = false;
            }

            if (optr == false) //checks if an operator is pressed. If it is pressed then it performs the button btn_sum.
            {
                btn_sum.PerformClick();
            }

            if ((optr == true) && (textBox_input.Text == "")) //checks if an operator is pressed if not and if the textBox_input is empty it then outputs (*) to be used for further mathematical equations.
                {
                   textBox_input.AppendText(btn_mult.Text);
                   optr = false;
                }

            if ((optr == false) && (textBox_input.Text.Contains("+") || textBox_input.Text.Contains("-") || textBox_input.Text.Contains("/"))) // checks if optr is false & replaces with (*) in input_textbox.
            {
                textBox_input.Text = textBox_input.Text.Replace("+", "*").Replace("-", "*").Replace("/", "*");
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            dcml = true; //Re-enables the decimal.

            if (optr == true) //checks if an operator is pressed before & if not outputs (/) also turns the optr to false so that you can't append again.
            {
                textBox_input.AppendText(btn_div.Text);
                optr = false;
            }

            if (optr == false) //checks if an operator is pressed. If it is pressed then it performs the button btn_sum.
            {
                btn_sum.PerformClick();
            }

            if ((optr == true) && (textBox_input.Text == ""))//checks if an operator is pressed if not and if the textBox_input is empty it then outputs (/) to be used for further mathematical equations.
                {
                    textBox_input.AppendText(btn_div.Text);
                    optr = false;
                }

            if ((optr == false) && (textBox_input.Text.Contains("+") || textBox_input.Text.Contains("-") || textBox_input.Text.Contains("*"))) // checks if optr is false & replaces with (/) in input_textbox.
            {
                textBox_input.Text =textBox_input.Text.Replace("+", "/").Replace("-", "/").Replace("*", "/");
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {

            if (optr == false) //only if the operator is pressed ti will perform ay actions of button btn_sum.
            {

                dcml = true; //turns decimals to true so that they cann be used after the sum button

                {
                    string[] hold = textBox_input.Text.Split(' '); //splits the Text of the textbox_input using the spaces I have used on the operators.

                    if ((sum != 0) && (hold[0] == ""))//checks if sum is not 0 and if hold[0] is empty and transfers the sum to no1 to be used for further mathimaticcal equations.
                    {
                        no1 = Convert.ToString(sum);  
                    }

                    else //first equation sum is zero goes through and performs this action normally, if the first equations sum is 0 it will go through here again.
                    {
                        no1 = hold[0]; // for our first equation this is the leftmost numeric value assigned to (no1) before the first space . for our other mathematical operatiosn if sum is 0 (no1) is always empty.
                    }

                    if (no1 == "") //therefore i assigned no1 from empty to 0 so it can carry out the mathematicall equations.
                    {
                        no1 = "0";
                    }
                    if (no1 == ".") // if although the user start the first number of the second equation with a decimal point and presses equals i've assigned it to be 0.0.
                    {
                        no1 = "0.0";
                    }

                    {
                        op = Convert.ToString(hold[1]); // it then finds the operator based on the split with spacing. 
                    }
                  
                    {
                        no2 = hold[2];  // the second space differentiates the 2nd number form the operator and is assigned to (no2).
                    }
                    if (no2 == ".") // if although the user may start the second number with a decimal point and presses equals i've assigned it to be 0.0.
                    {
                        no2 = "0.0";
                    }

                    if (no2 == "") // although if the user inputs just the operator and then presses the sum it performs nothing.
                    { }

                    else
                    {
                        switch (op)//checks which operand exists in the textbox and acts accordingly:
                        {

                            case "+":  //if the operator is a (+) sign it gets the leftmost numeric value and the rightmost numeric value whcih are assigned to (no1) & (no2) and adds them assigning the answer to sum.
                                sum = Convert.ToDouble(no1) + Convert.ToDouble(no2);

                                if (textBox_output.Text == "") //checks if the textBox_output is empty.
                                {
                                    textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                }

                                if ((textBox_output.Text != "") && (hold[0] == "")) //checks if textBox_output is not empty and if hold[0] is empty.
                                { 
                                    textBox_output.Text =textBox_output.Text + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); // if txtbox.output is not empty and hold [0] is empty it then appends only the (+) the no2 and the sum.
                                }                                    
                          
                                if ((textBox_output.Text != "") && (hold[0] != "")) // checks if textBox_output is not emty and if hold[0] is also not empty.
                                {
                                    textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                }                                    
                                    textBox_input.Clear(); //clears textbox_input.
                        
                                break; // breaks the case of (+).

                            case "-": //if the operator is a (-) sign it gets the leftmost numeric value and the rightmost numeric value whcih are assigned to (no1) & (no2) and subtracts the leftmost from the rightmost assigning the answer to sum.
                                sum = Convert.ToDouble(no1) - Convert.ToDouble(no2);

                                if (textBox_output.Text == "") //checks if the textBox_output is empty.
                                {
                                    textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                }

                                if ((textBox_output.Text != "") && (hold[0] == "")) //checks if textBox_output is not empty and if hold[0] is empty.
                                { 
                                    textBox_output.Text =textBox_output.Text + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); // if txtbox.output is not empty and hold [0] is empty it then appends only the (+) the no2 and the sum.
                                }                                    
                          
                                if ((textBox_output.Text != "") && (hold[0] != "")) // checks if textBox_output is not emty and if hold[0] is also not empty.
                                {
                                    textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                }                                    
                                    textBox_input.Clear(); //clears textbox_input.

                                break; // breaks the case of (-).

                            case "*": //if the operator is a (*) sign it gets the leftmost numeric value and the rightmost numeric value whcih are assigned to (no1) & (no2) and multiplies them together assigning the answer to sum.
                                sum = Convert.ToDouble(no1) * Convert.ToDouble(no2);

                                if (textBox_output.Text == "") //checks if the textBox_output is empty.
                                {
                                    textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                }

                                if ((textBox_output.Text != "") && (hold[0] == "")) //checks if textBox_output is not empty and if hold[0] is empty.
                                { 
                                    textBox_output.Text =textBox_output.Text + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); // if txtbox.output is not empty and hold [0] is empty it then appends only the (+) the no2 and the sum.
                                }                                    
                          
                                if ((textBox_output.Text != "") && (hold[0] != "")) // checks if textBox_output is not emty and if hold[0] is also not empty.
                                {
                                    textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                }                                    
                                    textBox_input.Clear(); //clears textbox_input.

                                break; // breaks the case of (*).

                            case "/":

                                if ((no2 == "0") || (no2 == "0.") || (no2 == "0.0")) // checks if the user is deviding by zero outputting an eror message.
                                {
                                    MessageBox.Show("Div/Zero");

                                    btn_clear.PerformClick(); // and then performs the button clear funcctions.
                                }

                                else
                                {
                                    sum = Convert.ToDouble(no1) / Convert.ToDouble(no2); //if the operator is a (/) sign it gets the leftmost numeric value and the rightmost numeric value whcih are assigned to (no1) & (no2) and divides the leftmost from the rightmost value then assigning the answer to sum.
                                    if (textBox_output.Text == "") //checks if the textBox_output is empty.
                                    {
                                        textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                    }

                                    if ((textBox_output.Text != "") && (hold[0] == "")) //checks if textBox_output is not empty and if hold[0] is empty.
                                    {
                                        textBox_output.Text = textBox_output.Text + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); // if txtbox.output is not empty and hold [0] is empty it then appends only the (+) the no2 and the sum.
                                    }

                                    if ((textBox_output.Text != "") && (hold[0] != "")) // checks if textBox_output is not emty and if hold[0] is also not empty.
                                    {
                                        textBox_output.Text = Convert.ToString(no1) + ' ' + Convert.ToString(op) + ' ' + Convert.ToString(no2) + " = " + Convert.ToString(sum); //outputs on the textBox_output the equation and the answer.
                                    }
                                    textBox_input.Clear(); //clears textbox_input.

                                }
                                break;  // breaks the case of (/).

                        }
                        optr = true; //enables the operator to be used after the sum is pressed.
                        dcml = true; //enables the decimal to be used after the sum is pressed.

                    }
                }
            }
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_output_TextChanged(object sender, EventArgs e)
        {
            
            textBox_output.SelectionStart = textBox_output.Text.Length; // makes the cursor to follow the equation.
        }

    }
}
