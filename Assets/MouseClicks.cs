using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicks : MonoBehaviour
{
    private int counter = 0;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        switch (counter)
        {
            case 0: renderer.material.color = Color.blue; break;
            case 1: renderer.material.color = Color.red; break;
            case 2: renderer.material.color = Color.green; break;
        }
        counter++;
        counter = counter % 3;
    }
}
