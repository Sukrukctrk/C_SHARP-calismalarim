using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

using Microsoft.Xna.Framework;

using oyun1.Core;

namespace oyun1.Android
{
    /// <summary>
    /// The main activity for the Android application. It initializes the game instance,
    /// sets up the rendering view, and starts the game loop.
    /// </summary>
    /// <remarks>
    /// This class is responsible for managing the Android activity lifecycle and integrating
    /// with the MonoGame framework.
    /// </remarks>
    [Activity(
        Label = "oyun1",
        MainLauncher = true,
        Icon = "@drawable/icon",
        Theme = "@style/Theme.Splash",
        AlwaysRetainTaskState = true,
        LaunchMode = LaunchMode.SingleInstance,
        ScreenOrientation = ScreenOrientation.SensorLandscape,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden
    )]
    public class MainActivity : AndroidGameActivity
    {
        private oyun1Game _game;
        private View _view;

        /// <summary>
        /// Called when the activity is first created. Initializes the game instance,
        /// retrieves its rendering view, and sets it as the content view of the activity.
        /// Finally, starts the game loop.
        /// </summary>
        /// <param name="bundle">A Bundle containing the activity's previously saved state, if any.</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            _game = new oyun1Game();
            _view = _game.Services.GetService(typeof(View)) as View;

            SetContentView(_view);
            _game.Run();
        }
    }
}