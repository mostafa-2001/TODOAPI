using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.DAL.Entities.BaseEntities;

namespace TODO.DAL.Entities.LabelEntity
{
    public class Label : BaseEntity
    {
        public string Name { get; set; }
        public string Color  { get; set; }
    }
}
