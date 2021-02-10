using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webstore.Data.Interfaces;

namespace webstore.Controllers
{
    public class MobilePhonesController : Controller
    {
        private readonly IAllMobilePhones _allMobilePhones;
        private readonly IMobilePhonesCategory _allCategories;

        public MobilePhonesController(IAllMobilePhones iallMobilePhones, IMobilePhonesCategory iMobilePhonesCategory)
        {
            _allMobilePhones = iallMobilePhones;
            _allCategories = iMobilePhonesCategory;
        }

        public ViewResult List()
        {
            var mobilePhones = _allMobilePhones.MobilePhones;
            return View(mobilePhones);
        }
    }
}
