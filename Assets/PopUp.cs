using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PopUp : MonoBehaviour
{
    private Animator controller;

    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<Animator>();
    }

    public void PopUpToolTip(bool popup)
    {
        controller.SetBool("PopUp", popup);
    }
}
