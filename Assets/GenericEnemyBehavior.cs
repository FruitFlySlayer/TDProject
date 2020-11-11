using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEnemyBehavior : MonoBehaviour
{
    public float speed = 0.01f;
    public int health = 10;
    private Transform end;

    // Start is called before the first frame update
    void Start()
    {
        end = Endpoint.endpoint;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = end.position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, end.position, speed);
        if (Vector3.Distance(transform.position, end.position) < 0.1f)
        {
            Destroy(gameObject);
        }
        
    }
    
}
