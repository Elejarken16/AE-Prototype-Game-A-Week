using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator anim;

    private void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        float magnitude = (HorizontalInput + VerticalInput);

        anim.SetFloat("InputHorizontal", HorizontalInput);
        anim.SetFloat("InputVertical", VerticalInput);
        anim.SetFloat("InputMagnitude", magnitude);
    }
}
