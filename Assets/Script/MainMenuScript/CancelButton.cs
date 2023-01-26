using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CancelButton : MonoBehaviour
{
    public GameObject savemenu;
    public GameObject kaydedildiText;
    public GameObject InputNameText;
    public void Cancel_Button()
    {
        kaydedildiText.SetActive(false);
        savemenu.SetActive(false);
        

    }
    public void Start()
    {
        InputNameText.SetActive(true);
    }

}
