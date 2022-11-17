//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ShoppingList
//{
//    public class ShopperInputValidation
//    {
//        bool userShopping = true;


//        string ValidGroceryChecker(string itemInput, Dictionary<string, decimal>GroceryMenuItems, ShopperPurchase<KeyValuePair>)
//        {
//            itemInput = char.ToUpper(itemInput[0]) + itemInput.Substring(1); //capitalizing first letter of user input. takes everything , past 1 and leaves it as such, then re-combines it into a single string

//            if (GroceryMenuItems.ContainsKey(itemInput))
//            {
//                ShopperPurchase.Add(itemInput);
//                return itemInput;
//            }
//            else if (itemInput == "Done")
//            {
//                userShopping = false;
//            }
//            else
//            {
//                Console.WriteLine("Invalid option. Please enter an item from the menu.");
//            }

//        }


//    }
//}
