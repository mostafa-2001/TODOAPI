using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.DAL.Entities.User;

namespace TODO.DAL.Entities.BoardEntity
{
    public class PrivateBoard : Board
    {
        public virtual ICollection<ColumnOfBoard> ColumnOfBoards { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

    }
}
