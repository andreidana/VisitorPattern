using System.Collections.Generic;

namespace VisitorExample.Visitor
{
    public class Houses
    {
        private List<IHouse> _housesVisited = new List<IHouse>();

        public void VisitHouse(IHouse house)
        {
            _housesVisited.Add(house);
        }

        public void RemoveHouse(IHouse house)
        {
            _housesVisited.Remove(house);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var house in _housesVisited)
            {
                house.AcceptVisit(visitor);
            }
        }
    }
}