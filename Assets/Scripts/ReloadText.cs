using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadText : MonoBehaviour
{
    private float timer = 0;

    private float timeAwake = 1;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeAwake)
        {
            timer = 0;
            this.gameObject.SetActive(false);
        }
    }
}
