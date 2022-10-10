using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal")*-0.5f;
        float moveY = Input.GetAxis("Vertical")*0.5f;

        transform.Rotate(moveY, 0, moveX, Space.Self);
    }
}
