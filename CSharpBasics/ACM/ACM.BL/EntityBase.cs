using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        public enum EntityStateoption
        {
            Active,
            Deleted
        };
        public EntityStateoption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid
        {
            get {return Validate();}
        }
        public abstract bool Validate();
    }
}
