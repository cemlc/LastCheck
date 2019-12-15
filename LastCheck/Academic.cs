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
        public string Series { get; set; }
        public string Number { get; set; }
        public string Pages { get; set; }
        public string Month { get; set; }
        public string Doi { get; set; }
        public string Note { get; set; }
        public string Key { get; set; }
        public string Publisher { get; set; }
        public string Address { get; set; }
        public string Edition{ get; set; }
        public string Url { get; set; }
        public string Howpublished { get; set; }
        public string Booktitle { get; set; }
        public string Organization { get; set; }
        public string Type { get; set; }
        public string Editor { get; set; }
        public override string ToString()
        {
            return $"{EntryType} - {Author} - {Title} - {Year} - {Volume} - {Journal} - {Series} -" +
                $" {Number} - {Pages} - {Month} - {Doi} - {Note} - {Key} - {Publisher} - {Address} - " +
                $"{Edition} - {Url} - {Howpublished} - {Booktitle} - {Organization} - {Type} - {Editor}";
        }
    }
}
