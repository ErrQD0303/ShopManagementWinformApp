using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAttribute;

namespace MODEL.Contracts
{
    public interface IProduct : ICloneable
    {
        #region properties
        long ID { get; set; }
        [Filter]
        string ProductID { get; set; }
        [Name, Filter]
        string ProductName { get; set; }
        [Filter]
        string Description { get; set; }
        bool IsActived { get; set; }
        bool IsDeleted { get; set; }
        long DisplayID { get; set; }
        int Version { get; set; }
        #endregion
    }
}
