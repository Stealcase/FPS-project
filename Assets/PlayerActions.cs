using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    Animator anim;
    public bool armUp = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("armUp",armUp);
        if (Input.GetButtonDown("Fire1") && armUp == false)
        {
            print("Pressed things up");
            armUp = true;
            return;
        }
        if (Input.GetButtonDown("Fire1") && armUp == true)
        {
            armUp = false;
            print("pressed down");
            return;

        }
    }
}
