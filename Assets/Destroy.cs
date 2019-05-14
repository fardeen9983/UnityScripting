using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //Reference to another GameObject
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Delete))
            Destroy(gameObject);
        if (Input.GetKeyDown(KeyCode.Space))
            Destroy(gameObject.GetComponent<Light>(),3f);
    }
}
