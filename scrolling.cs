using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    public Vector2 speed = new Vector2(2, 2);
    public Vector2 direction = new Vector2(-1, 0);
    public bool isLinkedToCamera = false;
    public bool isLooping = false;
    public List<Transform> background;
    // Start is called before the first frame update
    void Start()
    {
        if(isLooping)
        {
            background = new List<Transform>();
            for(int i = 0;i<transform.childCount;i++)
            {
                Transform child = transform.GetChild(i);
                if (child != null) background.Add(child); 
            }
            background.Sort();//.ToList();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
