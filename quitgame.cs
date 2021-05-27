using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        const int buttonWidth = 90;
        const int buttonHeight = 50;
        if (
             GUI.Button(new Rect(10,
                               10, buttonWidth, buttonHeight), "Quitgame")
          )
        {
            Application.Quit();
        }
    }
}
