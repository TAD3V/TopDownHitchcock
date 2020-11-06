using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuScript : MonoBehaviour
{
    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
    }

    public void CreditsButton()
    {
        // Show Credits Menu
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}
