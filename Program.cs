using Raylib_cs;
class Program
{
    public static void Main()
    {

		var gameState = GameState.Start;
        Raylib.InitWindow(800, 480, "Hello World");

        while (!Raylib.WindowShouldClose())
        {

			switch (gameState) {
				case GameState.Start:
					if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE)) {
						gameState = GameState.Playing;
					};

					Raylib.BeginDrawing();
		            Raylib.ClearBackground(Color.BLACK);

		            Raylib.DrawText("sssssnake", 200, 100, 80, Color.WHITE);
		            Raylib.DrawText("Press SPACE to play!", 150, 250, 50, Color.WHITE);

		            Raylib.EndDrawing();
					break;
				case GameState.Playing:
					Raylib.BeginDrawing();
		            Raylib.ClearBackground(Color.BLACK);

		            Raylib.DrawText("Playing snake....", 12, 12, 20, Color.WHITE);

		            Raylib.EndDrawing();
					break;

				case GameState.GameOver:
					if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE)) {
						gameState = GameState.Playing;
					};

					Raylib.BeginDrawing();
		            Raylib.ClearBackground(Color.BLACK);

		            Raylib.DrawText("YOU LOSE!!", 200, 100, 80, Color.WHITE);
		            Raylib.DrawText("Press SPACE to play again!", 80, 250, 50, Color.WHITE);


		            Raylib.EndDrawing();
					break;
			}

        }

        Raylib.CloseWindow();
    }
}