using Cars.Data.Interface;
using Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Mock
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "German cars", Description ="EuroBlyaha"},
                    new Category { CategoryName = "Japanese cars", Description ="Deja vu i have been in this place before"}
                };
            }
        }
    }
}
