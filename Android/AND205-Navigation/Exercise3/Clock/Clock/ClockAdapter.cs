using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

// TODO #2
namespace Clock
{
    public class ClockAdapter : Android.Support.V4.App.FragmentPagerAdapter
    {
        Android.Support.V4.App.Fragment[] fragments;

        // constructor
        public ClockAdapter(Android.Support.V4.App.FragmentManager fm, Android.Support.V4.App.Fragment[] fragments)
            : base(fm)
        {
            this.fragments = fragments;
        }

        // property
        public override int Count
        {
            get { return fragments.Length; }
        }

        // method
        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return fragments[position];
        }
    }
}