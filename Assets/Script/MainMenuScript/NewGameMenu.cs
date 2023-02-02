using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGameMenu : MonoBehaviour
{
    public GameObject nesne1;
    public GameObject nesne2;
    public GameObject savemenu;
    public GameObject Main_Menu;
    public GameObject NewGame_Menu;
    

   
    public void FirstNewGame()
    {
        Debug.Log("1.Acýldý!!!!");
            savemenu.SetActive(true);
            nesne1.SetActive(false);
            
    }

    public void SecondNewGame()
    {

        Debug.Log("2.Acýldý!!!");
          

        savemenu.SetActive(true);
        nesne2.SetActive(false);
        
    }

    public void PlayButton1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayButton2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackButton()
    {
        NewGame_Menu.SetActive(false);
        Main_Menu.SetActive(true);
        
    }
}
