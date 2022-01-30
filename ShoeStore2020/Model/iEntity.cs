using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore2020.Model
{
    public interface IEntity
    {
        void Populate(DataRow dr);
    }
}
