using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2Cw_Clark0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBubbleSort.Visible = false; //hides the button at the start

            btnLinearSearch.Visible = false;

            btnDrawBars.Visible = false;

            lblSearch.Visible = false;
            txtSearchData.Visible = false;

            lblArrayData.Visible = false;
            txtInput.Visible = false;

            btnShowList.Visible = false;
            btnAddNumber.Visible = false;

            btnArrayHelp.Visible = false;

            lblInput.Visible = false;

            btnStart.Enabled = false;
        }


        private void btnExit_Click(object sender, EventArgs e)  //if the exit button is clicked
        {
            MessageBox.Show("Closing program");     //opens a message box telling the user the program is going to close
            Application.Exit();     //closes the program
        }


        //not currently used. will return to when done with random array side
        private int[] createArray()     //function is called when the user clicks the create array button
        {
            int arraySize = int.Parse(txtArraySize.Text);   //takes the input from the array size text box and converts it to an integer
            int[] arrayData = new int[arraySize];   //sets the array to have the size of what the user specified
            return (arrayData);     //returns the array - will be all 0 when created
        }

        //only array creating function working (18.11.20)
        private int[] createRandomArray()   //function for creating a random array
        {
            int arraySize = int.Parse(txtArraySize.Text);   //sets the size of the array to the number in the array size text box chosen by the user
            int[] arrayData = new int[arraySize];   //creates the array with the size made above
            int min = 1;    //sets min number to 1
            int max = 100;     //sets max number to 100

            Random randNum = new Random();  //initialises the random class
            for (int k = 0; k < arrayData.Length; k++)  //for the length of the array
            {
                arrayData[k] = randNum.Next(min, max);  //generates a random number between 1 and 100 for each position in the array. for example size 4: 3,87,14,8
            }

            return (arrayData);     //returns the new array
        }


        //particularly important as is is used for both user input array and random array
        private void txtArraySize_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;    //temporary variable for parsing statement
            if (txtArraySize.Text == string.Empty)      //if the box is empty
            {
                MessageBox.Show("This box cannot be empty");    //tells the user the box should not be empty empty
                txtArraySize.BackColor = Color.Red;     //changes the box colour to red
                btnAddNumber.Enabled = false; //disables the button
                btnShowList.Enabled = false;
                btnStart.Enabled = false;
            }

            else if (!int.TryParse(txtArraySize.Text, out parsedValue)) //this statement was adapted from: https://stackoverflow.com/questions/15399323/validating-whether-a-textbox-contains-only-numbers - it checks if the text in the box is an not an integer
            {
                MessageBox.Show("This is a whole number only box. Please enter a whole number");  //tells the user they need to enter an integer
                txtArraySize.BackColor = Color.Red;
                btnAddNumber.Enabled = false; //disables the button
                btnShowList.Enabled = false;
                btnStart.Enabled = false;
            }

            else if (int.TryParse(txtArraySize.Text, out parsedValue))
            {
                int arraySize = int.Parse(txtArraySize.Text);
                if (arraySize <= 0 || arraySize > 100)
                {
                    MessageBox.Show("Number must be between 1 and 100");
                    txtArraySize.BackColor = Color.Red;
                    btnAddNumber.Enabled = false; //disables the button
                    btnShowList.Enabled = false;
                    btnStart.Enabled = false;
                }
                else
                {
                    txtArraySize.BackColor = Color.Green;   //changes the box colour to green
                    btnAddNumber.Enabled = true; //enables the button
                    btnShowList.Enabled = true;
                    btnStart.Enabled = true;
                }
            }
        }



        //not used at this stage
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (txtInput.Text == string.Empty)
            {
                MessageBox.Show("This box cannot be empty");
                txtInput.BackColor = Color.Red;
                btnAddNumber.Enabled = false; //disables the button
                btnShowList.Enabled = false;
                btnStart.Enabled = false;
            }

            else if (!int.TryParse(txtInput.Text, out parsedValue))
            {
                MessageBox.Show("This is a whole number only box. Please enter a whole number between 1 and 100");
                txtInput.BackColor = Color.Red;
                btnAddNumber.Enabled = false;
                btnShowList.Enabled = false;
                btnStart.Enabled = false;
            }

            else if (int.TryParse(txtInput.Text, out parsedValue))
            {
                int arrayItem = int.Parse(txtInput.Text);
                if (arrayItem <= 0 || arrayItem > 100)
                {
                    MessageBox.Show("Number must be between 1 and 100");
                    txtInput.BackColor = Color.Red;
                    btnAddNumber.Enabled = false;
                    btnShowList.Enabled = false;
                    btnStart.Enabled = false;
                }

                else
                {
                    txtInput.BackColor = Color.Green;
                    btnAddNumber.Enabled = true; //enables the button
                    btnShowList.Enabled = true;
                    btnStart.Enabled = true;
                }
            }
        }


        //not currently being used. will go back to once random array is done
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == string.Empty)
            {
                MessageBox.Show("Box is empty");
            }
            else
            {
                string displayArray = string.Join(",", updateArray());  //creates a new variable that stores all of the numbers in the array and seperates them with ',' to make it easier to read
                MessageBox.Show(displayArray);  //displays the formatted array

            }
        }


        //not working as intended. need to look into this once random array side is finished
        private int[] updateArray() //this will be used to update the array when the user adds a number
        {

            //int i =0; //variable for array positioning
            int arraySize = int.Parse(txtArraySize.Text); //redefines the array size to the number in the size box
            int[] arrayData = new int[arraySize]; //recreates the array with size specified
            //arrayData[0] = 1; 

            for (int i = 0; i < arraySize; i++)
            {
                while (arrayData[i] != 0)
                {
                    i++;
                }

                arrayData[i] = int.Parse(txtInput.Text);
                i = arraySize;
            }
            return (arrayData);
        }


        //at the moment this only works with the random array due to issues with creating the user array. need to look into passing arrays to functions properly. will come back to that once random array functionality is complete/working sufficiently
        private void btnStart_Click(object sender, EventArgs e)     //when the user presses start
        {
            if (txtArraySize.Text == string.Empty)
            {
                MessageBox.Show("Box is empty");
            }
            else
            {
                // string displayArray = string.Join(",", createRandomArray());  //creates a new variable that stores all of the numbers in the array and seperates them with ',' to make it easier to read
                //MessageBox.Show(displayArray);  //displays the formatted array

                //next section hides all unneccessary parts that won't be used beyond this point


                lblArrayData.Visible = false; //hides the labels
                lblArraySize.Visible = false;
                lblInput.Visible = false;

                txtArraySize.Visible = false; //hides the text boxes
                txtInput.Visible = false;

                btnAddNumber.Visible = false; //hides the buttons
                btnArrayHelp.Visible = false;
                btnShowList.Visible = false;

                btnStart.Visible = false; //hides the start button when you press it

                btnDrawBars.Visible = false;     //shows the draw bars button as that option can now be used --keeps false for now

                btnBubbleSort.Visible = true; //shows the bubble sort button as that option can now be used
                btnLinearSearch.Visible = true; ////shows the linear search button as that option can now be used

                lblSearch.Visible = true;
                txtSearchData.Visible = true;

                btnStart.Visible = false;

                lblhelp.Visible = false;
            }

        }


        //not used at this point. will return to once random array side is done
        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (txtArraySize.Text == string.Empty)
            {
                MessageBox.Show("Box is empty");
            }
            else
            {
                string displayArray = string.Join(",", createArray());  //creates a new variable that stores all of the numbers in the array and seperates them with ',' to make it easier to read
                MessageBox.Show(displayArray);  //displays the formatted array
            }
        }


        //not used at this point because development of the random array side doesn't involve arrayData. array size is still used
        private void btnArrayHelp_Click(object sender, EventArgs e)     //when the user presses the help button
        {
            MessageBox.Show("This is where you can find help on how to create your own array (list) \nFirst you should enter a number between 1 and 100 in the text box marked array size. Please make sure you enter in a number and nothing else or the program won't work. \nNext enter in the numbers you want to add to your array in the array data text box. Enter them in one by one, pressing add number to list after each one. \nYou can see what the array will look like at any point by pressing the show list button. If there is no data in the array then pressing show list will bring up '0' as the items.");
        }


        //not working code

        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics line = e.Graphics;
        //    Pen pen = new Pen(Color.Red, 2);
        //    line.DrawLine(pen, 50, 50, 50, 200);
        //    line.Dispose();
        //}

        //still in development (18.11.20) -
        private void btnDrawBars_Click(object sender, EventArgs e) //draws a bar when the button is clicked
        {
            //int Min = 1;      //used for testing random line lengths  
            //int Max = 100;

            //Random randNum = new Random();

            //int x1 = randNum.Next(Min, Max);
            //int y1 = randNum.Next(Min, Max);
            //int x2 = randNum.Next(Min, Max);
            //int y2 = randNum.Next(Min, Max);


            drawBars(createRandomArray()); //issue with this is that you will always get a new random array. need to look into passing arrays more. (18.11.20)
        }

        private void drawBars(int[] arrayData)
        {
            Graphics line = CreateGraphics();       //adapted from https://www.homeandlearn.co.uk/extras/graphics/graphics-paint-event.html
            Pen pen = new Pen(Color.White, 1);      //creates the pen with colour white and width 2

            Point a = new Point(100, 100);  //sets co-ords of first point (x,y)
            Point b = new Point(100, 500);  //sets co-ords of second point (x,y)

            line.DrawLine(pen, a, b);

            line.DrawLine(pen, 50, 50, 50, 200);
            line.DrawLine(pen, 60, 60, 60, 200);
            line.DrawLine(pen, 70, 70, 70, 200);
            line.DrawLine(pen, 80, 80, 80, 200);
            line.DrawLine(pen, 90, 90, 90, 200);
            line.Dispose();

            string displayArray = string.Join(",", arrayData);  //creates a new variable that stores all of the numbers in the array and seperates them with ',' to make it easier to read
            MessageBox.Show(displayArray);  //displays the formatted array
        }


        //private int [] test()
        //{
        //    int arraySize = int.Parse(txtArraySize.Text);
        //    int[] arrayData = new int[arraySize];
        //    int Min = 1;
        //    int Max = 100;

        //    Random randNum = new Random();
        //    for (int k = 0; k < arrayData.Length; k++)
        //    {
        //        arrayData[k] = randNum.Next(Min, Max);
        //    }

        //    return (arrayData);
        //}


        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] arrayData = createRandomArray();

            bubbleSort(arrayData);
        }

        private void bubbleSort(int[] arrayData)
        {
            int temp;   //temporary value used for swapping two values
            string displayArray = string.Join(",", arrayData);
            MessageBox.Show("Unsorted array is " + displayArray);

            for (int i = 0; i < arrayData.Length - 1; i++) //loop will repeat as many times as length of array -1
            {
                for (int j = 0; j < arrayData.Length - 1; j++) //loop will repeat as many times as length of array -1
                {
                    if (arrayData[j] > arrayData[j + 1])    //if first number is larger than second number
                    {
                        temp = arrayData[j];    //sets temp to the first (larger) number
                        arrayData[j] = arrayData[j + 1];     //sets the first number to the second (smaller) number
                        arrayData[j + 1] = temp;    //sets the second number to the temp number (first number) which comletes the swap

                        displayArray = string.Join(",", arrayData);
                        MessageBox.Show("Sorting: " + displayArray);
                    }
                }
            }

            MessageBox.Show("The sorted array is " + displayArray);     //shows the (hopefully) sorted array
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchData.Text == string.Empty)
            {
                MessageBox.Show("Box is empty");
            }

            int[] arrayData = createRandomArray();
            linearSearch(arrayData);
        }

        private void linearSearch(int[] arrayData)
        {

            int search = int.Parse(txtSearchData.Text);     //sets the variable used to hold what we search for to the number the user put in the text box specified

            string displayArray = string.Join(",", arrayData); //formats the array to a single string
            MessageBox.Show("searching for: " + search + " in "+displayArray);  //tells the user what they are searching for and what the array is

            bool found = false;     //sets found to false
            for (int i=0; i<arrayData.Length; i++)  //for length of the array
            {
                if (arrayData[i] == search)     //if the current position holds the number we are looking for
                {
                    found = true;   //sets found to true
                    MessageBox.Show("found "+search + " at position "+ i);  //tells the user the number has been found along wih its position
                }
            }
            if (found == false)     //if found is false
            {
                MessageBox.Show(search + " not found");     //tells the user the number was not found
            }

        }

        private void txtSearchData_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;    //temporary variable for parsing statement
            if (txtSearchData.Text == string.Empty)      //if the box is empty
            {
                MessageBox.Show("This box cannot be empty");    //tells the user the box should not be empty empty
                txtSearchData.BackColor = Color.Red;     //changes the box colour to red
                btnLinearSearch.Enabled = false;
            }

            else if (!int.TryParse(txtSearchData.Text, out parsedValue))
            {
                MessageBox.Show("This is a whole number only box. Please enter a whole number");  //tells the user they need to enter an integer
                txtSearchData.BackColor = Color.Red;
                btnLinearSearch.Enabled = false;

            }

            else if (int.TryParse(txtSearchData.Text, out parsedValue))
            {
                int searchData = int.Parse(txtSearchData.Text);
                if (searchData <= 0 || searchData > 100)
                {
                    MessageBox.Show("Number must be between 1 and 100");
                    txtSearchData.BackColor = Color.Red;
                    btnLinearSearch.Enabled = false;

                }
                else
                {
                    txtSearchData.BackColor = Color.Green;   //changes the box colour to green
                    btnLinearSearch.Enabled = true;
                    
                }
            }
        }

        private void lblInput_Click(object sender, EventArgs e)
        {

        }

        private void lblhelp_Click(object sender, EventArgs e)
        {

        }
    }
}
