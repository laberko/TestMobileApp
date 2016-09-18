using System;
using Android.OS;
using Android.Views;
using Fragment = Android.Support.V4.App.Fragment;

namespace Echo
{
    public class EchoViewPagerFragment : Fragment
    {
        private readonly Func<LayoutInflater, ViewGroup, Bundle, View> _view;

        public EchoViewPagerFragment(Func<LayoutInflater, ViewGroup, Bundle, View> view)
        {
            _view = view;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return _view(inflater, container, savedInstanceState);
        }
    }
}