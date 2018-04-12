using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Lab15.Activities;


namespace Lab15
{
    [Activity(Label = "Book Inventory", MainLauncher = true)]
    public class MainActivity : TabActivity
    {
        EditText txtEmail;
        EditText txtPassword;
        EditText btnLogin;
        EditText btnRegister;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtEmail);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);

            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            btnRegister.Click += BtnRegister_Click;
            btnRegister.Click += BtnRegister_Click1;
        }

        private void BtnRegister_Click1(object sender, EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


}

