/*Lindsey DeDecker
 * CST-150
 * July 25, 2024
 * Activity 5
 */using CST_150_DogClass.BuisnessLayer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_DogClass.PresentationLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //Error Label not visible
            lblErrorMessage.Visible = false;

            //Add the laod event handler
            this.Load += new EventHandler(FrmMainLoadEventHandler);
        }

        ///<summary>
        ///Click event to add a new dog to the datagridview tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNewDog_ClickEvent(object sender, EventArgs e)
        {
            //Declare and initialize
            //Flad that tracks if all entries are valid
            bool isValidEntries = true;
            double weight = 0.00D, neckRad = 0.00D; 
            //Flag to verify parsing doubles is true or false
            bool isValid = false;

            //Make sure the Error Label is not visible
            lblErrorMessage.Visible = false;

            //Instantiate our utility class so we can use it
            Utility utility = new Utility();

            //-------------------------
            //Verify all boxes have correct inputs
            //We will be suing a utility / Helper class to verify inputys
            if(!utility.NotNull(txtName.Text) || !utility.NotNull(txtColor.Text) || (cmbSit.SelectedItem == null))
            {
                isValidEntries = false;
            }
            //Now test the text box for valid double neck size
            //If valid the weight will contain the double value
            (weight, isValid) = utility.validDouble(txtWeight.Text);
            if(!isValid)
            {
                isValidEntries = false;
            }

            //datagridview with the entry
            //else displaty error message
            if(isValidEntries)
            {
                //If we are here we knwo we have valid entries
                //So lets populate datagridview
                Dog dogObject = new Dog(txtName.Text, neckRad, txtColor.Text, weight, utility.ConvertToBool(cmbSit.Text));
                gvShowDogs.Rows.Add(dogObject.Name, dogObject.CalCircumference(), dogObject.Sit, dogObject.CalWeight(), dogObject.Color);
            }
            else
            {
                //If we are here there is a problem with an entry. Show error message
                lblErrorMessage.Visible = true;
            }
        }
        ///<summary>
        ///When the form loads execute this event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainLoadEventHandler(object sender, EventArgs e)
        {
            //Set the number of rows to 5 and configure each row
            gvShowDogs.ColumnCount = 5;
            gvShowDogs.Columns[0].Name = "Name";
            gvShowDogs.Columns[1].Name = "Neck Circum";
            gvShowDogs.Columns[2].Name = "Sitting";
            gvShowDogs.Columns[3].Name = "Weight";
            gvShowDogs.Columns[4].Name = "Color";

            //Format number in neck and weight for 2 decimals
            gvShowDogs.Columns[1].DefaultCellStyle.Format = "#.00";
            gvShowDogs.Columns[3].DefaultCellStyle.Format = "#.00";
        }


    }
}
