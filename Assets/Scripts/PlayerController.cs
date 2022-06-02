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
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(0, 2.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(-3.5f, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(3.5f, 1, 0);
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position = new Vector3(3.5f, 2.5f, 0);
            }
        }
    }
}