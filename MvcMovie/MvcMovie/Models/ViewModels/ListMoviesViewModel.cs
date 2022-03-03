using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models.ViewModels
{
    public class ListMoviesViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Ratings { get; set; }
        //ratingID moet overeen komen met parameter uit methode en parameters moeten met kleine letter
        //ratingID has to be the same as in the parameter which and parameters are written without capitalisation
        public int ratingID { get; set; }
    }
}