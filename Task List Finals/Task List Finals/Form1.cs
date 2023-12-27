using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_List_Finals
{
    public partial class Task_List : Form
    {
        public Task_List()
        {
            InitializeComponent();
        }

        DataTable toDoList = new DataTable(); //list that holds information
        bool isBeingEdited = false; //when true, current row can be altered
        int score = 0; //task count

        private void Task_List_Load(object sender, EventArgs e)
        {
            //Creating table columns
            toDoList.Columns.Add("Task");
            toDoList.Columns.Add("Description");
            toDoList.Columns.Add("Finished", typeof(bool));

            //Make the datagridview our data source
            taskListView.DataSource = toDoList;
            lblCount.Text = "Task Count: " + score.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //New blank spaces for new task and description
            tbxTask.Text = "";
            tbxDesc.Text = "";
            isBeingEdited = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (toDoList.Rows.Count != 0)
            {
                isBeingEdited = true;
                //Gets the title and desc at the selected index and converted them to a string
                //That string is placed in the corresponding textbox
                tbxTask.Text = toDoList.Rows[taskListView.CurrentCell.RowIndex].ItemArray[0].ToString();
                tbxDesc.Text = toDoList.Rows[taskListView.CurrentCell.RowIndex].ItemArray[1].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isBeingEdited) //alters current row equal to text in text boxes
            {
                toDoList.Rows[taskListView.CurrentCell.RowIndex]["Task"] = tbxTask.Text;
                toDoList.Rows[taskListView.CurrentCell.RowIndex]["Description"] = tbxDesc.Text;
                toDoList.Rows[taskListView.CurrentCell.RowIndex]["Finished"] = false;
            }
            else //adds a new row and sets them equal to the text in the textboxes
            {
                if (tbxTask.Text != "")
                {
                    toDoList.Rows.Add(tbxTask.Text, tbxDesc.Text, false);
                    score += 1;
                }
            }
            //Clears text boxes
            tbxTask.Text = "";
            tbxDesc.Text = "";
            //Done editing, increase task count
            isBeingEdited = false;
            lblCount.Text = "Task Count: " + score.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If the tasklist contains nothing, selecting delete would cause an error
            //Try catch prevents this
            if (toDoList.Rows.Count != 0)
            {
                try
                {
                    toDoList.Rows[taskListView.CurrentCell.RowIndex].Delete();
                    score -= 1; //reduces task count
                    lblCount.Text = "Task Count: " + score.ToString();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
        }
    }
}
