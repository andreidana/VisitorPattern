using VisitorExample.Visitor;

namespace VisitorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var houses = new Houses();

            houses.VisitHouse(new Trailer());
            houses.VisitHouse(new Mansion());

            houses.Accept(new TrailerVisitor());
            houses.Accept(new MansionVisitor());
        }
    }
}
