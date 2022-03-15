using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unosuBazu.ModelBaze
{
    class PristupBazi
    {
        // unos u bazu
        public void unosUbazu(string imeUc, string prezimeUc)
        {
            using IDbConnection connection = new SqlConnection("Server = 192.168.42.68; Database = GrupaB; User Id = dorian; Password = 1234;");
            List<Ucenici> ljudi = new List<Ucenici>();
            ljudi.Add(new Ucenici { Ime = imeUc, Prezime = prezimeUc });
            connection.Execute("dbo.UnosUc @Ime, @Prezime", ljudi);
        }




        // ispis iz baze
        public List<Ucenici> ispis()
        {
            using (IDbConnection connection = new SqlConnection("Server = 192.168.42.68; Database = GrupaB; User Id = dorian; Password = 1234;"))
            {

                var a = connection.Query<Ucenici>("SELECT * FROM GrupaB.dbo.Ucenici").ToList();

                return a;
            }
        }

        //pretraga baze
        public List<Ucenici> trazi(string ime)
        {
            using (IDbConnection connection = new SqlConnection("Server = 192.168.42.68; Database = GrupaB; User Id = dorian; Password = 1234;"))
            {
                var b=connection.Query<Ucenici>("sp_TraziIme @ime", new {Ime=@ime}).ToList();
                return b;
            }
        }
    }
}
