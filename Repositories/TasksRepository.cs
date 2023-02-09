using KanbanMVP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanMVP.Repositories
{
    internal class TasksRepository
    {
        public static void Save(KanbanTask kt)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    repos.KanbanTask.Add(kt);
                    repos.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<KanbanTask> FindTodoTasks()
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    return repos.KanbanTask.Where(t => t.TaskState == 0).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<KanbanTask> FindDoingTasks()
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    return repos.KanbanTask.Where(t => t.TaskState == 1).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<KanbanTask> FindDoneTasks()
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    return repos.KanbanTask.Where(t => t.TaskState == 2).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(KanbanTask kt)
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    repos.KanbanTask.Attach(kt);
                    repos.KanbanTask.Remove(kt);

                    repos.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
