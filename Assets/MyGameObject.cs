using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameObject : MonoBehaviour
{
    public Text text;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyFunction ()
    {
        text.text = "Hola";
    }


}
