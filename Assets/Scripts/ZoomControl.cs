using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControl : MonoBehaviour
{
    public float ZoomChange;
    public float SmoothChange;
    public float MinSize, MaxSize;

    private Camera _cam;

    private void Start()
    {
        _cam = GetComponent<Camera>();
    }

    private void Update()
    {
        if(Input.mouseScrollDelta.y > 0)
        {
            _cam.orthographicSize -= ZoomChange * Time.deltaTime * SmoothChange;
        }
        if(Input.mouseScrollDelta.y < 0)
        {
            _cam.orthographicSize += ZoomChange * Time.deltaTime * SmoothChange;
        }

        _cam.orthographicSize = Mathf.Clamp(_cam.orthographicSize, MinSize, MaxSize);
    }
}
