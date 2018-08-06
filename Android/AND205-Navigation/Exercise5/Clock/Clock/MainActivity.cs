using Android.App;
using Android.OS;
using Android.Views;

namespace Clock
{
	[Activity(Label = "Clock", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Android.Support.V7.App.AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
			base.SetSupportActionBar(toolbar);
			SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_white_24dp);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            // TODO #2
            var menu = FindViewById<Android.Support.Design.Widget.NavigationView>(Resource.Id.navigationView);

            menu.NavigationItemSelected += OnMenuItemSelected;

            Navigate(new TimeFragment());
		}

        // TODO #1
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    var drawerLayout = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.drawerLayout);

                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);

                    break;
            }

            return true;
        }

        // TODO #3
        void OnMenuItemSelected(object sender, Android.Support.Design.Widget.NavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.MenuItem.ItemId)
            {
                case Resource.Id.timeMenuItem: Navigate(new TimeFragment()); break;
                case Resource.Id.stopwatchMenuItem: Navigate(new StopwatchFragment()); break;
                case Resource.Id.aboutMenuItem: Navigate(new AboutFragment()); break;
            }

            // TODO #4
            e.MenuItem.SetChecked(true);

            var drawerLayout = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.drawerLayout);

            drawerLayout.CloseDrawer(Android.Support.V4.View.GravityCompat.Start);
        }

        void Navigate(Android.Support.V4.App.Fragment fragment)
		{
			var transaction = base.SupportFragmentManager.BeginTransaction();
			transaction.Replace(Resource.Id.contentFrame, fragment);
			transaction.Commit();
		}
	}
}