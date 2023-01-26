using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveControl : MonoBehaviour
{
    public GameObject kaydedildiText;
    public GameObject NewGame1;
    

    public InputField InputName;
    public TextMeshProUGUI InputNameText;
    

    //public InputField InputNameText;

    void Start()
    {
        // InputName.text = Veriler.name.ToString();
        Yukle();
    }

    public void Kaydet()
    {
        Veriler.name=InputName.text;
        SaveSystem.SavePlayer();
        Yukle();
       
        kaydedildiText.SetActive(true);
        NewGame1.SetActive(false);
    }
    public void Yukle()
    {
        SaveSystem.LoadPlayer();
        InputNameText.text=Veriler.name ;
        
       
    }
}
