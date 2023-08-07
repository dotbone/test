using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateComponent : MonoBehaviour
{
    public float _bulletSpeed = 5f;
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * _bulletSpeed;
    }
}
