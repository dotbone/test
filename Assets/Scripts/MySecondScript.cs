using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySecondScript : MonoBehaviour
{
    public GameObject temp;
    //public Transform parent;
    //public Transform child;

    private void Start()
    {
        var type = typeof(MyFirstScript);

        var r1 = GetComponents<Transform>();
        var r = GetComponent<MyFirstScript>();

        var r2 = Instantiate(temp, transform);
        r2.transform.position = new Vector3(25, 25, 25);

        var r3 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        r3.transform.position = new Vector3(0, 0, 2.91f);
        r3.name = "TEST";

        gameObject.AddComponent<MyFirstScript>();

        var r4 = transform.Find("Sphere");
        //child.SetAsFirstSibling();

        //transform.parent = parent;
    }
    void Update()
    {
        
    }
}
