using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject thePlatform;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            thePlayer.transform.parent = thePlatform.transform;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            thePlayer.transform.parent = null;
        }

    }


}
