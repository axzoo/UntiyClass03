using UnityEngine;

public class GameManager :MonoBehaviour
{
    public Ship ship01 = new Ship();

    public Ship ship01_kind = new Ship(84.5f, 44.2f, 76.1f);

    private void Start ()
    {
        ship01.speed = 20.6f;
        Debug.Log("ship speed :" + ship01.speed);

        ship01.length = 74.8f;
        Debug.Log("ship length :" + ship01.length);

        //ship01.width = 12.4f;
        Debug.Log("ship width :" + ship01.Width);

        Debug.Log("ship large :" + ship01.volume);

        Debug.Log("ship large kind :" + ship01_kind.volume);
    }
}