using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Astronomical_Processing2
{
    public partial class AstroForm : Form
    {
        public AstroForm()
        {
            InitializeComponent();
        }
        // Display the array value
        static int arraySize = 24;
        int[] theArray = new int[arraySize];
        Random r = new Random();
        int nextEmptyNumber = 0;
        
        private void DisplayArray()
        {
            ListBoxArrayList.Items.Clear();
            for (int x = 0; x < nextEmptyNumber; x++)
            {
                ListBoxArrayList.Items.Add(theArray[x]);
            }
        }
        private void FillArray()
        {
            for (int x = 0; x < arraySize; x++)
            {
                theArray[x] = r.Next(10, 99);
                ListBoxArrayList.Items.Add(theArray[x]);
            }
            nextEmptyNumber = 24;
            DisplayArray();         
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            // Pressing sort first or after using the add button first turns numbers into 0
            int temp = 0;
            for (int i = 0; i < nextEmptyNumber; i++)
            {
                for (int j = 0; j < nextEmptyNumber - 1; j++)
                {
                    if (theArray[j] > theArray[j + 1])
                    {
                        temp = theArray[j + 1];
                        theArray[j + 1] = theArray[j];
                        theArray[j] = temp;
                    }
                    DisplayArray();
                    Application.DoEvents();
                    Thread.Sleep(0);                      
                    
                }
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Binary search
            int target;
            int lowbound = 0;
            int highbound = nextEmptyNumber - 1;//max is one less than size
            if (!(int.TryParse(TextBoxSearch.Text, out target)))
            {  //A message appears when the condition hasn't made
                MessageBox.Show("Please enter an interger.");
                return;
            }

            while (lowbound <= highbound)
            {
                int mid = (lowbound + highbound) / 2;  //Finding the mid point
                //Trace.TraceInformation("Mid {0}", mid); //output Trace information
                if (target == theArray[mid])
                {   //When the search value has been found
                    Trace.TraceInformation("Mid {0} Number {1} ", mid, theArray[mid]);
                    MessageBox.Show("The target has been found at index: " + mid);
                    TextBoxSearch.Clear();
                    TextBoxSearch.Focus();
                    return;
                }
                else if (target < theArray[mid])
                {
                    highbound = mid - 1;
                    Trace.TraceInformation("Highbound {0}", highbound); //output Trace information
                }
                else
                {
                    lowbound = mid + 1;
                    Trace.TraceInformation("Lowbound {0} ", lowbound); //output Trace information
                }
            }
            MessageBox.Show("The target can not be found.");
            TextBoxSearch.Clear();
            TextBoxSearch.Focus();
            return;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Method of adding a value to the listbox in the empty textbox
            if (!string.IsNullOrEmpty(TextBoxSearch.Text) && (nextEmptyNumber < 24))
            {
                {
                    int key = int.Parse(TextBoxSearch.Text);
                    if (key >= 100)
                    {
                        MessageBox.Show("Please enter an integer below 100");
                        return;
                    }

                    theArray[nextEmptyNumber] = int.Parse(TextBoxSearch.Text);
                    nextEmptyNumber++;
                    DisplayArray();
                    TextBoxSearch.Clear();
                    TextBoxSearch.Focus();
                }
            }

            if (nextEmptyNumber >= arraySize)
            {
                MessageBox.Show("You have hit the limit");
                return;
            }

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (ListBoxArrayList.SelectedIndex != -1)
            {
                {
                    int key = int.Parse(TextBoxSearch.Text);
                    if (key >= 100)
                    {
                        MessageBox.Show("Please enter an integer below 100");
                        return;
                    }

                    string item = ListBoxArrayList.SelectedItem.ToString();
                    int index = ListBoxArrayList.FindString(item);
                    theArray[index] = int.Parse(TextBoxSearch.Text);
                }
            }

            else
            {
                MessageBox.Show("Please select a number");
            }
            DisplayArray();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            {

                if (ListBoxArrayList.SelectedIndex != -1)
                {
                    //Select an item from the list box, and find the index of the item.
                    string item = ListBoxArrayList.SelectedItem.ToString();
                    int index = ListBoxArrayList.FindString(item);
                    nextEmptyNumber--;

                    for (int i = 0; i < nextEmptyNumber; i++)
                    {
                        //Selected index equals theArray[i], which means theArray[i] is empty. 
                        if (theArray[index] == theArray[i])
                        {
                            for (int j = i; j < nextEmptyNumber; j++)
                            {
                                //theArray[i]=theArray[j] now. Put the latter index in the former position.
                                theArray[j] = theArray[j + 1];
                            }
                        }
                    }

                    DisplayArray();
                }

                else
                {
                    MessageBox.Show("Error. Select an item from the list box");
                }
            }
        }
        private void buttonFill_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < arraySize; x++)
            {
                theArray[x] = r.Next(10, 99);
                ListBoxArrayList.Items.Add(theArray[x]);
            }
            FillArray();
        }
        private void buttonSequential_Click(object sender, EventArgs e)
        {
            // Searches through the values one by one till a match is found
            int target;
            bool found = false;
            if(!(Int32.TryParse(TextBoxSearch.Text, out target)))
            {
                MessageBox.Show("Enter an integer");
                return;
            }
            ListBoxArrayList.Items.Clear();
            for (int x = 0; x < arraySize; x++)
            {
                ListBoxArrayList.Items.Add(x + " [ " + theArray[x] + " ] ");
                Trace.TraceInformation("Index {0} Number {1} ", x, theArray[x]);//output Trace information
                if (theArray[x] == target)
                {
                    
                    ListBoxArrayList.Items.Add("Found at index " + x);
                    MessageBox.Show("Index has been found at " + x);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                //Trace.TraceInformation("Target {0} Found {1} ", target, found);
                MessageBox.Show("Not found");
            }
        }
        public void buttonMean_Click(object sender, EventArgs e)
        {            
            double maxValue = 0;
            double minValue = 100;
            maxValue = FindMax(theArray);
            minValue = FindMin(theArray);
            // Calculating the max and min value received from the method
            textMean.Text = ((maxValue + minValue) / 2).ToString();
            Trace.TraceInformation("Max value plus Min value {0}", maxValue + minValue);
            Trace.TraceInformation("Divided value {0}", (maxValue + minValue) / 2); //output Trace information
        }
        public int Mean(int x, int y)
        {
            int result = ((x + y) / 2);
            return result;
        }
        static private int FindMax(int[] theArray)
        {
            //Finds the max value from the array list
            int max = 0;
            for (int x = 0; x < theArray.Length; x++)
            {
                if (theArray[x] >= max)
                    max = theArray[x];
            }
            return max;
        }
        static private int FindMin(int[] theArray)
        {
            //Finds the min value from the array list
            int min = 100;
            for (int x = 0; x < theArray.Length; x++)
            {
                if (theArray[x] <= min)
                    min = theArray[x];
            }
            return min;
        }
        public void buttonRange_Click(object sender, EventArgs e)
        {
            int bigValue = 0;
            int smallValue = 100;
            bigValue = FindMax(theArray);
            smallValue = FindMin(theArray);
            //Calculating the difference between the max and min value received from the method
            textRange.Text = (bigValue - smallValue).ToString();
            Trace.TraceInformation("Big value {0} Small value{1}", bigValue, smallValue);
            Trace.TraceInformation("Range {0}", bigValue - smallValue);
        }
        public int Range(int x, int y)
        {
            int result = (x -y);
            return result;
        }
        public void buttonMode_Click(object sender, EventArgs e)
        {
            //Shows the most frequent appearing variable in the array list
            for (int i = 0; i < nextEmptyNumber; i++)
            {
                int element;
                int frequency = 1;
                int mode = 0;
                int counter;

                for (int x = 0; x < nextEmptyNumber; x++)
                {
                    counter = 0;
                    element = theArray[x];
                    for (int y = 0; y < nextEmptyNumber; y++)
                    {
                        if (theArray[y] == element)
                        {
                          
                            counter++;
                        }
                    }
                    if (counter >= frequency)
                    {
                        frequency = counter;
                        mode = element;
                    }
                }
                textMode.Text = "v: " + mode + " f: " + frequency.ToString();
                
            }
        }
        public void buttonAverage_Click(object sender, EventArgs e)   
        {
            // Adds up all numbers in the array list then divides depending on how many values are in the list
            for (int i = 0; i < nextEmptyNumber; i++)
                Trace.TraceInformation("Numbers {0} Index{1}", i, theArray[i]);
            {
               
                double sum = 0;
                double average;

                for (int x = 0; x < nextEmptyNumber; x++)
                    sum = sum + theArray[x];
                average = sum / nextEmptyNumber;
                textAverage.Text = average.ToString();
                Trace.TraceInformation("Average {0}", average);
            }
            
        }
        public int Average(int x, int y)
        {
            int result = (x / y);
            return result;
        }
        private void ListBoxArrayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selecting a value from the listbox will show in the textbox search box
            if (ListBoxArrayList.SelectedItem != null)
            {
                TextBoxSearch.Text = ListBoxArrayList.SelectedItem.ToString();
            }
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevents characters from being typed into the textbox 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numeric values");
                e.Handled = true;
            }
        }
    }
}
