using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _newSize = 0f;

    private void Update()
    {
        _newSize += _speed * Time.deltaTime;
        transform.localScale += new Vector3(_newSize, _newSize, _newSize);
       // transform.localScale += Vector3.up * _speed * Time.deltaTime;
    }
}
