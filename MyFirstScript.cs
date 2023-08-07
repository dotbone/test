using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public bool IsTranslate;
    public bool IsRotate;
    public bool IsScale;
    void Update()
    {
        if (IsTranslate)
        {
            transform.position = transform.position + new Vector3(0.1f, 0, 0) * Time.deltaTime;
        } 
        if (IsRotate)
        {
            transform.eulerAngles = transform.eulerAngles + new Vector3(0, 5, 0) * Time.deltaTime;
        }
        if (IsScale)
        {
        transform.localScale = transform.localScale + new Vector3(0, 0, 0.2f) * Time.deltaTime;   
        }     
    }
}
