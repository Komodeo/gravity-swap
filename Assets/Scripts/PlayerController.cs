using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // swap gravity on tap and release
        if (Input.GetMouseButtonDown(0))
        {
            Physics2D.gravity *= -1;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Physics2D.gravity *= -1;
        }
    }
}
