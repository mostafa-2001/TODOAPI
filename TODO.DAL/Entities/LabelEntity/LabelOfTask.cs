using System.ComponentModel.DataAnnotations.Schema;
using TODO.DAL.Entities.BaseEntities;
using TODO.DAL.Entities.TasksEntity;

namespace TODO.DAL.Entities.LabelEntity
{
    public class LabelOfTask : BaseEntityWithoutId
    {
        [ForeignKey("TaskOfBoardId")]
        public virtual TaskOfBoard TaskOfBoard { get; set; }
        public long TaskOfBoardId { get; set; }

        [ForeignKey("LabelId")]
        public virtual Label Label { get; set; }
        public long  LabelId { get; set; }
    }
}
