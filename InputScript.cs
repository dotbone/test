using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public GameObject _bullet;

    public float _moveSpeed = 3f;

    public float time;

    public float _reloadSpeed = 3f;
     
    
    void Update()
    {
        time -= Time.deltaTime;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;

        transform.position += new Vector3(x, 0f, z);

        Debug.Log(Input.GetAxis("Fire1"));

        if (time < 0f)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Instantiate(_bullet, transform.position, transform.rotation);
                time = _reloadSpeed;
            }
        }


        if (Input.GetKey(KeyCode.F)) // false if not pressed, true if pressed 
        {
            Debug.Log("Fire!");
        }

        if (Input.GetKeyDown(KeyCode.F)) // is the button pressed? true if pressed 
        {

        }

        if (Input.GetKeyUp(KeyCode.F)) // is the button depressed? true if depressed 
        {

        }
    }
}
