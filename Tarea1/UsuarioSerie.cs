using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class UsuarioSerie
    {

        public Capitulo Capitulo
        {
            get;
            set;
        }

        public Usuario Usuario
        {
            get;
            set;
        }

        public List<Serie> SeriesFavoritas
        {
            get;
            set;
        }

        public bool esCapituloVisto
        {
            get;
            set;
        }
         
        public char EstadoSerie
        {
            get;
            set;
        }

        public float ProgresoTemporada()
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> SeriesSugeridas()
        {
            throw new System.NotImplementedException();
        }
    }
}