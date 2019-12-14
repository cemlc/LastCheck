using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCheck
{

    class Academic
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string EntryType { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }

        public string Volume { get; set; }
        public string Journal { get; set; }




        public override string ToString()
        {
            return $"{EntryType} - {Author} - {Title} - {Year} - {Volume} - {Journal} ";
        }
    }
}
