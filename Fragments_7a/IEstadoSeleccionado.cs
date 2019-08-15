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
    interface IEstadoSeleccionado
    {
        void OnEstadoSeleccionado(string[] ciudades); //para comunicar los fragments dentro del main activity
        // se le pasa el arreglo de ciudades
    }
}