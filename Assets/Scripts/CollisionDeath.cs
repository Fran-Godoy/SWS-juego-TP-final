using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (col.gameObject.name == "Obstacle") { 
            Destroy(gameObject);
        SceneManager.LoadScene("GameLose"); }
        

    }
}
