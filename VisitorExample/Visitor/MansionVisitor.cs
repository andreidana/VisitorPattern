using System;

namespace VisitorExample.Visitor
{
    public class MansionVisitor: IVisitor
    {
        public void Visit(IHouse house)
        {
            Console.WriteLine("Mansion visited");
        }
    }
}