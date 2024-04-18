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
        /*static string connectionString = "server=localhost;port=3306;user=root;password=Qwer123@#;database=merchant_hub";
          static MySqlConnection connection = new MySqlConnection(connectionString);*/
        static string connectionString = "server=127.0.0.1:3307;port=3307;user=root;password=riya8556@;database=merchant_hub";
        static MySqlConnection connection = new MySqlConnection(connectionString);
        /*static string connectionString = "server=localhost;port=3306;user=root;password=Anmol123$456;database=merchant_hub";
        static MySqlConnection connection = new MySqlConnection(connectionString);*/



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
            Console.WriteLine(" 3. Account Management");
            Console.WriteLine(" 4. Product and Service Management");
            Console.WriteLine(" 5. Purchase Management");
            Console.WriteLine(" 6. Transaction Management");
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
                        DisplayofAccountManagement();
                        break;
                    case 4:
                        DisplayProductandServiceManagement();
                        break;
                    case 5:
                        DisplayCustomerPurchaseManagement();
                        break;
                    case 6:
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
        static void SeeCustomerType()
        {

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string selectCustomerType = @"SELECT  
                                      Customer_Types_code,
                                      Customer_types_description
                                      FROM customer_types";
                MySqlCommand command = new MySqlCommand(selectCustomerType, connection);

                MySqlDataReader reader = command.ExecuteReader();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *        Customer Types Details            *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.White;

                while (reader.Read())
                {
                    Console.WriteLine($"\t{reader["Customer_Types_code"].ToString().PadRight(10)}\t{reader["Customer_Types_description"].ToString().PadRight(10)}");
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
        static void ViewCustomers()
        {


            try
            {
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string selectCustomers = @"SELECT
                        Customer_ID
                        , Customer_Types_code
                        , Customer_name
                        , Customer_Phone
                        , Customer_email
                        , Date_became_customer
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
                    Console.WriteLine($"\t{reader["Customer_ID"].ToString().PadRight(10)}\t{reader["Customer_Types_code"].ToString().PadRight(10)}\t{reader["Customer_name"].ToString().PadRight(10)}\t{reader["Customer_Phone"].ToString().PadRight(10)}\t{reader["Customer_email"].ToString().PadRight(10)}\t{reader["Date_became_customer"].ToString().PadRight(10)}");
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
        static void SearchCustomer()
        {

            Console.Write("\n\tEnter the customer type code between (1-10): ");
            if (!int.TryParse(Console.ReadLine(), out int Customertypeid))
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
                    string searchQuery = $"Select * From customers where customer_types_code = {Customertypeid};";
                    MySqlCommand command = new MySqlCommand(searchQuery, connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Console.WriteLine("\n\tCustomer Details:");
                        Console.WriteLine("\t------------------");
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                            Console.WriteLine($"\t Customer {count}:");
                            Console.WriteLine($"\tCustomer ID: {reader["Customer_id"]}");
                            Console.WriteLine($"\tCustomer Type Code: {reader["customer_types_code"]}");
                            Console.WriteLine($"\tCustomer Name: {reader["customer_name"]}");
                            Console.WriteLine($"\tCustomer Phone: {reader["customer_phone"]}");
                            Console.WriteLine($"\tCustomer Email: {reader["customer_email"]}");
                            Console.WriteLine($"\tDate became customer: {reader["Date_became_customer"]}");
                            Console.WriteLine("\t------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\tNo customer found with the given customer type code.");
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
                        ViewMerchants();
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
            Console.WriteLine(" ********************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" *        Menu of Merchant Modification     *");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ********************************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine("Please choose from the following Options:");
            Console.WriteLine();
            Console.WriteLine(" 1. Add the Merchant");
            Console.WriteLine(" 2. Update the Merchant");
            Console.WriteLine(" 3. Delete the Merchant");
            Console.WriteLine(" 4. Go Back to Merchant Management");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            try
            {
                int subChoice = Convert.ToInt32(Console.ReadLine());

                switch (subChoice)
                {
                    case 1:
                        AddMerchant();
                        break;
                    case 2:
                        // Update the M
                        break;
                    case 3:
                        deleteMerchant();
                        break;
                    case 4:
                        DisplayMenuOfMerchantMangement();
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
        static void AddMerchant()
        {
            Console.Write("\n\tEnter the Merchant ID: ");
            string merchant_id = Console.ReadLine();

            Console.Write("\n\tEnter the merchant name: ");
            string merchant_name = Console.ReadLine();

            Console.Write("\n\tEnter the merchant phone: ");
            string merchant_phone = Console.ReadLine();

            Console.Write("\n\tEnter the merchant email: ");
            string email = Console.ReadLine();

            Console.Write("\n\tEnter Others details: ");
            string other_details = Console.ReadLine();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = $"Insert into merchants (merchant_id, merchant_name, merchant_phone, email, other_details) values ('{merchant_id}', '{merchant_name}', '{merchant_phone}', '{email}', '{other_details}')";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("\n\tMerchant added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\n\tFailed to add merchant.");
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

            DisplayMenuOfMerchantMangement();
        }
        static void deleteMerchant()
        {
            Console.Write("Enter Merchant ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int Merchant_ID))
            {
                Console.WriteLine("Invalid Merchant ID. Please enter a valid integer.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string deleteQuery = $"DELETE FROM products_and_services WHERE Merchant_ID = '{Merchant_ID}';DELETE FROM Merchants WHERE Merchant_ID = '{Merchant_ID}'; ";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@Merchant_ID", Merchant_ID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Merchant deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete Merchant. Merchant ID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            DisplayMenuOfMerchantMangement();
            Console.ReadKey();
        }
        static void SearchMerchant()
        {
            Console.Write("\n\tEnter the merchant ID: ");
            string merchant_id = Console.ReadLine();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string searchQuery = $"Select * From merchants where merchant_id = {merchant_id};";
                    MySqlCommand command = new MySqlCommand(searchQuery, connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Console.WriteLine("\n\tMerchant Details:");
                        Console.WriteLine("\t------------------");
                        while (reader.Read())
                        {
                            Console.WriteLine($"\tMerchant ID: {reader["merchant_id"]}");
                            Console.WriteLine($"\tMerchant Name: {reader["merchant_name"]}");
                            Console.WriteLine($"\tMerchan Phone: {reader["merchant_phone"]}");
                            Console.WriteLine($"\tMerchan Email: {reader["email"]}");
                            Console.WriteLine($"\tOther details: {reader["other_details"]}");
                            Console.WriteLine("\t------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\tNo merchant found with the given name.");
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
            DisplayMenuOfMerchantMangement();

        }
        static void ViewMerchants()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string selectMerchant = @"SELECT
                          Merchant_ID
                        , Merchant_name
                        , Merchant_Phone
                        , Email
                        , Other_details
                    FROM

                        Merchants;";
                MySqlCommand command = new MySqlCommand(selectMerchant, connection);

                MySqlDataReader reader = command.ExecuteReader();



                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *         Merchant Details                 *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("MerchantID\tMerchant Name\t\tMerchant Phone\tMerchant Email\t\tOther Details\n");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Merchant_ID"].ToString().PadRight(10)}\t{reader["Merchant_name"].ToString().PadRight(20)}\t{reader["Merchant_Phone"].ToString().PadRight(10)}\t{reader["Email"].ToString().PadRight(20)}\t{reader["Other_details"].ToString().PadRight(10)}");
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
        static void DisplayofAccountManagement()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ******************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" --------Menu of Account Management--------");
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
            Console.WriteLine(" 5. Go back to ROot of database.");

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
                        ViewAccounts();
                        break;
                    case 3:
                        LinkAccount();
                        break;
                    case 4:
                        ChangeAccountType();
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
        static void ModifyAccount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ******************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" --------Menu of Account Modification------");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ******************************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("Please choose from the following Options:");
            Console.WriteLine();
            Console.WriteLine(" 1. Add the Account");
            Console.WriteLine(" 2. Update the Account");
            Console.WriteLine(" 3. Delete the Account");
            Console.WriteLine(" 4. Go back to thedisplay of Account");

            Console.WriteLine();
            Console.Write("Enter your choice: ");

            try
            {
                int subChoice = Convert.ToInt32(Console.ReadLine());

                switch (subChoice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        UpdateAccount();
                        break;
                    case 3:
                        DelteAccount();
                        break;
                    case 4:
                        DisplayofAccountManagement();
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
        static void AddAccount()
        {
            Console.Write("\n\tEnter the Account ID: ");
            string account_id = Console.ReadLine();

            Console.Write("\n\tEnter the Account name: ");
            string account_name = Console.ReadLine();

            Console.Write("\n\tEnter the Date opened: ");
            string date_opened = Console.ReadLine();

            Console.Write("\n\tEnter the Account Types code: ");
            string account_types_code = Console.ReadLine();

            Console.Write("\n\tEnter the Customer ID: ");
            string customer_id = Console.ReadLine();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = $"Insert into accounts (account_id, account_name, date_opened, account_types_code, customer_id) values ('{account_id}', '{account_name}', '{date_opened}', '{account_types_code}', '{customer_id}')";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("\n\tAccount added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\n\tFailed to add account.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to view updated Account...");
            Console.ReadKey();
            ViewAccounts();
        }
        static void UpdateAccount()
        {
            ViewAccounts();
            Console.Write("Enter Account ID to modify: ");
            if (!int.TryParse(Console.ReadLine(), out int account_id))
            {
                Console.WriteLine("Invalid Account ID. Please enter a valid Account ID.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("What do you want to modify?");
            Console.WriteLine("1. Account Name");
            Console.WriteLine("2. Account Phone");
            Console.WriteLine("3. Account email");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            string updatedValue = "";
            string assignedvalue = "";
            switch (choice)
            {
                case "1":
                    updatedValue = "account_name";
                    Console.Write("Enter new Account name: ");
                    assignedvalue = Console.ReadLine();
                    break;
                case "2":
                    updatedValue = "date_oppened";
                    Console.Write("Enter new date of Account: ");
                    assignedvalue = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Account SET {updatedValue} = @assignedvalue WHERE account_id = @account_id";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@assignedvalue", assignedvalue);
                    updateCommand.Parameters.AddWithValue("@account_id", account_id);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Account information updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to update Account information.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Here is the details of Merchant with new modifications.");
            Console.ReadLine();

            ViewMerchants();

        }
        static void DelteAccount()
        {
            Console.Write("Enter Account ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int Account_ID))
            {
                Console.WriteLine("Invalid Account ID. Please enter a valid Account ID.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string deleteQuery = $"DELETE FROM transaction WHERE Account_ID = '{Account_ID}';DELETE FROM Account WHERE Account_ID = '{Account_ID}'; ";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@Account_ID", Account_ID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Account deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete Account. Account ID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            DisplayofAccountManagement();
        }
        static void ViewAccounts()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string selectAccount = @"SELECT
                                     Account_Id
                                    , Account_name
                                    , Date_opened
                                    , Account_Types_code
                                    , Customer_ID
                                       FROM
                                        accounts;";
                MySqlCommand command = new MySqlCommand(selectAccount, connection);

                MySqlDataReader reader = command.ExecuteReader();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ******************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" -------------Account Details--------------");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ******************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Account ID\tAccount Name\t\tDate Opened\tAccount Type Code\tCustomer ID\t\n");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Account_Id"].ToString().PadRight(10)}\t{reader["Account_name"].ToString().PadRight(20)}\t{reader["Date_opened"].ToString().PadRight(10)}\t{reader["Account_Types_code"].ToString().PadRight(10)}\t{reader["Customer_ID"].ToString().PadRight(10)}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            connection.Close();
            Console.WriteLine("\n\nPress any key to go back to display menu of account...");
            Console.ReadLine();
            DisplayofAccountManagement();
        }
        static void LinkAccount()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string Join = "SELECT a.Account_Id, a.Account_name, a.Date_opened, a.Account_Types_code, a.Customer_ID, c.Customer_ID, c.Customer_name, c.Customer_phone, c.Customer_email, c.Date_became_customer, c.Customer_Types_code FROM accounts a JOIN customers c ON a.Customer_ID = c.Customer_ID";

                using (MySqlCommand command = new MySqlCommand(Join, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Acc Id\tAcc Name\tCustomer ID\tCustomer name\tCustomer email\tCustomer Date");
                        foreach (var row in reader)
                        {
                            Console.Write("{0}\t{1}\t", reader["Account_Id"], reader["Account_name"]);
                            Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", reader["Customer_ID"], reader["Customer_name"], reader["Customer_email"], reader["Date_became_customer"]);
                        }
                    }
                }
                Console.WriteLine("Accounts have been linked to customers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            connection.Close();
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
        }
        static void ChangeAccountType()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();

                Console.Write("Enter the customer ID: ");
                string customerId = Console.ReadLine();
                Console.Write("Enter the new account type code: ");
                string accountTypeCode = Console.ReadLine();

                string update = "UPDATE accounts SET Account_Types_code = @accountTypeCode WHERE Customer_ID = @customerId";
                using (MySqlCommand command = new MySqlCommand(update, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@accountTypeCode", accountTypeCode);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("{0} rows updated.", rowsAffected);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            connection.Close();
            Console.WriteLine("\n\nPress any key view updated ...");
            Console.ReadLine();
            ViewAccounts();
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();
        }
        static void DisplayProductandServiceManagement()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ********************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" --Menu of Product and Service Management--");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ********************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Please choose from the following Options:");
            Console.WriteLine();
            Console.WriteLine(" 1. Modify the Product and Service");
            Console.WriteLine(" 2. View Product and Service details");
            Console.WriteLine(" 3. Go back to Root menu.");

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
                        ViewProductandServices();
                        break;
                    case 3:
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
        static void ViewProductandServices()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string selectProductandServices = @"SELECT
                                     product_and_services_code
                                    , products_and_services_Description
                                    , Merchant_id
                                       FROM
                                        products_and_services;";
                MySqlCommand command = new MySqlCommand(selectProductandServices, connection);

                MySqlDataReader reader = command.ExecuteReader();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" *      Product and Services Details        *");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Product and Services Code \tProduct and Services Description \t\t Merchant_id\n");
                while (reader.Read())
                {
                    Console.WriteLine($"\t\t{reader["product_and_services_code"].ToString().PadRight(20)}\t{reader["products_and_services_Description"].ToString().PadRight(45)}\t{reader["Merchant_id"].ToString().PadRight(30)}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            connection.Close();
            Console.WriteLine("\n\nPress any key to go back to display menu...");
            Console.ReadLine();
            DisplayProductandServiceManagement();
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
            Console.WriteLine(" 3. Delete Product and Services ");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            try
            {
                int subChoice = Convert.ToInt32(Console.ReadLine());

                switch (subChoice)
                {
                    case 1:
                        AddPandS();
                        break;
                    case 2:
                        UpdatePandS();
                        break;
                    case 3:
                        deletePandS();
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
        static void AddPandS()
        {
            Console.Write("\n\tEnter the Product and Services Code: ");
            string product_and_services_code = Console.ReadLine();

            Console.Write("\n\tEnter the Product and Services Description: ");
            string products_and_services_Description = Console.ReadLine();

            Console.Write("\n\tEnter the Customer ID: ");
            string customer_id = Console.ReadLine();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = $"Insert into accounts (product_and_services_code, products_and_services_Description,customer_id) values ('{product_and_services_code}', '{products_and_services_Description}', '{customer_id}')";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Product and Services Added Successfully added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\n\tFailed to add Product and Services.");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            connection.Close();
            Console.WriteLine("Press any key to view updated Product and Services...");
            Console.ReadKey();
            Console.ReadLine();
            ViewProductandServices();
        }
        static void UpdatePandS()
        {

            Console.Write("Enter Product and Services Code to modify: ");
            if (!int.TryParse(Console.ReadLine(), out int product_and_services_code))
            {
                Console.WriteLine("Invalid Product and Services Code. Please enter a valid code.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Do you want to modify Product and Services description?");
            Console.WriteLine("1. Want to modify it");
            Console.WriteLine("2. Want to Go back to to Modification Menu.");
            Console.WriteLine("3. Exit the console app.");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            string updatedValue = "";
            string assignedvalue = "";
            switch (choice)
            {
                case "1":
                    updatedValue = "products_and_services_Description";
                    Console.Write("Enter new Product and Service Description: ");
                    assignedvalue = Console.ReadLine();
                    break;
                case "2":
                    ModifyProductandServices();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE products_and_services SET {updatedValue} = @assignedvalue WHERE product_and_services_code = @product_and_services_code";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@assignedvalue", assignedvalue);
                    updateCommand.Parameters.AddWithValue("@product_and_services_code", product_and_services_code);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Product and Services information updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to update Product and Services information.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Here is the details of Product and Services with new modifications.");
            ViewProductandServices();

        }
        static void deletePandS()
        {
            Console.Write("Enter Product and Service Code to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int product_and_services_code))
            {
                Console.WriteLine("Invalid Product and Service Code. Please enter a valid Code.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string deleteQuery = $"DELETE FROM customer_purchase WHERE product_and_services_code = '{product_and_services_code}';DELETE FROM products_and_services WHERE Account_ID = '{product_and_services_code}'; ";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@product_and_services_code", product_and_services_code);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Product and Services deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete Product and Services. Product and Services code not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to view updated Product and services...");
        }
        static void DisplayCustomerPurchaseManagement()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ********************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" --------Menu of Purchase Management-------");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ********************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("Please choose from the following Options:");
            Console.WriteLine();
            Console.WriteLine(" 1. Modify Customer Purrchase");
            Console.WriteLine(" 2. Link Purchases to Customers and Products");
            Console.WriteLine(" 3. View customer Purchase History");
            Console.WriteLine(" 4. Go back to root of database");

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
                        LinkCustomersProductsPurchases();
                        break;
                    case 3:
                        viewCsPurchase();
                        break;
                    case 4:
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
        static void ModifyCustomerPurchase()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ********************************************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" --Menu of Customer Purchase Modification--");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" ********************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("Please choose from the following Options:");
            Console.WriteLine();
            Console.WriteLine(" 1. Add the Customer Purchase");
            Console.WriteLine(" 2. Update the Customer Purchase");
            Console.WriteLine(" 3. Delete the Customer Purchase");
            Console.WriteLine(" 4. Go back to root of database.");

            Console.WriteLine();
            Console.Write("Enter your choice: ");

            try
            {
                int subChoice = Convert.ToInt32(Console.ReadLine());

                switch (subChoice)
                {
                    case 1:
                        addCsPurchase();
                        break;
                    case 2:
                        updateCsPurchase();
                        break;
                    case 3:
                        deleteCustomerPurchase();
                        break;
                    case 4:
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
        static void addCsPurchase()
        {

            Console.WriteLine("The above table is reference to Select the more reference Purchase ID because it's a primary key and cannot be reated.");
            Console.Write("\n\tEnter the Purchase ID: ");
            string Purchase_id = Console.ReadLine();

            Console.Write("\n\tEnter the Date in (yyyy-mm-dd) order : ");
            string Date = Console.ReadLine();

            Console.Write("\n\tEnter the Quality: ");
            string quality = Console.ReadLine();

            Console.Write("\n\tEnter the Other Details: ");
            string other_details = Console.ReadLine();

            Console.Write("\n\tEnter the Customer ID: ");
            string customer_id = Console.ReadLine();

            Console.Write("\n\tEnter the Product and Services Code: ");
            string Product_and_Services_Code = Console.ReadLine();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = $"Insert into customer_purchase (Purchase_id, Date, quality, other_details, customer_id, Product_and_Services_Code) values ('{Purchase_id}', '{Date}', '{quality}', '{other_details}', '{customer_id}', '{Product_and_Services_Code}')";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("\n\tProduct and Services added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\n\tFailed to add account.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("Press any key to view updated Table");
            Console.ReadLine();
            viewCsPurchase();
        }
        static void updateCsPurchase()
        {

            Console.Write("Enter Purchase ID to modify: ");
            if (!int.TryParse(Console.ReadLine(), out int Purchase_id))
            {
                Console.WriteLine("Invalid Purchase ID. Please enter a valid Purchase ID.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("What do you want to modify?");
            Console.WriteLine("1. Date of Customer Purchase");
            Console.WriteLine("2. Quality of Purchase");
            Console.WriteLine("3. Other Details");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            string updatedValue = "";
            string assignedvalue = "";
            switch (choice)
            {
                case "1":
                    updatedValue = "Date";
                    Console.Write("Enter new Date: ");
                    assignedvalue = Console.ReadLine();
                    break;
                case "2":
                    updatedValue = "Quality";
                    Console.Write("Enter new Quality of Purchase: ");
                    assignedvalue = Console.ReadLine();
                    break;
                case "3":
                    updatedValue = "Other_details";
                    Console.WriteLine("Enter new Other Detail: ");
                    assignedvalue = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = $"UPDATE Customer_Purchase SET {updatedValue} = @assignedvalue WHERE Purchase_id = @Purchase_id";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@assignedvalue", assignedvalue);
                    updateCommand.Parameters.AddWithValue("@Purchase_id", Purchase_id);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Purchase information updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to update Purchase information.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("Here is the updated view........");
            Console.ReadKey();
            viewCsPurchase();
        }
        static void viewCsPurchase()
        {
            try
            {

                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string selectProductandServices = @"SELECT purchase_id, Quality, other_details, Customer_ID, Product_and_services_code, date FROM Customer_purchase;";
                MySqlCommand command = new MySqlCommand(selectProductandServices, connection);
                MySqlDataReader reader = command.ExecuteReader();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ********************************************");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" --------Customer Purchase Details---------");
                Console.WriteLine(" *                                          *");
                Console.WriteLine(" ********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Purchase Id \t Quality \t Other details\t\tCustomer ID\tProduct And Services_code\tDate\n");
                while (reader.Read())
                {
                    Console.WriteLine($"\t{reader["purchase_id"].ToString().PadRight(7)}\t{reader["Quality"].ToString().PadRight(10)}\t{reader["other_details"].ToString().PadRight(30)}\t{reader["Customer_ID"].ToString().PadRight(10)}\t{reader["Product_and_services_code"].ToString().PadRight(10)}\t{reader["date"].ToString().PadRight(10)}\t");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            connection.Close();
            Console.WriteLine("Press any key to go to Root of Database...");
            Console.ReadLine();
            DisplayProductandServiceManagement();
        }
        static void deleteCustomerPurchase()
        {
            Console.Write("Enter Purchase ID to Delete: ");
            if (!int.TryParse(Console.ReadLine(), out int purchase_id))
            {
                Console.WriteLine("Invalid Purchase ID. Please enter a valid ID.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string deleteQuery = $"DELETE FROM transactions WHERE purchase_id = '{purchase_id}';DELETE FROM customer_purchase WHERE purchase_id = '{purchase_id}'; ";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@purchase_id", purchase_id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("purchase ID deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete Purchase ID.ID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to view Updated menu...");
            Console.ReadKey();
            viewCsPurchase();
        }
        static void LinkCustomersProductsPurchases()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                string Join = @"SELECT c.Customer_name, p.Products_and_services_Description, cp.Date FROM customer_purchase cp JOIN customers c ON c.Customer_ID = cp.Customer_ID JOIN products_and_services p ON p.Product_and_services_code = cp.Product_and_services_code";

                using (MySqlCommand command = new MySqlCommand(Join, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Customer Name\t\tProduct Description\t\t\tPurchase Date\n\n");
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["Customer_name"].ToString().PadRight(30)}\t{reader["Products_and_services_Description"].ToString().PadRight(30)}\t{reader["Date"].ToString().PadRight(10)}\t");
                        }
                    }
                }
                Console.WriteLine("\n\n\tCustomers, products, and purchases have been linked.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            connection.Close();
            Console.WriteLine("\n\nPress any key to Go back to Root of database...");
            Console.ReadLine();
            DisplayofRootofDatabase();
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
