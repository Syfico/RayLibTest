using System.Collections.ObjectModel;
using System;

public class Avatar
{
    //POSITION
    //SPRITE
    //MOVEMENT    

    private Rectangle rect;
    private Texture2D sprite;

    public float speed = 4.5f;

    public Avatar()
    {
        sprite = Raylib.LoadTexture("Stickman64px.png");
        rect = new Rectangle(0, 0, sprite.width, sprite.height);
    }

    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) || Raylib.IsKeyDown(KeyboardKey.KEY_D)) rect.x += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(KeyboardKey.KEY_A)) rect.x -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) || Raylib.IsKeyDown(KeyboardKey.KEY_S)) rect.y += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) || Raylib.IsKeyDown(KeyboardKey.KEY_W)) rect.y -= speed;
    }

    public void Draw()
    {
        Raylib.DrawTexture
        (
            sprite,
            (int)rect.x,
            (int)rect.y,
            Color.WHITE
        );
    }
}
