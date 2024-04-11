using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using System.Xml.Linq;


namespace Merchant_s_Hub
{
    internal class Program
    {
        /*static string connectionString = "server=localhost;port=3306;user=root;password=031015@Keshab;database=merchant_hub";
        static MySqlConnection connection = new MySqlConnection(connectionString);*/
        static string connectionString = "server=localhost;port=3306;user=root;password=Qwer123@#;database=merchant_hub";
        static MySqlConnection connection = new MySqlConnection(connectionString);
        static void Main(string[] args)
        {

            DisplayFrontmenu();

        }
        static void DisplayFrontmenu()
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


        }
        static void RetrivingData()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ******************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" *    Welcome to Retriving Data Section     *");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ******************************************");
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
                Console.WriteLine(" ************************************************");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" *     Welcome to Beginner-Level Data Section     *");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" ************************************************");
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
                Console.WriteLine(" ************************************************");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" *    Welcome to Intermediate-Level Data Section  *");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" ************************************************");
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
                Console.WriteLine(" ************************************************");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" *      Welcome to Advanced-Level Data Section    *");
                Console.WriteLine(" *                                                *");
                Console.WriteLine(" ************************************************");
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
        static void DisplayMenuOfCustomerMangement()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ******************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" *        Menu of Customer Modification     *");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Please choose from the following Options:");
            Console.WriteLine();
            Console.WriteLine(" 1. Modifying the Costomer");
            Console.WriteLine(" 2. View Custome Details");
            Console.WriteLine(" 3. View Customer Types");
            Console.WriteLine(" 4. Search for Customers by their types.");
            Console.WriteLine(" 5. Go Back to Root of Database");
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
                        ViewCustomers();
                        break;
                    case 3:
                        SeeCustomerType();
                        break;
                    case 4:
                        SearchCustomer();
                        break;
                    case 5:
                        DisplayofRootofDatabase();
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
        static void ModifyCustomer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ******************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" *        Menu of Customer Modification     *");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ******************************************");
            Console.ForegroundColor = ConsoleColor.White;
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
                        AddCustomer();
                        break;
                    case 2:
                        // Update the costomer
                        break;
                    case 3:
                        deleteCustomer();
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
        static void AddCustomer()
        {
            ViewCustomers();

            Console.Write("\n\tEnter the customer ID: ");
            string Customer_Id = Console.ReadLine();

            Console.Write("\n\tEnter the customer name: ");
            string Customer_name = Console.ReadLine();

            Console.Write("\n\tEnter the customer phone: ");
            string Customer_phone = Console.ReadLine();

            Console.Write("\n\tEnter the customer email: ");
            string Customer_email = Console.ReadLine();

            Console.Write("\n\tEnter the date became customer (yyyy-mm-dd): ");
            string Date_became_customer = Console.ReadLine();


            Console.Write("\n\tEnter the customer type code between (1-10): ");
            if (!int.TryParse(Console.ReadLine(), out int Customer_Types_Code))
            {
                Console.WriteLine("Invalid Customer Type ID. Please enter a valid integer.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = $"Insert into customers (Customer_Id, Customer_name, Customer_phone, Customer_email, Date_became_customer, customer_types_code) values ('{Customer_Id}', '{Customer_name}', '{Customer_phone}', '{Customer_email}', '{Date_became_customer}', '{Customer_Types_Code}');";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("\n\tCustomer added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\n\tFailed to add customer.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.ReadLine();

            DisplayMenuOfCustomerMangement();
        }
        static void deleteCustomer()
        {
            Console.Write("Enter Customer ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int customer_ID))
            {
                Console.WriteLine("Invalid Customer ID. Please enter a valid integer.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string deleteQuery = $"DELETE FROM accounts WHERE customer_id = {customer_ID};DELETE FROM customers WHERE customer_id = {customer_ID}; ";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@authorId", customer_ID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Customer deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete Customer. Customer ID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            DisplayMenuOfCustomerMangement();
            Console.ReadKey();
        }
        
        static void DisplayCustomerDetails()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=031015@Keshab;database=merchant_hub";

            MySqlConnection connection = new MySqlConnection(connectionString);


            try
            {
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string selectCustomers = @"SELECT
                                Customer_ID
                                , Customer_name
                                , Customer_Phone
                                , Customer_email
                                , Customer_Types_code
                                , Other_details
                            FROM

                                Customers;";
                MySqlCommand command = new MySqlCommand(selectCustomers, connection);

                MySqlDataReader reader = command.ExecuteReader();



                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *         Customer Details                 *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.White;

                while (reader.Read())
                {
                    Console.WriteLine($"\t{reader["Customer_ID"].ToString().PadRight(10)}\t{reader["Customer_name"].ToString().PadRight(10)}\t{reader["Customer_Phone"].ToString().PadRight(10)}\t{reader["Customer_email"].ToString().PadRight(10)}\t{reader["Customer_Types_code"].ToString().PadRight(10)}\t{reader["Other_details"].ToString().PadRight(10)}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }


            connection.Close();


            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();


        }
        static void DisplayMenuOfMerchantMangement()
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
        static void ModifyMerchant()
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

        static void SearchMerchant()
        {
            //code to search merchant
        }

        static void DisplayMenuofCustomerTypeManagement()
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
        static void ModifyCustomerType()
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
        static void DisplayofAccountManagement()
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
        static void ModifyAccount()
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
        static void DisplayProductandServiceManagement()
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
        static void ModifyProductandServices()
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
        static void DisplayCustomerPurchaseManagement()
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
        static void ModifyCustomerPurchase()
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
        static void DisplayTransactionManagement()
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
        static void ModifyTransaction()
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
}
