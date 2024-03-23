using Game;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new Player("Player1");
        Player player2 = new Player("Player2");

        player1.Shoot(player2);

        player2.Shoot(player1, 4);


        player1.GetInfo(); // Получаем информацию о Player1
        player2.GetInfo(); // Получаем информацию о Player2
    }
}