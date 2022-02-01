using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIgame : MonoBehaviour
{
    public Text ochki;
    public player cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ochki.text = cat.money.ToString("f0");
    }
    public void restart(string LVL)
    {
        SceneManager.LoadScene(LVL);
    }
    public void editmenu()
    {
        SceneManager.LoadScene("menu");
    }

}
