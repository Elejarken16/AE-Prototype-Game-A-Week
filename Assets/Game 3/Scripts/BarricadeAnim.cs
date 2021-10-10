using UnityEngine;
using System.Collections;
public class BarricadeAnim : MonoBehaviour
{
    public bool Play;
    ParticleSystem[] dust;
    // Use this for initialization
    void Start()
    {
        dust = GetComponentsInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Play)
        {
            dust[0].Play();
            dust[1].Play();
            Play = false;
        }
    }
}

