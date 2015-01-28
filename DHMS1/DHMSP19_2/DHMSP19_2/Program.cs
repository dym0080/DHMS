using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("LeafA"));
            root.Add(new Leaf("LeafB"));


            Composite comp = new Composite("Coposite X");
            comp.Add(new Leaf("leafXA"));
            comp.Add(new Leaf("leafXB"));

            root.Add(comp);

            Composite comp2 = new Composite("Composite XY");
            comp2.Add((new Leaf("leafXYA")));
            comp2.Add((new Leaf("leafXYB")));
            comp.Add(comp2);

            root.Add(new Leaf("Leaf C"));
            Leaf leaf=new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
            Console.Read();

        }
    }
}
