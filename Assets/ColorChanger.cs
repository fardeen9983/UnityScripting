using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            renderer.material.color = Color.red;
        } if (Input.GetKeyDown(KeyCode.B))
        {
            renderer.material.color = Color.blue;
        } if (Input.GetKeyDown(KeyCode.G))
        {
            renderer.material.color = Color.green;
        }
    }
}
