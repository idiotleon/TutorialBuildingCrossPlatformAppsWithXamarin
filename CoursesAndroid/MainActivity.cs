using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace CoursesAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button btnPrev;
        Button btnNext;
        TextView tvTitle;
        ImageView ivCourse;
        TextView tvDescription;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            btnPrev = FindViewById<Button>(Resource.Id.btnPrev);
            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            tvTitle = FindViewById<TextView>(Resource.Id.tv_title);
            ivCourse = FindViewById<ImageView>(Resource.Id.iv_main);
            tvDescription = FindViewById<TextView>(Resource.Id.tv_description);

            btnPrev.Click += btnPrev_Click;
            btnNext.Click += btnNext_Click;
        }

        void btnPrev_Click(object sender, EventArgs e){
            tvTitle.Text = "Prev Clicked";
            tvDescription.Text = "The description that appears when Prev is clicked";
            ivCourse.SetImageResource(Resource.Drawable.ps_top_card_01);
        }

        void btnNext_Click(object sender, EventArgs e){
            tvTitle.Text = "Next Clicked";
            tvDescription.Text = "The description that appears when Next is clicked";
            ivCourse.SetImageResource(Resource.Drawable.ps_top_card_02);
        }
    }
}

