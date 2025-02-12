﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class PokemonViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string Region { get; set; }

        public string TypePrimary { get; set; }

        public string TypeSecondary { get; set; }

        public int RegionId { get; set; }
    }
}
