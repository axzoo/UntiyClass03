using UnityEngine;

public class CardGame
{
    private int _power;
    private float _horizontal;
    private Sprite _picture;

    public int Power { get => _power; }
    public float Horizontal { get => _horizontal; set => _horizontal = 42; }
    public Sprite Picture { set => _picture = value; }

    public CardGame(int power, float horizontal, Sprite picture)
    {
        _power = power;
        _horizontal = horizontal;
        _picture = picture;
    }
}
