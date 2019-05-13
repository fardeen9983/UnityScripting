using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Declare variables
   public int demo = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Log the values to the game
        //The output is printed on the console
        Debug.Log("Demo value " + demo);
    } 
}
