using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject[] SoilInfo;
    public Dropdown dropdown;
   
    public GameObject SettingsInfo;
    public GameObject NameInfo;

    void Start()
    {
        
    }

   
    void Update()
    {
      
    }


    public void InfoClicked()
    {
        int selectedIndex = dropdown.value;

         foreach (GameObject soil in SoilInfo)
        {
            soil.SetActive(false);
        }

        SoilInfo[selectedIndex].SetActive(true);
    }
    
    public void SettingsInfoClicked()
    {
            SettingsInfo.SetActive(true);
    }


    public void ShowVisibility()
    {
        if(NameInfo.activeSelf)
        {
            NameInfo.SetActive(false);
        }
        else
        {
            NameInfo.SetActive(true);
        }    
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
