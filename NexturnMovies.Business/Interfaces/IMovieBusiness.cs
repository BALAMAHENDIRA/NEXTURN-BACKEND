﻿using NexturnMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexturnMovies.Business.Interfaces
{
   public interface IMovieBusiness 
    {
        List<MovieVM> GetMovies();
    }
}
