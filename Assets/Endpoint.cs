using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endpoint : MonoBehaviour
{
    public static Transform endpoint;

    private void Awake()
    {
        endpoint = gameObject.transform;
        
    }
}
