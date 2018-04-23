using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Taisnsturis t1 = new Taisnsturis(3, 5);
            Taisnsturis t2 = new Taisnsturis(13, 15);

            t1.Laukums();
            t2.Laukums(); */

            Darbinieks darb = new Darbinieks();
            darb.Vards = "Peteris";
            darb.Uzvards = "Abols";
            darb.DzGads = 1987;
            darb.Epasts = "jjs@dhfsfhf.lv";
            darb.Talrunis = "+371232345";
            darb.Dzivesvieta = new Adrese();
            darb.Dzivesvieta.Valsts = "Latvija";
            darb.Dzivesvieta.Pilseta = "Cēsis";
            darb.Dzivesvieta.Iela = "Ķiršu";
            darb.Dzivesvieta.MajasNr = "A";
            darb.Dzivesvieta.DzivoklaNr = 5;
            darb.AktualaNodala = new Nodala();
            darb.AktualaNodala.Nosaukums = "KAĶI";
            darb.AktualaNodala.AtrasanasVieta = new Adrese();
            darb.AktualaNodala.AtrasanasVieta.Valsts = "Igaunija";
            darb.IeprieksejaNodala = new Nodala();
            darb.IeprieksejaNodala.Nosaukums = "SUŅI";
            darb.IeprieksejaNodala.AtrasanasVieta = new Adrese();
            darb.IeprieksejaNodala.AtrasanasVieta.Valsts = "Latvija";
            darb.IeprieksejaNodala.AtrasanasVieta.Pilseta = "Rīga";
            darb.IeprieksejaNodala.AtrasanasVieta.Iela = "Plūmju";
            darb.IeprieksejaNodala.AtrasanasVieta.MajasNr = "B";
            darb.IeprieksejaNodala.AtrasanasVieta.DzivoklaNr = 3;




            darb.TeikumsViens();
            darb.TeikumsDivi(); 








        Console.ReadLine();

        }
    }
}
