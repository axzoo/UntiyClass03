using UnityEngine;

public class MainmanuSTR
{
    private string m_state = "START";
   

    public void ChangeScene(string StateName)
    {
        m_state = StateName;

        switch(m_state)
        {
            case "MENU":
                Application.LoadLevel("GameScene");
                break;
            case "OPTION":
                Application.LoadLevel("MainMenuScene");
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
