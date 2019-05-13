using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentControl : MonoBehaviour
{
    private Light myLight;
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            gameObject.SetActive(active);
            active = !active;
        }

    }
}
