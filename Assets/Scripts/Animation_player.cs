using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_player : MonoBehaviour
{
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponentInChildren<Animator>();
    }

    public void Run(float move)
    {
        Anim.SetFloat("move", Mathf.Abs(move));
    }
}
