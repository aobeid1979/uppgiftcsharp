namespace test1
{
    internal class Program
    {
        static void Main()
        {
            // Using the database
            IDatabase database = new Database();

            // Add a user
            User user1 = new User { UserId = 1, UserName = "JohnDoe" };
            database.AddUser(user1);

            // Get a user
            User retrievedUser = database.GetUser(1);
            if (retrievedUser != null)
            {
                Console.WriteLine($"Retrieved user: ID = {retrievedUser.UserId}, Name = {retrievedUser.UserName}");
            }
            else
            {
                Console.WriteLine("User could not be found in the database.");
            }

            // Remove the user
            database.RemoveUser(1);

            // Try to get the user again after removal
            retrievedUser = database.GetUser(1);
            if (retrievedUser != null)
            {
                Console.WriteLine($"Retrieved user after removal: ID = {retrievedUser.UserId}, Name = {retrievedUser.UserName}");
            }
            else
            {
                Console.WriteLine("User could not be found in the database after removal.");
            }
        }
    }
}
