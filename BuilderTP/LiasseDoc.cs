using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTP
{
    public class LiasseDOC : Liasse
    {
        public override void ajouteDocument(string document)
        {
            if (document.StartsWith("<DOC>"))
                contenu.Add(document);
        }

        public override void imprime()
        {
            Console.WriteLine("Liasse DOC");
            foreach (string s in contenu)
                Console.WriteLine(s);
        }
    }
}
