namespace Merchant_s_Hub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ********************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" *          Welcome to Merchant Hub         *");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ********************************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("This application helps user to view and search for customer, merchant, and account information in the database!");
            Console.WriteLine();
            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine();
            Console.WriteLine(" 1. Root of Merchant Hub");
            Console.WriteLine(" 2. Retriving Data");
            Console.WriteLine(" 3. Exit");

            Console.WriteLine();
            Console.Write("Enter your choice: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayofRootofDatabase();
                        break;
                    case 2:
                        RetrivingData();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
        static void DisplayofRootofDatabase()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" *******************************************");
            Console.WriteLine(" *                                         *");
            Console.WriteLine(" *     Welcome to Root of Merchant Hub     *");
            Console.WriteLine(" *                                         *");
            Console.WriteLine(" *******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You are in direct control of Database and can edit everything in the database!! It include Adding, Updating or Deleating the data!!!");
            Console.WriteLine();
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine();
            Console.WriteLine(" 1. Customer Management");
            Console.WriteLine(" 2. Merchant Management");
            Console.WriteLine(" 3. Customer Type Management");
            Console.WriteLine(" 4. Account Management");
            Console.WriteLine(" 5. Product and Service Management");
            Console.WriteLine(" 6. Purchase Management");
            Console.WriteLine(" 7. Transaction Management");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayMenuOfCustomerMangement();
                        break;
                    case 2:
                        DisplayMenuOfMerchantMangement();
                        break;
                    case 3:
                        DisplayMenuofCustomerTypeManagement();
                        break;
                    case 4:
                        DisplayofAccountManagement();
                        break;
                    case 5:
                        DisplayProductandServiceManagement();
                        break;
                    case 6:
                        DisplayCustomerPurchaseManagement();
                        break;
                    case 7:
                        DisplayTransactionManagement();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            void DisplayMenuOfCustomerMangement()
            {

            }
            void DisplayMenuOfMerchantMangement()
            {

            }
            void DisplayMenuofCustomerTypeManagement()
            {

            }
            void DisplayofAccountManagement()
            {

            }
            void DisplayProductandServiceManagement() 
            { 

            }
            void DisplayCustomerPurchaseManagement()
            {
                
            }
            void DisplayTransactionManagement() 
            {

            }
        }
        static void RetrivingData()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ********************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" *    Welcome to Retriving Data Section     *");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ********************************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("This is for looking all the data of the database. Here, you can get important information related to the database.");
            Console.WriteLine();
            Console.WriteLine("Please Choose from the following options: ");
            Console.WriteLine();
            Console.WriteLine("1. Beginner-Level Data");
            Console.WriteLine("2. Intermediate-Level Data");
            Console.WriteLine("3. Advanced-Level Data");
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BeginnerLevelData();
                        break;
                    case 2:
                        IntermediateLevelData();
                        break;
                    case 3:
                        AdvancedLevelData();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            void BeginnerLevelData()
            {

            }
            void IntermediateLevelData()
            {

            }
            void AdvancedLevelData()
            {

            }
        }
    }
}