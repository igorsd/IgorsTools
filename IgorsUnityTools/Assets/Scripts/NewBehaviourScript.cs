using System.Collections;
using System.Collections.Generic;
using DapperDino.Examples;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello ".WithColor(Color.cyan) + "World!".WithColor(Color.yellow));
    }
}
