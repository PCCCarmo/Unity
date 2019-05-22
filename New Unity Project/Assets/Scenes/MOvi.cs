using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float T = Input.GetAxis("Console");
        float V = Input.GetAxis("Vertical");

        //transform.translate(new Vector3(T * Time.deltatime, V *
        transform.Translate(new Vector3(T * 20 * Time.deltaTime, 0, 0));


        transform.Translate(new Vector3(0, V * 10 * Time.deltaTime, 0));

    }
}
