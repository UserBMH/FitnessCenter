using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class MultiClubMember : Members
    {
        public Club AssignedClub { get; set; }
        public int memberPoints { get; set; }
        

        public override void CheckIn(Club club)
        {
                Console.WriteLine("Hi, thanks checking in.");
                memberPoints += 10;                      
        }

        public MultiClubMember(int _id,string _name, Club _assignedClub, string _membership)
        {
            Id = _id;
            Name = _name;
            AssignedClub = _assignedClub;
            Membership = _membership;           
        }

    }
}
