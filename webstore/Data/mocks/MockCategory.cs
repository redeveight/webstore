using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webstore.Data.Interfaces;
using webstore.Data.Models;

namespace webstore.Data.mocks
{
    public class MockCategory : IMobilePhonesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category { categoryName = "Smartphones", description = "Modern phones with touch screens" },
                    new Category { categoryName = "Phones", description = "Classic phones, with push-button control" }
                };
            }
        }
    }
}
