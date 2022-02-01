using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public Transform player;
    public Transform camer;
    public Transform textball;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camer.position = new Vector3(camer.position.x, camer.position.y, player.position.z - 2);
        textball.position = new Vector3(player.position.x, textball.position.y, player.position.z + 0.3f);
    }
}
