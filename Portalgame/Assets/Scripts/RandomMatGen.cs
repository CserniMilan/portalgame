using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMatGen : MonoBehaviour
{
    public GameObject[] other;

    void Start()
    {
        List<Color> color = new List<Color>() { Color.red, Color.green, Color.yellow };
        color.Add(Color.white);

        if(transform.name == "player")
        {;
            Color randomColor = color[Random.Range(0, color.Count)];
            GetComponent<Renderer>().material.color = randomColor;
        }
        if(transform.childCount != 0)
        {
            foreach(GameObject item in other)
            {
                Color randomColor = color[Random.Range(0, color.Count)];
                item.GetComponent<Renderer>().material.color = randomColor;
                color.Remove(randomColor);
            }
        }
        

    }

    void Update()
    {
        
    }
}
