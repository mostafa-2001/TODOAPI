using System.ComponentModel.DataAnnotations.Schema;
using TODO.DAL.Entities.BaseEntities;
using TODO.DAL.Entities.User;

namespace TODO.DAL.Entities.BoardEntity
{
    public class SharedBoardUser : BaseEntityWithoutId
    {
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        [ForeignKey("SharedBoardId")]
        public SharedBoard SharedBoard { get; set; }
        public long SharedBoardId { get; set; }
    }
}
