using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    int cloneAmount;
    public void CloneObject()
    {
        cloneAmount = 5;
        int i = 0;
        while (i < cloneAmount)
        {
            Instantiate(objectToClone);
            i++;
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
