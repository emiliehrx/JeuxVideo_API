using JeuxVideo_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVideo_API.Models
{
    public class Jeu
    {
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public int Note { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Descriptif { get; set; }
    }
}
