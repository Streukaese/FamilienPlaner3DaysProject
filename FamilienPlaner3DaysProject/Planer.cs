using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilienPlaner3DaysProject
{
    public class Planer
    {
        public int id;
        public string name;
        public string ueberschrift;
        public string notizen;
        public DateTime endDate; // vorher Object nun DateTime
        //public DateTime endDatum;
        public string wichtigkeit;

        public Planer(int id, string name, string ueberschrift, string notizen, DateTime endDate, string wichtigkeit) //DateTime endDatum | object dateTimePickerEndDatum | , string notizen
        {
            this.id = id;
            this.name = name;
            this.ueberschrift = ueberschrift;
            this.notizen = notizen;
            this.endDate = endDate;
            this.wichtigkeit = wichtigkeit;
        }

        public override string ToString()
        {
            return wichtigkeit + " " + name + " " + ueberschrift + " (" + endDate.ToString("yyyy-MM-dd") + ") " + notizen;
        }
    }
}
