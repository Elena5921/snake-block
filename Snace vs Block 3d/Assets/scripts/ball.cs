using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public TextMesh ballmoney;
    public int ochko;
    public float ochkof;
    public GameObject blokc1;

    // Start is called before the first frame update
    void Start()
    {
        ochko = Random.Range(1, 11);
        ochkof = ochko;
        
        
        if (ochko <= 3)
            blokc1.GetComponent<MeshRenderer>().material.color = new Color(250, 0, 250);
        else if (ochko >= 8)
            blokc1.GetComponent<MeshRenderer>().material.color = new Color(250, 0, 0);
        else 
            blokc1.GetComponent<MeshRenderer>().material.color = new Color(0, 100, 125);
    }

    // Update is called once per frame
    void Update()
    {
        ballmoney.text = ochkof.ToString("f0");
        
    }
}
