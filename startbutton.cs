using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGUI()
    {
        const int buttonWidth = 80;
        const int buttonHeight = 60;

        if(
            GUI.Button(new Rect(Screen.width/(2) - (buttonWidth/2),
                               (2*Screen.height/3) - (buttonHeight/2),buttonWidth,buttonHeight),"start game")
        )
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
