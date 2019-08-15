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

namespace Fragments_7a
{
    class EstadosFragment: Android.Support.V4.App.ListFragment
    {

        public override void OnStart()
        {
            base.OnStart();
            ListAdapter = new ArrayAdapter(
                Activity,
                Android.Resource.Layout.SimpleListItem1,
                new[] { "Guanajuato", "Durango", "Zacatecas", "Nayarit", "Michoacan" });//estados


            string[] items = new string[] { "Irapuato", "León", "Silao", "Romita" };//Ciudades
            ListView.ItemClick += (sender, e) => {//mediante el evento clic sobre algún item de la list de estados envia la posicion
                if (estadoSeleccionado != null)
                {
                    estadoSeleccionado.OnEstadoSeleccionado(items);// va a la interfaz del estado y luego se lo envia al main activity
                }
            };


        }

        IEstadoSeleccionado estadoSeleccionado;

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            estadoSeleccionado = context as IEstadoSeleccionado;
        }

    }
}