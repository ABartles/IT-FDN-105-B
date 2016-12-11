using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFinal
{
    public struct ItemData
    {
        public int itemIDNo;
        public string sDescription;
        public double dblPricePerItem;
        public int iQuantityOnHand;
        public double dblOurCostPerItem;
        public double dblValueOfItem;

    }



    // Gen class for holding a menu of options and processing the users choice
    class UserChoices
    {
        // intilize
        int userchoice = 0;
        
        // Print avalible options
        public void Options()
        {
            Console.WriteLine("Options:"); // header
            Console.Write(
                            "Option 1: Add Item\n" +
                            "Option 2: Change Item\n" +
                            "Option 3: Delete Item\n" +
                            "Option 4: List All Items\n" +
                            "Option 5: Exit Program\n"
                );
        }
        
        // Print avalible options
        public void UserChoice()
        {
            Console.Write("Please select an option (1 thr 5): ");
            string strx = Console.ReadLine();
            userchoice = int.Parse(strx);
            Console.WriteLine(); // format
        }

        // return choice
        public int ReturnChoice
        {
          get
            {
                return userchoice;
            }
        }
    }


    
    // Gen class for holding items related to an inventory; add, delete, list, change
    class Inventory
    {
        // create an object
        public ItemData[] itemdata = new ItemData[100];
        
        // initilize 
        int NumOfItems = 0;
        
        
        public void Add()   // Adds an item to an array
        {
            if (NumOfItems <= 100)
            {
                // Prompts user for entery, collects & converts user entery.
                Console.Write("Item ID: "); string sid = Console.ReadLine(); int id = int.Parse(sid);
                Console.Write("Item Description: "); string desc = Console.ReadLine();
                Console.Write("Price Per Item: "); string sppi = Console.ReadLine(); double ppi = double.Parse(sppi);
                Console.Write("Item Qty On Hand: "); string sqtyoh = Console.ReadLine(); int qtyoh = int.Parse(sqtyoh);
                Console.Write("Cost Per Unit: "); string scpi = Console.ReadLine(); double cpi = double.Parse(scpi);
                Console.WriteLine(); // fomrat
                // Writes to array.
                itemdata[NumOfItems].itemIDNo = id;
                itemdata[NumOfItems].sDescription = desc;
                itemdata[NumOfItems].dblPricePerItem = ppi;
                itemdata[NumOfItems].iQuantityOnHand = qtyoh;
                itemdata[NumOfItems].dblOurCostPerItem = cpi;
                itemdata[NumOfItems].dblValueOfItem = ((itemdata[NumOfItems].dblPricePerItem - itemdata[NumOfItems].dblOurCostPerItem) * itemdata[NumOfItems].iQuantityOnHand);

                // Increment
                NumOfItems++; 
            }
            else
            {
                Console.WriteLine(
                    "You have reached your max 100 itmes." + 
                    "Please delete an item if before adding an additional item."
                    );
                Console.WriteLine(); // format
            }
        }

        
        public void Delete()    // Deletes an item from an array
        {
            if (NumOfItems > 0)
            {
                // Prompt user, collect & convert user input
                Console.Write("Please enter the item ID of the item you would like to remove: ");
                string struserid = Console.ReadLine();
                int userid = int.Parse(struserid);
                bool fDeleted = false;

                for(int x = 0; x < NumOfItems; x++)
                {
                    if (itemdata[x].itemIDNo == userid)
                    {
                        fDeleted = true;
                        NumOfItems--;
                        for(; x <= NumOfItems; x++)
                        {
                            itemdata[x] = itemdata[x + 1];
                        }
                    }
                }

                if (fDeleted == true)
                {
                    Console.WriteLine("Item {0} deleted.", userid);
                    Console.WriteLine(); // format
                }
                else
                {
                    Console.WriteLine("Item {0} not found.", userid);
                    Console.WriteLine(); // format
                }
            }
        }

        
        public void Change()    // Changes an item in an array
        {
            if (NumOfItems > 0)
            {
                // Prompt user, collect & convert user input
                Console.Write("Please enter an item ID No: ");
                string strchgid = Console.ReadLine();
                int chgid = int.Parse(strchgid);

                int y = 0;
                bool fFound = false;

                for (int x = 0; x <= NumOfItems; x++)
                {
                    y = x;
                    if (itemdata[x].itemIDNo == chgid)
                    {
                        fFound = true;
                        Console.Write("New Item ID: "); string sid = Console.ReadLine(); int id = int.Parse(sid);
                        Console.Write("New Item Description: "); string desc = Console.ReadLine();
                        Console.Write("New Price Per Item: "); string sppi = Console.ReadLine(); double ppi = double.Parse(sppi);
                        Console.Write("New Item Qty On Hand: "); string sqtyoh = Console.ReadLine(); int qtyoh = int.Parse(sqtyoh);
                        Console.Write("New Cost Per Unit: "); string scpi = Console.ReadLine(); double cpi = double.Parse(scpi);

                        itemdata[x].itemIDNo = id;
                        itemdata[x].sDescription = desc;
                        itemdata[x].dblPricePerItem = ppi;
                        itemdata[x].iQuantityOnHand = qtyoh;
                        itemdata[x].dblOurCostPerItem = cpi;
                        itemdata[x].dblValueOfItem = ((itemdata[x].dblPricePerItem - itemdata[x].dblOurCostPerItem) * itemdata[x].iQuantityOnHand);

                    }
                }
                if (fFound == false)
                {
                    Console.WriteLine("Item {0} not found.", chgid);
                    Console.WriteLine(); // format
                }
                else
                {
                    Console.WriteLine("Item {0} has been replaced by {1}.", chgid, itemdata[y].itemIDNo);
                    Console.WriteLine(); // format
                }
            }
        }

        
        public void List()  // Lists an all items in an array
        {

            if (NumOfItems > 0)
            {
                // Print Header
                Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                // for each item in array print item
                for (int x = 0; x < NumOfItems; x++)
                {
                    Console.Write("{0,5}  ", x);
                    Console.Write("{0,6}  ", itemdata[x].itemIDNo);
                    Console.Write("{0,-20}  ", itemdata[x].sDescription);
                    Console.Write("{0,5}  ", itemdata[x].dblPricePerItem);
                    Console.Write("{0,3}  ", itemdata[x].iQuantityOnHand);
                    Console.Write("{0,4}  ", itemdata[x].dblOurCostPerItem);
                    Console.Write("{0,5}  ", itemdata[x].dblValueOfItem);
                    Console.WriteLine();
                }
                Console.WriteLine("----------------------------------------------------------------"); // footer
                Console.WriteLine(); // Format
            }        
            else
            {
                Console.WriteLine("There are no items in the list.");
                Console.WriteLine(); // Format

            }
        }
    }


    // Program allowing user to create a temp inventory, will delete on exit
    class Program
    {
        static void Main()
        {
            // Create objects
            UserChoices userchoices = new UserChoices();
            Inventory inventory = new Inventory();

            // initilize 
            bool exit = false;

            while (exit == false)
            {
                // Print options & collect users choice
                userchoices.Options();  
                userchoices.UserChoice();

                // 
                switch (userchoices.ReturnChoice)
                {
                    // add an item to the list if this option is selected
                    case 1: 
                        {
                            inventory.Add();
                            break;
                        }
                    // add an item to the list if this option is selected
                    case 2:
                        {
                            inventory.List();
                            inventory.Change();
                            break;
                        }
                    // delete items in the list if this option is selected
                    case 3:
                        {
                            inventory.List();
                            inventory.Delete();
                            break;
                        }
                    // list all items in current database if this option is selected
                    case 4:
                        {
                            inventory.List();
                            break;
                        }
                    // quit the program if this option is selected
                    // exit is in the main because it is not an attribute of inventories or nessisarly user options.
                    case 5: 
                        {
                            Console.Write(
                                "All data will be lost.\n" +
                                "Are you sure you would like to exit (y/n)? "
                                );
                            string exitx = Console.ReadLine();

                            if ((exitx == "y") || (exitx == "Y"))   // Handle capitalization
                            {
                                exit = true;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Option, try again");
                            Console.WriteLine(); // Format
                            break;
                        }
                }
            }
        }
    }
}
