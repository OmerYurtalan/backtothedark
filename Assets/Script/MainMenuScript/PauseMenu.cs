using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Main_Menu;
    public GameObject OptionsMenu;
    public GameObject Pause_Menu;
    public GameObject Are_You_Sure;
    public void ResumeGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void OptionsGame2()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
       Main_Menu.SetActive(false);
       OptionsMenu.SetActive(true);
       Pause_Menu.SetActive(false);

    }
    public void ExitGame()
    {
        Main_Menu.SetActive(false);
        OptionsMenu.SetActive(false);
        Pause_Menu.SetActive(false);
        Are_You_Sure.SetActive(true);

    }
}
