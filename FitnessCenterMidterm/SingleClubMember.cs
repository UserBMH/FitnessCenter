using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class SingleClubMember : Members
    {
        public Club AssignedClub { get; set; }                      

        public SingleClubMember(int _id, string _name, Club _assignedClub, string _membership)
        {
            Id = _id;
            Name = _name;
            AssignedClub = _assignedClub;
            Membership = _membership;
        }
        public override void CheckIn(Club club)
        {
            if (club == AssignedClub)
            {
                Console.WriteLine("Hi, thanks checking in.");
            }
            else
            {
                Console.WriteLine("Sorry, you're not a member of this club.");
            }
        }
    }
}
