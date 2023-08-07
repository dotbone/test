using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.UIElements;
using UnityEngine;

public class async_test : MonoBehaviour
{
    // Start is called before the first frame update
    private async void Start()
    {
        StartCoroutine(Moving());
        await MovingAsync();
    }

    private IEnumerator Moving()
    {
        while (true)
        {
            var timer = 2f;
            while (timer > 0f)
            {
                timer -= Time.deltaTime;
                transform.position += Vector3.right * Time.deltaTime;
                yield return null;
            }
            yield return new WaitForSeconds(2f);

            timer = 2f;
            while (timer > 0f)
            {
                timer -= Time.deltaTime;
                transform.position -= Vector3.right * Time.deltaTime;
                yield return null;
            }
            yield return new WaitForSeconds(2f);
        }
    }

    private async Task MovingAsync()
    {
        while (true)
        {
            var timer = 2f;
            while (timer > 0f)
            {
                timer -= Time.deltaTime;
                transform.position += Vector3.up * Time.deltaTime;
                await Task.Yield();
            }
            await Task.Delay(TimeSpan.FromSeconds(2));

            timer = 2f;
            while (timer > 0f)
            {
                timer -= Time.deltaTime;
                transform.position -= Vector3.up * Time.deltaTime;
                await Task.Yield();
            }
            await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}
