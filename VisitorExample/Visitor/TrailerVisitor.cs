using System;

namespace VisitorExample.Visitor
{
    public class TrailerVisitor: IVisitor
    {
        public void Visit(IHouse house)
        {
            Console.WriteLine("Visited trailer");
        }
    }
}