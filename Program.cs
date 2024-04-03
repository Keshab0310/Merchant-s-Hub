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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Menu of Customer Modification     *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Modifying the Costomer");
                Console.WriteLine(" 2. View Custome Details");
                Console.WriteLine(" 3. Search for Customers");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            ModifyCustomer();
                            break;
                        case 2:
                            // View Customer Deetails
                            break;
                        case 3:
                            SearchCustomer();
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
            void SearchCustomer()
            {
                // Code here to search for the customer
            }
            void ModifyCustomer()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Menu of Customer Modification     *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Add the Costomer");
                Console.WriteLine(" 2. Update the Costomer");
                Console.WriteLine(" 3. Delete the costomer");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            // Add the costomer
                            break;
                        case 2:
                            // Update the costomer
                            break;
                        case 3:
                            // Delete the costomer
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
            void DisplayMenuOfMerchantMangement()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *         Menu of Merchant Management      *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Modify the Merchant");
                Console.WriteLine(" 2. View Merchant details");
                Console.WriteLine(" 3. Search for Merchant");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            ModifyMerchant();
                            break;
                        case 2:
                            // View and the Merchant details.
                            break;
                        case 3:
                            SearchMerchant();
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

            void ModifyMerchant()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Menu of Merchant Modification     *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Add the Merchant");
                Console.WriteLine(" 2. Update the Merchant");
                Console.WriteLine(" 3. Delete the Merchant");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            // Add the Merchant
                            break;
                        case 2:
                            // Update the Merchant
                            break;
                        case 3:
                            // Delete the Merchant
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

            void SearchMerchant()
            {
                //code to search merchant
            }

            void DisplayMenuofCustomerTypeManagement()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *    Menu of Customer Type Management      *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Modify the Customer Type");
                Console.WriteLine(" 2. View Customer type details");
                Console.WriteLine(" 3. Assign or change Customer type for Customers");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            ModifyCustomerType();
                            break;
                        case 2:
                            // View and the costomer details.
                            break;
                        case 3:
                            // Assign or change customer types for customers
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
            void ModifyCustomerType()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *    Menu of Customer Type Modification    *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Add the Customer Type");
                Console.WriteLine(" 2. Update the Customer Type");
                Console.WriteLine(" 3. Delete the Customer Type");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            // Add the Customer Type
                            break;
                        case 2:
                            // Update the Customer Type
                            break;
                        case 3:
                            // Delete the Customer Type
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
            void DisplayofAccountManagement()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Menu of Account Management        *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Modify the Accounts");
                Console.WriteLine(" 2. View Costomer type details");
                Console.WriteLine(" 3. Link Account to customers");
                Console.WriteLine(" 4. Assign or change customer type for customers");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            ModifyAccount();
                            break;
                        case 2:
                            // View and the Accounts details.
                            break;
                        case 3:
                            // Link Account to customers
                            break;
                        case 4:
                            // Assign or change Account types.
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
            void ModifyAccount()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Menu of Account Modification      *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Add the Account");
                Console.WriteLine(" 2. Update the Account");
                Console.WriteLine(" 3. Delete the Account");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            // Add the Account
                            break;
                        case 2:
                            // Update the Account
                            break;
                        case 3:
                            // Delete the Account
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
            void DisplayProductandServiceManagement()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *  Menu of Product and Service Management  *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Modify the Product and Service");
                Console.WriteLine(" 2. View Product and Service details");
                Console.WriteLine(" 3. Track quantities and other details");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            ModifyProductandServices();
                            break;
                        case 2:
                            // View and the Product and Services
                            break;
                        case 3:
                            // Assign or change Product and Services
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
            void ModifyProductandServices()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Menu of Product and Services      *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Add the Product and Services ");
                Console.WriteLine(" 2. Update the Product and Services ");
                Console.WriteLine(" 3. Product and Services ");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            // Add the Product and Services 
                            break;
                        case 2:
                            // Update the Product and Services 
                            break;
                        case 3:
                            // Delete the Product and Services 
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
            void DisplayCustomerPurchaseManagement()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Menu of Purchase Management       *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Modify Customer Purrchase");
                Console.WriteLine(" 2. Link Purchases to Customers and Products");
                Console.WriteLine(" 3. View customer Purchase History");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            ModifyCustomerPurchase();
                            break;
                        case 2:
                            // Link purchase to Customer and Products.
                            break;
                        case 3:
                            // View Customer Purchase history.
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
            void ModifyCustomerPurchase()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *  Menu of Customer Purchase Modification  *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Add the Customer Purchase");
                Console.WriteLine(" 2. Update the Customer Purchase");
                Console.WriteLine(" 3. Delete the Customer Purchase");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            // Add the Customer Purchase
                            break;
                        case 2:
                            // Update the Customer Purchase
                            break;
                        case 3:
                            // Delete the Customer Purchase
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
            void DisplayTransactionManagement()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *       Menu of Transaction Management     *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Modify the Transaction");
                Console.WriteLine(" 2. Link Transaction to accounts");
                Console.WriteLine(" 3. View Transaction history");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            ModifyTransaction();
                            break;
                        case 2:
                            // View and the Accounts details.
                            break;
                        case 3:
                            // Assign or change Account types.
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
            void ModifyTransaction()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *      Menu of Transaction Modification    *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                Console.WriteLine("Please choose from the following Options:");
                Console.WriteLine();
                Console.WriteLine(" 1. Add the Transaction");
                Console.WriteLine(" 2. Update the Transaction");
                Console.WriteLine(" 3. Delete the Transaction");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                try
                {
                    int subChoice = Convert.ToInt32(Console.ReadLine());

                    switch (subChoice)
                    {
                        case 1:
                            // Add the Transaction
                            break;
                        case 2:
                            // Update the Transaction
                            break;
                        case 3:
                            // Delete the Transaction
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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" **************************************************");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" *     Welcome to Beginner-Level Data Section     *");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" **************************************************");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Here You can get the Beginner Level data or Simple data of the database.");
                Console.WriteLine();
                Console.WriteLine("Please Choose from the following options: ");
                Console.WriteLine();
                Console.WriteLine("1.  Query 1");
                Console.WriteLine("2.  Query 2");
                Console.WriteLine("3.  Query 3");
                Console.WriteLine("4.  Query 4");
                Console.WriteLine("5.  Query 5");
                Console.WriteLine("6.  Query 6");
                Console.WriteLine("7.  Query 7");
                Console.WriteLine("8.  Query 8");
                Console.WriteLine("9.  Query 9");
                Console.WriteLine("10. Query 10");
                Console.WriteLine();
                Console.Write("Enter Your Choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            //
                            break;
                        case 2:
                            //
                            break;
                        case 3:
                            //
                            break;
                        case 4:
                            //
                            break;
                        case 5:
                            //
                            break;
                        case 6:
                            //
                            break;
                        case 7:
                            //
                            break;
                        case 8:
                            //
                            break;
                        case 9:
                            //
                            break;
                        case 10:
                            //
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
            void IntermediateLevelData()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" **************************************************");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" *    Welcome to Intermediate-Level Data Section  *");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" **************************************************");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Here You can get the Intermediate Level data or Medium level data of the database.");
                Console.WriteLine();
                Console.WriteLine("Please Choose from the following options: ");
                Console.WriteLine();
                Console.WriteLine("1.  Query 1");
                Console.WriteLine("2.  Query 2");
                Console.WriteLine("3.  Query 3");
                Console.WriteLine("4.  Query 4");
                Console.WriteLine("5.  Query 5");
                Console.WriteLine("6.  Query 6");
                Console.WriteLine("7.  Query 7");
                Console.WriteLine("8.  Query 8");
                Console.WriteLine("9.  Query 9");
                Console.WriteLine("10. Query 10");
                Console.WriteLine();
                Console.Write("Enter Your Choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            //
                            break;
                        case 2:
                            //
                            break;
                        case 3:
                            //
                            break;
                        case 4:
                            //
                            break;
                        case 5:
                            //
                            break;
                        case 6:
                            //
                            break;
                        case 7:
                            //
                            break;
                        case 8:
                            //
                            break;
                        case 9:
                            //
                            break;
                        case 10:
                            //
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
            void AdvancedLevelData()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" **************************************************");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" *      Welcome to Advanced-Level Data Section    *");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" **************************************************");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Here You can get the Advanced Level data or complex data of the database.");
                Console.WriteLine();
                Console.WriteLine("Please Choose from the following options: ");
                Console.WriteLine();
                Console.WriteLine("1.  Query 1");
                Console.WriteLine("2.  Query 2");
                Console.WriteLine("3.  Query 3");
                Console.WriteLine("4.  Query 4");
                Console.WriteLine("5.  Query 5");
                Console.WriteLine("6.  Query 6");
                Console.WriteLine("7.  Query 7");
                Console.WriteLine("8.  Query 8");
                Console.WriteLine("9.  Query 9");
                Console.WriteLine("10. Query 10");
                Console.WriteLine();
                Console.Write("Enter Your Choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            //
                            break;
                        case 2:
                            //
                            break;
                        case 3:
                            //
                            break;
                        case 4:
                            //
                            break;
                        case 5:
                            //
                            break;
                        case 6:
                            //
                            break;
                        case 7:
                            //
                            break;
                        case 8:
                            //
                            break;
                        case 9:
                            //
                            break;
                        case 10:
                            //
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
        }
    }
}
