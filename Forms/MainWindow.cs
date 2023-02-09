using KanbanMVP.Classes;
using KanbanMVP.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanMVP
{
    public partial class frmMain : Form
    {
        public KanbanTask SelectedTask { get; set; }
        public frmMain()
        {
            InitializeComponent();

            lstTodo.DataSource = TasksRepository.FindTodoTasks();
            lstDoing.DataSource = TasksRepository.FindDoingTasks();
            lstDone.DataSource = TasksRepository.FindDoneTasks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KanbanTask kt = new KanbanTask(txtNew.Text);
            TasksRepository.Save(kt);

            lstTodo.DataSource = TasksRepository.FindTodoTasks();
        }

        private void lstDoing_DoubleClick(object sender, EventArgs e)
        {
            SelectedTask = (KanbanTask)lstDoing.SelectedItem;
            lblSelectedDoing.Text = String.Format("Task: {0}", SelectedTask);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (SelectedTask != null)
            {
                SelectedTask.TaskState = 2;

                TasksRepository.Save(SelectedTask);
                TasksRepository.Remove((KanbanTask)lstDoing.SelectedItem);

                lstDoing.DataSource = TasksRepository.FindDoingTasks();
                lstDone.DataSource = TasksRepository.FindDoneTasks();

                lblSelectedDoing.Text = "Task:";
                SelectedTask = null;
            }
            else MessageBox.Show("You need to select a task first");
        }

        private void btnDoing_Click(object sender, EventArgs e)
        {
            if (SelectedTask != null)
            {
                SelectedTask.TaskState = 1;

                TasksRepository.Save(SelectedTask);
                TasksRepository.Remove((KanbanTask)lstTodo.SelectedItem);

                lstTodo.DataSource = TasksRepository.FindTodoTasks();
                lstDoing.DataSource = TasksRepository.FindDoingTasks();

                lblSelectedTodo.Text = "Task:";
                SelectedTask = null;
            }
            else MessageBox.Show("You need to select a task first");
        }

        private void lstTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTask = (KanbanTask)lstTodo.SelectedItem;
            lblSelectedTodo.Text = String.Format("Task: {0}", SelectedTask);
        }

        private void lstTodo_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedTask != null)
            {
                SelectedTask.TaskState = 1;

                TasksRepository.Save(SelectedTask);
                TasksRepository.Remove((KanbanTask)lstTodo.SelectedItem);

                lstTodo.DataSource = TasksRepository.FindTodoTasks();
                lstDoing.DataSource = TasksRepository.FindDoingTasks();

                lblSelectedTodo.Text = "Task:";
                SelectedTask = null;
            }
            else MessageBox.Show("You need to select a task first");
        }
    }
}