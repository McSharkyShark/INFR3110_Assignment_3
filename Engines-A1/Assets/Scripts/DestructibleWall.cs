using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{

    private bool _dirtyFlag;

    private void Awake()
    {
        _dirtyFlag = false;
    }

    private void Update()
    {
        if (_dirtyFlag)
            DestroyWall();
    }

    private void DestroyWall()
    {
        GameObject.Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _dirtyFlag = true;
        }

    }
}
