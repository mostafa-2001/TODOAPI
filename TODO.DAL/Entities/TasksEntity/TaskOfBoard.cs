using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.DAL.Entities.BaseEntities;
using TODO.DAL.Entities.BoardEntity;

namespace TODO.DAL.Entities.TasksEntity
{
    public class TaskOfBoard : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? AttachmentLink { get; set; }
        public DateTime? DeadLine { get; set; }
        public string? CoverUrl { get; set; }

        [ForeignKey("ColumnOfBoardId")]
        public virtual ColumnOfBoard ColumnOfBoard { get; set; }
        public long ColumnOfBoardId { get; set; }


    }
}
