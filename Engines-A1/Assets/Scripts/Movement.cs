using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementVec = Vector3.zero;
        movementVec.z = Input.GetAxis("Horizontal");
        movementVec.x = -Input.GetAxis("Vertical");

        movementVec *= Time.deltaTime;
        movementVec *= movementSpeed;

        transform.Translate(movementVec, Space.World);

        
    }
}
