using Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Interface
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
