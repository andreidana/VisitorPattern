namespace VisitorExample.Visitor
{
    public class House: IHouse
    {
        public string Address { get; set; }
        public string City { get; set; }

        public House(string address, string city)
        {
            Address = address;
            City = city;
        }

        public void AcceptVisit(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}