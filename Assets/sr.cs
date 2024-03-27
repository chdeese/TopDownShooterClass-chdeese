using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(3f, 0, 0)* Mathf.Sin(Time.time) * Time.deltaTime);
    }
}
