using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class AlbumTest
    {
        public int numFotos { get; protected set; }

        public void crearAlbumPredeterminado()
        {
            AlbumFotos album = new AlbumFotos();
        }

        public void crearAlbum24()
        {
            AlbumFotos album = new AlbumFotos(24);
        }

        public void crearSuperAlbum()
        {
            SuperAlbumFotos superAlbum = new SuperAlbumFotos();
        }

        public void mostrar()
        {
            Console.WriteLine(numFotos);
        }
    }

}
