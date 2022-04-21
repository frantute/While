using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class While01 : MonoBehaviour
{
    public int counter;
    public int countermax;
    public Text txt_display;
    // Start is called before the first frame update
    void Start()
    {
        while (counter<=countermax)
        {
            Debug.Log("Repeticion");
            counter++;
        }
        txt_display.text = "Termino el while";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
