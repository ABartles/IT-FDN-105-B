using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07
{
    public struct Pet       // Declare the 'Pet' structure.
    {
        public string Name;     // Field initialization.
        public string TypeOfPet;        // Field initialization.
    }
    class Program
    {
        static void Main()
        {
        var numberOfPets = 0;       // Initilizes  the number of pets at zero.
        var pets = new Pet[10];     // Initilize the stucture. 

        while(true)     // Starts the while loop. The code as provided won't evaluate to false, therefore won't exit on its own. 
        {
            Console.Write("A: Add, D: Delete or L: List pets.");        // displays the options to the user.
            var choice = Console.ReadLine();        // Collects user input and stores it to the varible 'choice'.

            switch (choice)     // This switch statement will faclilitate the correct switch section or case to run based on the user input. 
            {
                // This block will run the code nessisary to add a pet/type.
                case "A":       // Used to catch if the user enters a capitalized 'a'
                case "a":       // Used to catch if the user enters a lowercase 'a'
                        {
                        Console.Write("Name: ");    // Ask user for the Name of the pet.
                        var name = Console.ReadLine();      // Collects the users input and stores it to the varible 'name'.
                        Console.Write("Type of pet: ");     // Asks the user the type of pet.
                        var typeOfPet = Console.ReadLine();     // Collects the users input and stores it to the varible 'typeOfPet'

                        // Always add the pet to the end of the array
                        pets[numberOfPets].Name = name;     // loads the name entered to the last position in the aray 'pets'.
                        pets[numberOfPets].TypeOfPet = typeOfPet;       // loads the type of pet entered to the last position in the aray 'pets'.

                            numberOfPets++;     // incriments number of pets so it is not overwritten if another pet is added
                        break;
                    }
                    // This block will run the code nessisary to delete a pet/type.
                    case "D":       // Used to catch if the user enters a capitalized 'd'
                    case "d":       // Used to catch if the user enters a lowercase 'd'
                        {
                        if(numberOfPets == 0)       // this conditional statement checks if there are no pets listed in the pets array.
                        {
                            Console.WriteLine("No pets to delete.");        // Displays a message if there are no pets
                            break;      // Breaks(exits) from case D/d
                        }
                        for (var index = 0; index < numberOfPets; index++ )     // Sets index to 0, evaluates index to be less than # of pets, and incriments index after its used.
                        {
                            Console.WriteLine("{0}. {1,-10}{2}", index + 1, pets[index].Name, pets[index].TypeOfPet); // If index is evaluated to be less than # of pets this will list the names/types & pos in the array.
                        }
                        
                        Console.WriteLine("Which pet would you like to remove (1-{0})?", numberOfPets); // Asks the user what pet they would like to remove from the array. (will grow with the array)

                        var petNumberToDelete = Console.ReadLine();     // Collects the users input and stores it to the varible 'petNumberToDelete'
                        var indexToDelete = int.Parse(petNumberToDelete);       // converts the user intered string to an int and stores it to the varible 'indexToDelete'.
                        
                        for (var index = indexToDelete - 1; index < numberOfPets; index++)  // sets index to the array pos associated to the item the user would like to remove, evaluates if index is less than # of pets, incriments index after its used.
                        {
                            pets[index] = pets[index + 1];  // Overwrites the pet at the 'index' pos in pets with the next pet in the array
                        }
                        // we have one less pet.
                        {
                            numberOfPets--;     // incriments number of pets down after it is used.
                            break;      // Breaks(exits) from case D/d
                            }
                    }
                    // This block will run the code nessisary to list the index, pet/type.
                    case "L":   // Used to catch if the user enters a capitalized 'l'
                    case "l":   // Used to catch if the user enters a lowercase 'l'
                        {
                        if (numberOfPets == 0)  // evaluates if the number of pets is zero.
                        {
                            Console.WriteLine("No pets.");      // if the number of pets is zero it will print 'No pets.'
                        }
                        for (int index = 0; index < numberOfPets; index++)  // for loop that sets index, evaluates index is less than # of pets, incriments index after its used
                        {
                            Console.WriteLine("{0}. {1,-10}{2}", index + 1, pets[index].Name, pets[index].TypeOfPet);   // If index is evaluated to be less than # of pets this will list the names/types & pos in the array.
                            }
                        break; // Breaks(exits) from case L/l
                        }
                    default:    // catches user inputs other than; D, d, A, a, L or l.
                        {
                        Console.WriteLine("Invalid option [{0}]", choice);  // displays error message to user
                        break; // Breaks(exits) from case L/l
                        }
            }
        }
        }
    }
}
