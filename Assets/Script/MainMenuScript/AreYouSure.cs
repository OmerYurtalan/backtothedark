using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreYouSure : MonoBehaviour
{
    public GameObject Main_Menu;
    public GameObject OptionsMenu;
    public GameObject Pause_Menu;
    public GameObject Are_You_Sure;

    public void Yes()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        Main_Menu.SetActive(true);
        OptionsMenu.SetActive(false);
        Pause_Menu.SetActive(false);
        Are_You_Sure.SetActive(false);

    }
    public void No()
    {
        Main_Menu.SetActive(false);
        OptionsMenu.SetActive(false);
        Pause_Menu.SetActive(true);
        Are_You_Sure.SetActive(false);
    }
}