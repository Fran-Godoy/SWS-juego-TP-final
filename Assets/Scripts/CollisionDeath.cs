using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pared")
            Destroy(gameObject);
        if (col.gameObject.name == "Pared (1)")
            Destroy(gameObject);
        if (col.gameObject.name == "JumpBarrier")
            Destroy(gameObject);
        if (col.gameObject.name == "SlideBarrier")
            Destroy(gameObject);
        if (col.gameObject.name == "Train")
            Destroy(gameObject);
        if (col.gameObject.name == "Train (1)")
            Destroy(gameObject);
        if (col.gameObject.name == "Train (2)")
            Destroy(gameObject);
    }
}
