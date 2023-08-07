using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyThirdScript : MonoBehaviour
{
    Coroutine _cor;
    Transform[] _mass = new Transform[100];
    int count = 0;

    public Transform cube;

    void Start()
    {  
        
    }

    
    void Update()
    {
        //cube.LookAt(transform);
        cube.RotateAround(cube.position, cube.up, 5f * Time.deltaTime);
        //if (Input.GetMouseButton(0))
        //{
        //    if (_cor == null)
        //    {
        //        _cor = StartCoroutine(CoroutineTest());
        //    }
        //}

        for(int i = 0; i < count; i++)
        {
            _mass[i].position += Vector3.forward * Time.deltaTime;
        }
    }

    //private IEnumerator CoroutineTest()
    //{
    //    _mass[count] = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
    //    count++;
    //    yield return new WaitForSeconds(2f);
    //    Debug.Log("Created");
    //    _cor = null;
    //}
}
