using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameOver : MonoBehaviour
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
        if(
             GUI.Button(new Rect(Screen.width / (2) - (buttonWidth / 2),
                               (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Retry")
          )
        {
            SceneManager.LoadScene("SampleScene");
            Destroy(gameObject);
        }

        if(
             GUI.Button(new Rect(Screen.width / (2) - (buttonWidth / 2),
                               (2 * Screen.height / 3) - (buttonHeight / 2)-90, buttonWidth, buttonHeight), "Back to Title")
          )
        {
            SceneManager.LoadScene("title");
            Destroy(gameObject);
        }
    }
}
