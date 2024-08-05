using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    private float _newSize = 0f;

    void Update()
    {
        _newSize += _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(_newSize, _newSize, _newSize);
    }
}
