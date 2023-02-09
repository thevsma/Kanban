using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanMVP.Classes
{
    [Table("KanbanTasks")]
    public class KanbanTask
    {
        public Int64 Id { get; set; }

        [MaxLength(200)]
        public String Description { get; set; }

        public Int64 TaskState { get; set; }

        public KanbanTask()
        {
            TaskState = 0;
        }

        public KanbanTask(String desc) : this()
        {
            Description = desc;
        }

        public override String ToString()
        {
            return Description;
        }
    }
}