using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.DAL.Entities.BaseEntities;
using TODO.DAL.Entities.User;

namespace TODO.DAL.Entities.TasksEntity
{
    public class TaskOfBoardUser : BaseEntityWithoutId
    {
        [ForeignKey("TaskOfBoardId")]
        public virtual TaskOfBoard TaskOfBoard { get; set; }
        public long TaskOfBoardId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
