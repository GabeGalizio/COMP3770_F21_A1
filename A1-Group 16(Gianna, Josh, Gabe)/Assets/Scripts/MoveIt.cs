using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIt : MonoBehaviour
{
    private Vector3 velo = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        velo = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3(3,1,0);
        Vector3 b = new Vector3(-3,1,0);
        
        
        transform.position += velo * Time.deltaTime;

        if (transform.position.x > 3)
        {
            velo = new Vector3(-1, 0, 0);
        }
        if(transform.position.x < -3)
        {
            velo = new Vector3(1, 0, 0);
        }
    }
}
