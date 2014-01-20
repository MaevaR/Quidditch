using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public abstract class EntityObject
    {
        protected int _id;

        public int Id
        {
            set
            {
                _id = value;
            }

            get
            {
                return _id;
            }

        }

        public EntityObject(int id)
        {
            _id = id;
        }
    }
}
