using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
namespace SQLiteforWP7
{
   public class Persona
   {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(20)]
        public string nombre { get; set; }
    }
}
