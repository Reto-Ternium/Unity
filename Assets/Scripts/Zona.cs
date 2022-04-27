using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zona : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _greenColor, _yellowColor, _redColor, _orangeColor, _purpleColor;
    [SerializeField] private SpriteRenderer _renderer;

    public Text TextfieldZona;
    public Text TextfieldPromedio;

    public int zonaPromedioGas;

    

    void Start ()
    {
        Physics2D.queriesHitTriggers = true;
    }
    
    void OnMouseOver()
    {
        char[] charArray = this.name.ToCharArray();
        int x = charArray[5] - '0';
        int y = charArray[7] - '0';

        int zonaActual = (2500 - (y + 1) * 50) + (x + 1);
        TextfieldZona.text = $"Zona: {zonaActual}";
        TextfieldPromedio.text = $"Promedio: {zonaPromedioGas}";
        
    }

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

    public void CambiaColor(int[] colorCalc)
    {
        zonaPromedioGas = colorCalc[1];

        if (colorCalc[0] == 0)
        {
            _renderer.color = _baseColor;
        }
        if (colorCalc[0] == 1)
        {
            _renderer.color = _greenColor;
        }
        if (colorCalc[0] == 2)
        {
            _renderer.color = _yellowColor;
        }
        if (colorCalc[0] == 3)
        {
            _renderer.color = _orangeColor;
        }
        if (colorCalc[0] == 4)
        {
            _renderer.color = _redColor;
        }
        if (colorCalc[0] == 5)
        {
            _renderer.color = _purpleColor;
        }
    }
}
