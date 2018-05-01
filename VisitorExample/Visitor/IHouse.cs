namespace VisitorExample.Visitor
{
    public interface IHouse
    {
        void AcceptVisit(IVisitor visitor);
    }
}