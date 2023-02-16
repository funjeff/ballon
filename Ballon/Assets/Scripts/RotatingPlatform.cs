using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float speed = 50f;
    public bool opposite = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(opposite)
        {
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        } else
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        
    }
}
