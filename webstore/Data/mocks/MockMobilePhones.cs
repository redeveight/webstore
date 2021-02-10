using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webstore.Data.Interfaces;
using webstore.Data.Models;

namespace webstore.Data.mocks
{
    public class MockMobilePhones : IAllMobilePhones
    {
        private readonly IMobilePhonesCategory _mobilePhonesCategory = new MockCategory();

        public IEnumerable<MobilePhone> MobilePhones
        {
            get
            {
                return new List<MobilePhone> {
                    new MobilePhone { modelName = "Samsung", description = "", shortDescription = "", image = "", price = 2000, isFavourite = true, available = true, Category = _mobilePhonesCategory.AllCategories.First() }
                };
            }
        }
        public IEnumerable<MobilePhone> FavouriteSmartphones { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<MobilePhone> getMobilePhoneObject(int phoneID)
        {
            throw new NotImplementedException();
        }
    }
}
