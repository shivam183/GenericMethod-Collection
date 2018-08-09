using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericLinearSearchMethodTestForm
{
    public partial class GenericLinearSearchMethodTestForm : Form
    {
        Random rng = new Random();
        int[] generatedIntArray = null;
        double[] generatedDoubleArray = null;
        public GenericLinearSearchMethodTestForm()
        {
            InitializeComponent();
        }

        private void generateIntArrayBtn_Click(object sender, EventArgs e)
        {
            //Clears the double array before creating an int array
            generatedDoubleArray = null;
            searchKeyTb.Clear();
            searchBtn.Enabled = clearBtn.Enabled = false;

            //validate to ensure numeric input
            try
            {
                int arraySize = int.Parse(numOfEleTb.Text);
                generatedIntArray = new int[arraySize];
                searchBtn.Enabled = clearBtn.Enabled = false;

                for (int i = 0; i < arraySize; i++)
                {
                    generatedIntArray[i] = rng.Next(1000);   
                }

                //Display in the 'Generated' section of the UI
                generatedArrayListBox.Items.Clear();
                foreach (var @int in generatedIntArray)
                {
                    generatedArrayListBox.Items.Add(@int);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a positive integer in the 'Number of Elements' text box.", "Error - Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateDoubleArrayBtn_Click(object sender, EventArgs e)
        {
            //Clears the int array before creating an double array
            generatedIntArray = null;
            searchKeyTb.Clear();
            searchBtn.Enabled = clearBtn.Enabled = false;

            //validate to ensure numeric input
            try
            {
                int arraySize = int.Parse(numOfEleTb.Text);
                generatedDoubleArray = new double[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    //round to 3 decimal places
                    generatedDoubleArray[i] = Math.Round(rng.NextDouble(), 3);
                }

                //Display in the 'Generated' section of the UI
                generatedArrayListBox.Items.Clear();
                foreach (var @double in generatedDoubleArray)
                {
                    generatedArrayListBox.Items.Add(@double);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a positive integer in the 'Number of Elements' text box.", "Error - Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int Search<T>(T[] array, T key) where T : IComparable<T>
        {
            //iterate through the array to find the search key
            for (int i = 0; i < array.Length; i++)
            {
                //since T will implement IComparable, we can use CompareTo to search the key
                //if CompareTo returns 0, that means the two objects are the same
                if (array[i].CompareTo(key) == 0)
                    return i;
            }

            //If execution reaches here that means key was not found
            return -1;
        }
        private void generatedArrayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //disables the search/clear buttons if no search key selected
            searchBtn.Enabled = clearBtn.Enabled = generatedArrayListBox.SelectedItem != null;

            if (generatedArrayListBox.SelectedItem != null)
            {
                searchKeyTb.Text = generatedArrayListBox.SelectedItem.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchKeyTb.Clear();
            generatedArrayListBox.ClearSelected();
            searchBtn.Enabled = clearBtn.Enabled = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int queryResultIndex = -1;

                //call generic Search method with int array and key IFF int array was generated
                if (generatedIntArray != null)
                {
                    //attempt to search for the selected key
                    queryResultIndex = Search(generatedIntArray, int.Parse(searchKeyTb.Text));
                }
                //call generic Search method with double array and key IFF double array was generated
                else
                {
                    queryResultIndex = Search(generatedDoubleArray, double.Parse(searchKeyTb.Text));
                }

                //search key not found in the array
                if (queryResultIndex == -1)
                {
                    MessageBox.Show($"The search key {searchKeyTb.Text} could not be found in the array.", "Search Key Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //search key found in the array
                else
                {
                    MessageBox.Show($"The search key {searchKeyTb.Text} was found at the {queryResultIndex} position in the array.", "Search Key Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numeric input in the 'Search Key' text box.", "Error - Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchKeyTb_TextChanged(object sender, EventArgs e)
        {
            //enables the search and clear buttons if an array has been generated
            if (generatedIntArray != null || generatedDoubleArray != null)
            {
                searchBtn.Enabled = clearBtn.Enabled = true;
            }
        }
    }
}
