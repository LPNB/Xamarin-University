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
using Java.Lang;

namespace Clock
{
    public class ClockAdapter : Android.Support.V4.App.FragmentPagerAdapter
    {
    // fields:
        Android.Support.V4.App.Fragment[] fragments;
        // TODO #1
        ICharSequence[] titles;

    // constructor:
        // TODO #2 
        public ClockAdapter(Android.Support.V4.App.FragmentManager fm, Android.Support.V4.App.Fragment[] fragments, ICharSequence[] titles)
           : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
        }

    // properties:
        public override int Count
        {
            get { return fragments.Length; }
        }

    // methods:
        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return fragments[position];
        }

        // TODO #3
        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return titles[position];
        }
    }
}