using System;
using System.Collections.Generic;
using System.Text;

namespace BellBox.Models
{
    public class Song
    {
        public string Title { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        /// <summary>
        /// Time in Seconds
        /// </summary>
        public int Time { get; set; }
    }
}
