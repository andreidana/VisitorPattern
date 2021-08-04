using VisitorExample.Visitor;

namespace VisitorExample
{
    internal class Program
    {
        private static void Main()
        {
            var houses = new Houses();

            houses.VisitHouse(new Trailer());
            houses.VisitHouse(new Mansion());

            houses.Accept(new TrailerVisitor());
            houses.Accept(new MansionVisitor());
        }
    }
}
