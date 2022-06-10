using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timemana : MonoBehaviour
{
    public Text txtTimeFloored;
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        currentTime = Time.timeSinceLevelLoad;
        txtTimeFloored.text = Mathf.Floor(currentTime).ToString();
        if (currentTime > 16)
        {
            SceneManager.LoadScene("GameWin"); ;
        }
    }
}
