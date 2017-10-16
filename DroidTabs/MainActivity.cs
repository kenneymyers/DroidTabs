using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Android.Content.PM;
using DroidTabs.Views;
using Xamarin.Forms.Platform.Android;

namespace DroidTabs
{
    [Activity(Label = "DroidTabs", Icon = "@mipmap/icon", Theme = "@style/Theme.MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.XamForm);

            //global::Xamarin.Forms.Forms.Init(this, savedInstanceState); 
            if (!Forms.IsInitialized)
                Forms.Init(this, savedInstanceState);

            //subscribe to a message that proceeds with loading droid up
            MessagingCenter.Subscribe<string>(this, "StartMainActivity", (sender) => {
                StartupMain();
            });

            LoadApplication(new App());

        }

        public void RunLoader(string pageName){
            
            if (!Xamarin.Forms.Forms.IsInitialized)
            {
                // initialize Xamarin.Forms before we use it
                Xamarin.Forms.Forms.Init(this, null);
            }

            SetContentView(Resource.Layout.XamForm);


            var loaderPage = new LoaderPage();

            // get hold of the native Android fragment that represents the Xamarin.Forms page
            var loaderFragment = loaderPage.CreateFragment(this);

            // show the login screen (native Xamarin.Android)
            FragmentManager
                .BeginTransaction()
                .AddToBackStack(null)
                .Replace(Resource.Id.frameLayout, loaderFragment)
                .Commit();
            

        }

        public void StartupMain(){
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Android.Widget.Button button = FindViewById<Android.Widget.Button>(Resource.Id.myButton);

            button.Click += delegate {
                RunLoader("tabbedPage");
            };
 
        }
    }
}

