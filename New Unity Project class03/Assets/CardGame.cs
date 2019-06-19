using UnityEngine;

public class CardGame
{
    private int _power;
    private float _horizontal;
    private Sprite _picture;
    
    public int power { get => _power; }
    public float horizontal { get => _horizontal; set => _horizontal = 42; }
    public Sprite picture { set => _picture = value; }

    public CardGame (int ARGpower, float ARGhorizontal, Sprite ARGpicture)
    {
        _power = ARGpower;
        _horizontal = ARGhorizontal;
        _picture = ARGpicture;

        GameObject card = new GameObject("CARD");
        card.AddComponent<SpriteRenderer>();

        card.GetComponent<SpriteRenderer>().sprite = _picture;

        card.GetComponent<Transform>().position = new Vector2(_horizontal, 0);   //set component&transform 
    }
}