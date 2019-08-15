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
using Android.Support.V4.App;

namespace Fragments_7a
{
    class CiudadesFragment: Android.Support.V4.App.ListFragment
    {
        public override void OnStart()
        {
            base.OnStart();
            
        }

        public void updateCiudades(string[] ciudades) // esta lista se crea en tiempo de ejecutar a diferencia de la lista de estados... pero esta cargado por default
        {
            ListAdapter = new ArrayAdapter(
                Activity,
                Android.Resource.Layout.SimpleListItem1,
                ciudades);


        }

    }
}