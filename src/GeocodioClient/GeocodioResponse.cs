using System;
using System.Collections.Generic;

namespace GeocodioClient
{
    public class GeocodioResponse
    {
        /// <summary>
        /// Describes how the Geocodio service understood a request's input parameters
        /// </summary>
        public GeocodioInput input { get; set; }

        /// <summary>
        /// Contains the result set from Geocodio   
        /// </summary>
        public List<GeocodioResult> results { get; set; }
    }

    public class GeocodioInput
    {
        public GeocodioAddressComponents address_components { get; set; }
        public string formatted_address { get; set; }
    }

    public class GeocodioResult
    {
        public GeocodioAddressComponents address_components { get; set; }
        public string formatted_address { get; set; }
        public GeocodioLatLng location { get; set; }

        /// <summary>
        /// This table describes accuracy scores: http://geocod.io/docs/#toc_25
        /// </summary>
        public double accuracy { get; set; }
    }

    public class GeocodioAddressComponents
    {
        public string number { get; set; }
        public string street { get; set; }
        public string suffix { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; } 
    }

    public class GeocodioLatLng
    {
        public decimal lat { get; set; }
        public decimal lng { get; set; }
    }
}