using System;
using System.Collections.Generic;

namespace Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime OpeningDate { get; set; }
        public byte[] Local { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public ICollection<Occurrence> OccurrenceList { get; set; }
        public int AnalistId { get; set; }
        public User Analist { get; set; }
    }
}
