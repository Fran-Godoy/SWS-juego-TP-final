using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour
{
    public float jumpForce;
    public int maxJumps;
    int hasJump;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "camino")
        {
            hasJump = maxJumps;
        }
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
        if (col.gameObject.name == "SlideBarrier (1)")
            Destroy(gameObject);
        if (col.gameObject.name == "SlideBarrier (2)")
            Destroy(gameObject);
        if (col.gameObject.name == "SlideBarrier (3)")
            Destroy(gameObject);
        if (col.gameObject.name == "SlideBarrier (4)")
            Destroy(gameObject);
        if (col.gameObject.name == "SlideBarrier (5)")
            Destroy(gameObject);
        if (col.gameObject.name == "SlideBarrier (6)")
            Destroy(gameObject);
        if (col.gameObject.name == "SlideBarrier (7)")
            Destroy(gameObject);
        if (col.gameObject.name == "JumpBarrier (1)")
            Destroy(gameObject);
        if (col.gameObject.name == "JumpBarrier (2)")
            Destroy(gameObject);

    }
}
