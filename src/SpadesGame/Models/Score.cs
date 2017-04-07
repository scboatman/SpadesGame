using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpadesGame.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int HandNum { get; set; }
        public int TotalScore { get; set; }
        public String Team1 { get; set; }
        public String Team2 { get; set; }

    }
}
