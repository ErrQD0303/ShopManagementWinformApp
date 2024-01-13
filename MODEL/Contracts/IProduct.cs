using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Contracts
{
    public interface IProduct : ICloneable
    {
        #region properties
        long ID { get; set; }
        string ProductID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        #endregion
    }
}
