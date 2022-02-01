using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    int saveLVL;
    public Button LVL2;
    public Button LVL3;

    // Start is called before the first frame update
    void Start()
    {
        saveLVL = PlayerPrefs.GetInt("saveLVL", 0);
        LVL2.interactable = false;
        LVL3.interactable = false;

        switch (saveLVL)
        {
            case 1:
                LVL2.interactable = true;
                break;
            case 2:
                LVL2.interactable = true;
                LVL3.interactable = true;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Level1()
    {
        SceneManager.LoadScene("LVL1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("LVL2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("LVL3");
    }
    public void exitgame()
    {
        Application.Quit();
    }
    public void restart()
    {
        LVL2.interactable = false;
        LVL3.interactable = false;
        PlayerPrefs.DeleteAll();
    }
    
}
