using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
        }
    }
}
