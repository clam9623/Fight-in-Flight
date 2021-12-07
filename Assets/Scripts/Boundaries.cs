using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 60f, 1040f), Mathf.Clamp(transform.position.y, 0f, 500f), transform.position.z);

    }
}
