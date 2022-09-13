using FitnessCenterMidterm;

//Instance of Club list
List<Club> clubs = new List<Club>()
{
    new Club("Planet Fitness","123 Sesame Street", 10),
    new Club("Gold's Gym", "420 Swole Avenue", 30),
    new Club("Lifetime Fitness","69420 Qu1cksc0p3 Boulevard", 50),
    new Club("Globo-Gym", "52 Discovery, Irvine, CA 92618", 100),
    new Club("Multi-Club", "Multiple Addresses", 120),
};

List<Members> memberList = new List<Members>()
{
    new SingleClubMember(1, "Jordan", clubs[0], "Single")
};

//Main loop for menu and initial prompts
bool runProgram = true;
string name = "";

Console.WriteLine("Welcome to this program for gym membership\n");
do
{
    //Main menu listing
    for (int i = 0; i < clubs.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {clubs[i].Name}");
    }

    //Join, remove, or information functionality
    while (true)
    {
        Console.WriteLine("\nWhat is your name?\n");
        name = Console.ReadLine();
        Console.WriteLine("Are you looking to Enter gym, Join, Leave, Info or Quit? Type (Enter/Join/Leave/Info/Quit)");
        string addremove = Console.ReadLine().ToLower().Trim();

        //Add block
        if (addremove == "join")
        {
            Add();
        }

        //Remove block
        else if (addremove == "leave")
        {
            Remove();
        }
        //Info block
        else if (addremove == "info")
        {
            Info();
        }
        //Enter block
        else if (addremove == "enter")
        {
            Console.WriteLine("What location would you like to visit? (Enter number)");
            int enter = int.Parse(Console.ReadLine());

            if (enter >= 1 && enter <= clubs.Count() + 1)
            {
                memberList.Where(m => m.Name == name).First().CheckIn(clubs[enter - 1]);
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("go away then");
            }
        }
        //Quit block
        else
        {
            Console.WriteLine("Okay have a great day");
            runProgram = false;
            break;
        }
    }
}
while (runProgram);

//Add club method
void Add()
{
    Console.WriteLine("Which club would you like to join?");
    int choice = (int.Parse(Console.ReadLine().ToLower().Trim()));

    if (choice - 1 >= 0 && choice < clubs.Count + 1)
    {
        Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");


        memberList.Add(new SingleClubMember(memberList.Count() + 1, name, clubs[choice - 1], "Single"));
    }
    else if (choice == clubs.Count + 1)
    {
        Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");

        memberList.Add(new MultiClubMember(memberList.Count() + 1, name, clubs[choice - 1], "Multi"));
    }
    else
    {
        Console.WriteLine($"Incorrect number, try again");
    }
}

//Remove club method
void Remove()
{
    Members m = memberList.FirstOrDefault(m => m.Name == name);

    if (m != null)
    {
        memberList.Remove(m);

        Console.WriteLine($"{m.Name}, you've been removed from that club");
    }
}
//User info method
void Info()
{
    bool foundMember = false;

    foreach (Members m in memberList)
    {
        if (m.Name.Equals(name))
        {
            foundMember = true;
            //if singleclub memeber display else mutli club
            if (m.Membership.Equals("Single"))
            {
                SingleClubMember sm = m as SingleClubMember;
                Console.WriteLine($"Name: {sm.Name} \nID: {sm.Id} \nClub Name: {sm.AssignedClub.Name} \nClub Address: {sm.AssignedClub.Address} \n Fees: {sm.AssignedClub.MemberFee}");
            }
            else
            {
                MultiClubMember mm = m as MultiClubMember;
                Console.WriteLine($"Name: {mm.Name} \nID: {mm.Id} \nClub Name: {mm.AssignedClub.Name} \nClub Address: {mm.AssignedClub.Address} \nMember Points: {mm.memberPoints}" +
                $"\nFees: {mm.AssignedClub.MemberFee}");
            }
        }
    }
    if (foundMember == false)
    {
        Console.WriteLine("You are not a part of a club.  Please join a club to display your info.");
    }
}
