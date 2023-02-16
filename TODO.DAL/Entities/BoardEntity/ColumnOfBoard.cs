using System.ComponentModel.DataAnnotations.Schema;
using TODO.DAL.Entities.BaseEntities;
using TODO.DAL.Entities.TasksEntity;

namespace TODO.DAL.Entities.BoardEntity
{
    public class ColumnOfBoard : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("BoardId")]
        public virtual Board Board { get; set; }
        public long BoardId { get; set; }

        public virtual ICollection<TaskOfBoard> TaskOfBoards { get; set; }
    }
}
