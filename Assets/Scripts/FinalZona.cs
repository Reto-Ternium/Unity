using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalZona : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _greenColor, _yellowColor, _redColor, _orangeColor, _purpleColor;
    [SerializeField] private SpriteRenderer _renderer;

    public void Init(int color)
    {
        if (color == 0)
        {
            _renderer.color = _baseColor;
        }
        if (color == 1)
        {
            _renderer.color = _greenColor;
        }
        if (color == 2)
        {
            _renderer.color = _yellowColor;
        }
        if (color == 3)
        {
            _renderer.color = _orangeColor;
        }
        if (color == 4)
        {
            _renderer.color = _redColor;
        }
        if (color == 5)
        {
            _renderer.color = _purpleColor;
        }
    }

    public void CambiaColor(int color)
    {
        if (color == 0)
        {
            _renderer.color = _baseColor;
        }
        if (color == 1)
        {
            _renderer.color = _greenColor;
        }
        if (color == 2)
        {
            _renderer.color = _yellowColor;
        }
        if (color == 3)
        {
            _renderer.color = _orangeColor;
        }
        if (color == 4)
        {
            _renderer.color = _redColor;
        }
        if (color == 5)
        {
            _renderer.color = _purpleColor;
        }
    }
}

