using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO.DAL.Entities.BoardEntity
{
    public class SharedBoard : Board
    {
        public virtual ICollection<ColumnOfBoard> ColumnOfBoards { get; set; }

    }
}
