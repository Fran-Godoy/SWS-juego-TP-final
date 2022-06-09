using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 playerSpeed;
    float multiplicadorEscala;
    // Start is called before the first frame update
    void Start()
    {
        multiplicadorEscala = -1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 local = transform.localScale;
        transform.Translate(0, 0, 0.1f);
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale += new Vector3(0, 0.5f,0) * multiplicadorEscala;
            multiplicadorEscala *= -1;
        }
        
    }
}