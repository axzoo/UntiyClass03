using UnityEngine;
using UnityEngine.SceneManagement;

public class CardManager : MonoBehaviour
{
    public CardGame cardplayer, cardPC;

    /* public Sprite image0, image1, image2, image3, image4;
     public Sprite image5, image6, image7, image8, image9; */

    public Sprite[] picture;

    public TextMesh tip;

    private void Start()
    {
        /*cardplayer = new CardGame(7, -4, image9);
        cardPC = new CardGame(1, 3, image3); */

        /*int rPlayer = Random.Range(0, 2);
        //Debug.Log("player random value : " + rPlayer);
        cardplayer = new CardGame(rPlayer, -7, picture[rPlayer]);

        int rPC = Random.Range(0, 7);
        cardPC = new CardGame(rPC, 5, picture[rPC]);

        tip.text = "hi.";
        tip.fontSize = 50;
        tip.color = Color.cyan;*/

        
    
    }
    public void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("CardGame");   // loading scene name or number
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();                   //  quit game scene
        }
    }

}
