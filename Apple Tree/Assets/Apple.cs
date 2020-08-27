using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float _bottonY = -20;
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y < _bottonY)
        {
            Destroy(this.gameObject);

            ApplePicker appScript = Camera.main.GetComponent<ApplePicker>();

            appScript.AppleDestroyed();
        }
    }
}
