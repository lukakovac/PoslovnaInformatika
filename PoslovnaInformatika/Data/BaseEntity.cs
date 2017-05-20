using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoslovnaInformatika.Data
{
    public class BaseEntity<T> : Entity
    {
        public virtual T Id { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
