using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Main_Menu;
    public GameObject Options_Menu;
    public GameObject Pause_Menu;
    public GameObject Are_You_Sure;
    public GameObject New_Game_Menu;

    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Main_Menu.SetActive(false);
        Options_Menu.SetActive(false);
        Pause_Menu.SetActive(false);
        Are_You_Sure.SetActive(false);
        New_Game_Menu.SetActive(true);
    }
    public void OptionsGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Main_Menu.SetActive(false);
        Options_Menu.SetActive(true);
    }
    public void QuitGame()
    {
        Debug.Log("Oyundan Çýkýldý!!!!");
        Application.Quit();
    }
    public void BackGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        Main_Menu.SetActive(true);
        Options_Menu.SetActive(false);
    }
}
