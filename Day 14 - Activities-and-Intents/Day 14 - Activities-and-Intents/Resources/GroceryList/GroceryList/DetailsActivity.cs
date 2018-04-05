using Android.App;
using Android.OS;
using Android.Widget;

namespace GroceryList
{
	[Activity(Label = "Details")]			
	public class DetailsActivity : Activity
	{
        txtView txtName;
        txtView txtCount;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Details);

			int position = 0;

            // TODO
            position = Intent.GetIntExtra("ItemPosition", -1);

            var item = MainActivity.Items[position];

            txtCount = FindViewById<TextView>(Resource.Id.countTextView);
            txtName = FindViewById<TextView>(Resource.Id.nameTextView);

            txtName.Text = "Name: "  + item.Name;
			txtCount.Text = "Count: " + item.Count.ToString();
		}
	}
}