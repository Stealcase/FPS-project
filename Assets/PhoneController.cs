using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PhoneController : MonoBehaviour
{
    bool up = false;
    RectTransform canvas;
    RectTransform phone;
    Vector3 startingPosition;
    public float speed;
    public float ypos;

    private void Start()
    {
        phone = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = -10f;
    }

    void Update()
    {
        //if (Input.GetButtonDown("Fire1") && up == false)
        //{
        //    up = true;
        //    print("mousewheeled");
        //    transform.position = new Vector3(startingPosition.x, ypos, startingPosition.z);
        //    return;
        //}
        //if (Input.GetButtonDown("Fire1") && up == true)
        //{
        //    up = false;
        //    transform.position = startingPosition;
        //    print("phone going down");
        //    return;

        //    }


    }
}