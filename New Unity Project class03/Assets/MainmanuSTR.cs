using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmanuSTR
{
    private string m_state = "START";
   

    public void ChangeScene(string StateName)
    {
        m_state = StateName;

        switch(m_state)
        {
            case "MENU":
                //Application.LoadLevel("GameScene");
                SceneManager.LoadScene("GameScene");
                break;
            case "OPTION":
                //Application.LoadLevel("MainMenuScene");
                SceneManager.LoadScene("MainMenuScene");
                break;
        }
    }

    public void Update()
    {
        switch (m_state)
        {
            case "START" :
                break;
            case "MENU":
                break;
            case "OPTION":
                break;
        }
    }

}
