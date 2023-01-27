// See https://aka.ms/new-console-template for more information

// THIS PETSTORE CODE CAN BE IMPROVED DRAMATICALLY. THIS IS JUST A START TO BEGIN LEARNING AND CAN BE USED FOR FUTURE REFERENCE. CONSIDER IT A SANDBOX.

using PetStore;

string userInput = "";
List<DogLeash> dogLeashList = new List<DogLeash>();
List<CatFood> catFoodList = new List<CatFood>();

while(userInput.ToLower() != "exit")
{
    Console.WriteLine("Press 1 to add dog leash");
    Console.WriteLine("Press 2 to add cat food");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine() + "";
    
    if (userInput == "1")
    {
        // USE LIST WITH CURLY BRACES TO SET VALUES. SAME RESULT AS BELOW. I PREFER THIS.
        var dogLeash = new DogLeash()
        {
            Name = "Fancy Leash",
            Price = 2,
            Quantity = 50,
            Description = "It is, as the name implies, a fancy leash.",
            LengthInches = 60,
            Material = "Nylon"
        };
        // ADD ABOVE VALUES TO LIST
        dogLeashList.Add(dogLeash);

    }else if (userInput == "2")
    {
        // USE DOT NOTATION TO SET VALUES. SAME RESULT AS ABOVE
        var catFood = new CatFood(); 

        catFood.Name = "Fancy Feast";
        catFood.Price = 4;
        catFood.Quantity = 50;
        catFood.Description = "Basically just tuna... My favorite.";
        catFood.WeightPounds = 20;
        catFood.KittenFood = true;
        
        // ADD ABOVE VALUES TO LIST
        catFoodList.Add(catFood);
    }

    Console.WriteLine($"Dog Leash Product Count: {dogLeashList.Count()}");
    Console.WriteLine($"Cat food product count: {catFoodList.Count()}");
}