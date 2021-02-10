using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webstore.Data.Models;

namespace webstore.Data.Interfaces
{
    interface IAllMobilePhones
    {
        IEnumerable<MobilePhone> MobilePhones { get; }
        IEnumerable<MobilePhone> FavouriteSmartphones { get; set; }
        IEnumerable<MobilePhone> getMobilePhoneObject(int phoneID);
    }
}
