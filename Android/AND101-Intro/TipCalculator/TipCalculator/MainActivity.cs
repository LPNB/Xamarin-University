using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace TipCalculator
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
        Button calculateButton;
        EditText inputBill;
        TextView outputTip;
        TextView outputTotal;

        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            inputBill       = FindViewById<EditText>(Resource.Id.inputBill);
            outputTip       = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal     = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += OnCalculateClick; 
		}

        void OnCalculateClick(object sender, EventArgs e)
        {
            string text = inputBill.Text;
            double bill;

            if(double.TryParse(text, out bill))
            {
                var tip = bill * 0.15;
                var total = bill + tip;

                outputTip.Text = String.Format("{0:C}", tip);
                outputTotal.Text = String.Format("{0:C}", total);
            }
        }
    }
}

