using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    // Start is called before the first frame update
    void Start()
    {
       CloneObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloneObject()
    {
        int contador = 0;
        while (contador < cloneAmount)
        {
            Instantiate(objectToClone);
            contador++;
        }
    }
}
