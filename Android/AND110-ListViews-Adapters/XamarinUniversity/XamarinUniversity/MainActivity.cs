using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace XamarinUniversity
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var instructorList = FindViewById<ListView>(Resource.Id.instructorListView);
            instructorList.FastScrollEnabled = true;
  
            instructorList.ItemClick += OnItemClick;

            instructorList.Adapter = new InstructorAdapter(InstructorData.Instructors);
        }

        void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var instructor = InstructorData.Instructors[e.Position];

            var dialog = new Android.App.AlertDialog.Builder(this);
            dialog.SetMessage(instructor.Name);
            dialog.SetNeutralButton("OK", delegate { });
            dialog.Show();
        }
    }
}

