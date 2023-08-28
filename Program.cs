int[] ZeroThroughNine = new[]{0,1,2,3,4,5,6,7,8,9};
string[] Names = new[]{"Tim", "Martin", "Nikki", "Sara", "Josh"};
bool[] Truthy = new bool[10];

for (int i = 0; i < Truthy.Length; i++)
{   
    
    if(i%2==0){
        Truthy[i] = true;
        
    }
    Console.WriteLine(Truthy[i]);
}

List<string> IceCream = new();

IceCream.Add("Brown Sugar");
IceCream.Add("Cookies and Cream");
IceCream.Add("Vanilla");
IceCream.Add("Chocolate");
IceCream.Add("Ube");

Console.WriteLine(IceCream.Count);
Console.WriteLine(IceCream[2]);
IceCream.RemoveAt(2);
Console.WriteLine(IceCream.Count);


Dictionary<string,string> IceCreamProfile = new();
Random RandomFlavor = new();

IceCreamProfile.Add(Names[1],IceCream[RandomFlavor.Next(0,3)]);
IceCreamProfile.Add(Names[2],IceCream[RandomFlavor.Next(0,3)]);
IceCreamProfile.Add(Names[3],IceCream[RandomFlavor.Next(0,3)]);
IceCreamProfile.Add(Names[4],IceCream[RandomFlavor.Next(0,3)]);

foreach (KeyValuePair<string,string> User in IceCreamProfile)
{
    Console.WriteLine($"{User.Key}'s favorite ice cream is {User.Value}");
}
