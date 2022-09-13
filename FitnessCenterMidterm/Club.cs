using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class Club
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double MemberFee { get; set; }

        public Club(string name, string address, double _memberFee)

        {
            Name = name;
            Address = address;
            MemberFee = _memberFee;
        }
    }
}
