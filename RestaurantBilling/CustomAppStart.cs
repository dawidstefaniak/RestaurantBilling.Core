using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBilling.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace RestaurantBilling.Core
{
    class CustomAppStart : MvxNavigatingObject,IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainMenuViewModel>();
        }
    }
}
