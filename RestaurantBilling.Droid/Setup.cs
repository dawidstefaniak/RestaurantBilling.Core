using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using RestaurantBilling.Core;


namespace RestaurantBilling.Droid
{
    public class Setup : MvxAndroidSetup
    {
        protected Setup(Context applicationContext) : base(applicationContext)
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}