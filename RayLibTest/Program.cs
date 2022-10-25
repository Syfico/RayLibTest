global using Raylib_cs;

Raylib.InitWindow(800, 600, "Världens bästa spel");
Raylib.SetTargetFPS(60);

Avatar walter = new Avatar();

while (!Raylib.WindowShouldClose())
{
    //LOGIK
    walter.Update();
    //GRAFIK
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    walter.Draw();

    Raylib.EndDrawing();
}