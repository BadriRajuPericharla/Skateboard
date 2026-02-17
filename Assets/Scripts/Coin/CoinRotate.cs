using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    [SerializeField] float spinSpeed = 360f;



    void Update()
    {
        coinRotate();
    }
    void coinRotate()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
