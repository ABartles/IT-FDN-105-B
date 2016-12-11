

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {
        int optx;
        bool exit = false;
        int icount = 0;
        int NumOfItems = 0;
        var itemdata = new ItemData[100];


        // Will loop until the Exit option is selected by the user.
        while (exit == false)
        {
            Console.WriteLine();    // format 
            // Print options list
            Console.Write(
                            "Option 1: Add Item\n" +
                            "Option 2: Change Item\n" +
                            "Option 3: Delete Item\n" +
                            "Option 4: List All Items\n" +
                            "Option 5: Exit Program\n" +
                            "Please select an option (1 thru 5): "
                );
            string strx = Console.ReadLine();   // read user's input




            optx = int.Parse(strx); // convert the given string to integer to match our case types shown below
            Console.WriteLine();    // format

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {
                        
                        Console.Write("Item ID: "); string sid = Console.ReadLine(); int id = int.Parse(sid);                  
                        Console.Write("Item Description: "); string desc = Console.ReadLine();
                        Console.Write("Price Per Item: "); string sppi = Console.ReadLine(); double ppi = double.Parse(sppi);
                        Console.Write("Item Qty On Hand: "); string sqtyoh = Console.ReadLine(); int qtyoh = int.Parse(sqtyoh);
                        Console.Write("Cost Per Unit: "); string scpi = Console.ReadLine(); double cpi = double.Parse(scpi);


                        itemdata[NumOfItems].itemIDNo = id;
                        itemdata[NumOfItems].sDescription = desc;
                        itemdata[NumOfItems].dblPricePerItem = ppi;
                        itemdata[NumOfItems].iQuantityOnHand = qtyoh;
                        itemdata[NumOfItems].dblOurCostPerItem = cpi;
                        itemdata[NumOfItems].dblValueOfItem = ((itemdata[NumOfItems].dblPricePerItem - itemdata[NumOfItems].dblOurCostPerItem) * itemdata[NumOfItems].iQuantityOnHand);

                        NumOfItems++;
                        break;
                    }

                case 2: //change items in the list if this option is selected
                    {
                        // verifies the list has content 
                        if (NumOfItems == 0)
                        {
                            Console.WriteLine("There are no items in the list");
                            break;
                        }

                        // Prompt user for input
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        for (int x = 0; x <= NumOfItems; x++)
                        {
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

                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }
                        
                        break;
                        
                    }

                case 3: //delete items in the list if this option is selected
                    {
                        // verifies the list has content 
                        if (NumOfItems == 0)
                        {
                            Console.WriteLine("There are no items in the list");
                            break;
                        }

                        // Prompt user for input
                        Console.Write("Please enter the item ID of the item you would like to remove: ");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        for (int x = 0; x < NumOfItems; x++)    // loops through items
                        {
                            if (itemdata[x].itemIDNo == newid)  // checks if item ID matches what the user input & deletes if it evaluates to true
                            {
                                fDeleted = true;
                                NumOfItems--;
                                for (; x < NumOfItems; x++);
                                {
                                    itemdata[x-1] = itemdata[x];
                                }
                            }
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item {0} deleted", newid);
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", newid);
                        }
                        
                        break;
                        
                    }

                case 4:  //list all items in current database if this option is selected
                    {
                        
                        if (NumOfItems == 0)
                        {
                            Console.WriteLine("There are no items in the list.");
                            break;
                        }

                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");  // Header
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");  // Format

                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
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
                        Console.WriteLine("----------------------------------------------------------------");  // format

                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if ((strresp == "y") || (strresp == "Y"))
                        {
                            exit = true;
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }

        }

    }
}

class MainProgram
{

}
