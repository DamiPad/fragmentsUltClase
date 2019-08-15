using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Fragments_7a
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IEstadoSeleccionado
    {
        public void OnEstadoSeleccionado(string[] ciudades)
        {
            var ciudadesFragment = SupportFragmentManager.FindFragmentById(Resource.Id.ciudades) as CiudadesFragment;
            ciudadesFragment.updateCiudades(ciudades);


        }




        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}