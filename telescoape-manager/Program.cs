using telescoape_manager;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();

        userService.AfisareUser();
    }
}