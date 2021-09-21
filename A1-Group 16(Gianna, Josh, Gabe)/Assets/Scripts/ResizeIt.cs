using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 velo = new Vector3(1, 1, 1);
    void Start()
    {
        velo = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += velo * Time.deltaTime;
        
        if (transform.localScale.x > 4)
        {
            velo = new Vector3(-1, -1, -1);
        }
        if(transform.localScale.x < 1)
        {
            velo = new Vector3(1, 1, 1);
        }
        
        
    }
}
