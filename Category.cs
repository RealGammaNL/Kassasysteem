using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Category
    {
        List<Artikel> C1_items = new List<Artikel>();
        List<Artikel> C2_items = new List<Artikel>();
        List<Artikel> C3_items = new List<Artikel>();
        List<Artikel> C4_items = new List<Artikel>();
        List<Artikel> C5_items = new List<Artikel>();
        List<Artikel> C6_items = new List<Artikel>();
        List<Artikel> C7_items = new List<Artikel>();

        public Category()
        {
            C1_items.AddRange(new List<Artikel>
            {
                new Artikel("Melk", 1.50), new Artikel("Chocomel", 2.50), new Artikel("Crème Fraîche", 2.90),
                new Artikel("Karnemelk", 2.70), new Artikel("Kwark", 3.30), new Artikel("Yoghurt", 3.20), new Artikel("Vla", 3.10)
            });

            C2_items.AddRange(new List<Artikel>
            {
                new Artikel("Sla", 2.40), new Artikel("Tomaat", 0.50),new Artikel("Paprika", 1.00),
                new Artikel("400g Bonen", 2.00 ), new Artikel("200g Champignons", 3.40), new Artikel("Radijs", 2.70), new Artikel("1kg Aardappel", 2.20)
            });

            C3_items.AddRange(new List<Artikel>
            {
                new Artikel("Appel", 0.70), new Artikel("Peer", 0.80), new Artikel("Banaan", 2.30),
                new Artikel("300g Druiven", 3.00), new Artikel("Manderijnen", 3.00), new Artikel("Granaatappel", 2.00), new Artikel("Necterine", 2.30)
            });

            C4_items.AddRange(new List<Artikel>
            {
                new Artikel("Biefstuk", 8.20), new Artikel("Ham", 4.30), new Artikel("Kipfilet", 4.20),
                new Artikel("Leverworst", 2.30), new Artikel("Pate", 3.40), new Artikel("Rundervink", 3.30), new Artikel("Ossenhaas", 4.50),
            });

            C5_items.AddRange(new List<Artikel>
            {
                new Artikel("Jong belegen kaas", 4.30), new Artikel("Belegen kaas", 3.70), new Artikel("Jonge kaas", 6.20),
                new Artikel("Parmazaanse kaas", 7.40), new Artikel("Oude kaas", 5.30), new Artikel("Blauwe kaas", 8.40), new Artikel("Brie", 1.20),
            });

            C6_items.AddRange(new List<Artikel>
            {
                new Artikel("Guinness", 2.25), new Artikel("Bacardi", 16.00),new Artikel("Malibu", 12.30),
                new Artikel("Pisang", 15.75), new Artikel("Limoncello", 23.75), new Artikel("Alfa krat", 10.00), new Artikel("Cola", 1.75),
            });

            C7_items.AddRange(new List<Artikel>
            {
                new Artikel("Maanzaadbrood", 4.75), new Artikel("Roggenbrood", 3.50),new Artikel("Witbrood", 2.20),
                new Artikel("Volkorenbrood", 3.40), new Artikel("Tijgerbrood", 2.70), new Artikel("Tostibrood", 3.20), new Artikel("Bruinbrood", 1.75),
            });

        }
    }
}
