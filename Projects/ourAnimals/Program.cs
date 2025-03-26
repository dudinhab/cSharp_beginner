// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

}

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
do
{
    // display the top-level menu options

    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    string idForChangeAgeInput = "";
    int positionId = -1;
    switch (menuSelection)
    {
        case "1":
            Console.WriteLine("This is a complete list:");
            //list animals
            for (int i = 0; i < maxPets; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        Console.WriteLine($"{i}: " + ourAnimals[i, j]);
                    }
                }
            }
            break;

        case "2":
            //add new animal
            //cat or dog, and id needs input, other is optional
            int empty = -1;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] == "ID #: ")
                {
                    empty = i;
                    break;
                }
            }
            Console.WriteLine("Input the new friend:");
            Console.WriteLine("Press any key to continue");
            Console.WriteLine("Input new ID:", ourAnimals[empty, 0] += Console.ReadLine());
            Console.WriteLine("input new Species: ", ourAnimals[empty, 1] += Console.ReadLine());
            Console.WriteLine("input new Age: ", ourAnimals[empty, 2] += Console.ReadLine());
            Console.WriteLine("input new Nickname: ", ourAnimals[empty, 3] += Console.ReadLine());
            Console.WriteLine("input new Physical description: ", ourAnimals[empty, 4] += Console.ReadLine());
            Console.WriteLine("input new Personality: ", ourAnimals[empty, 5] += Console.ReadLine());
            break;
        case "3":
            Console.WriteLine("This is a list when age or phisical description is empty:");
            //return ages and phisical description empty
            for (int i = 0; i < maxPets; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((ourAnimals[i, 0] != "ID #: ") && ((ourAnimals[i, 2] == "Age: ") || (ourAnimals[i, 2] == "Age: ?") || (ourAnimals[i, 4] == "Physical description: ")))
                    {
                        Console.WriteLine($"{i}: " + ourAnimals[i, j]);
                    }
                }
            }
            break;


        case "4":
            Console.WriteLine("This is a list when age or phisical description is empty:");
            //return name and personality description empty
            for (int i = 0; i < maxPets; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((ourAnimals[i, 0] != "ID #: ") && ((ourAnimals[i, 3] == "Nickname: ") || (ourAnimals[i, 5] == "Personality: ")))
                    {
                        Console.WriteLine($"{i}: " + ourAnimals[i, j]);
                    }
                }
            }
            break;
        case "5":
            //change age
            idForChangeAgeInput = "";
            positionId = -1;

            Console.WriteLine("Insert the id:");
            idForChangeAgeInput = Console.ReadLine();
            if ((idForChangeAgeInput != "") && (idForChangeAgeInput != null))
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] == ("ID #: " + idForChangeAgeInput))
                    {
                        positionId = i;
                    }
                }
            }

            if (positionId == -1)
            {
                Console.WriteLine("Id not found!");
            }
            else
            {
                Console.WriteLine("input new Age: ");
                ourAnimals[positionId, 2] = "ID #: " + Console.ReadLine();
                Console.WriteLine($"Age changed in id: {idForChangeAgeInput}");
            }


            break;
        case "6":
            //change personality description
            idForChangeAgeInput = "";
            positionId = -1;

            Console.WriteLine("Insert the id:");
            idForChangeAgeInput = Console.ReadLine();
            if ((idForChangeAgeInput != "") && (idForChangeAgeInput != null))
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] == ("ID #: " + idForChangeAgeInput))
                    {
                        positionId = i;
                    }
                }
            }
            Console.WriteLine("Press any key to continue");

            if (positionId == -1)
            {
                Console.WriteLine("Id not found!");
            }
            else
            {
                Console.WriteLine("input new description: ");
                ourAnimals[positionId, 2] = "Personality: " + Console.ReadLine();
                Console.WriteLine($"Age changed in id: {idForChangeAgeInput}");
            }
            break;
        case "7":
            //research cats with phisical description
            for (int i = 0; i < maxPets; i++)
            {
                if ((ourAnimals[i, 1] == "Species: cat") && (ourAnimals[i, 2] != "Physical description: "))
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            break;
        case "8":
            //research dogs with phisical description
            for (int i = 0; i < maxPets; i++)
            {
                if ((ourAnimals[i, 1] == "Species: dog") && (ourAnimals[i, 2] != "Physical description: "))
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            break;
        default:
            Console.WriteLine("Invalid input option! try again!");
            break;
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
} while (menuSelection != "exit");
