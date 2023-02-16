using TODO.DAL.Entities.BaseEntities;
using TODO.DAL.Entities.User;

namespace TODO.DAL.Entities.BoardEntity
{
    public class Board : BaseEntity
    {
        public string Name { get; set; }
        public bool IsFav { get; set; } = false;
    }
}
