using telescoape_manager;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();

        User userNou = new User(6, "greg@gmail.com", "grege", 0765474);

        userService.AddUser(userNou);

        userService.SaveData();

    }
}