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
    public Text TextFieldLecturas;

    public int zonaPromedioGas;
    public int numeroLecturas;

    

    void Start ()
    {
        Physics2D.queriesHitTriggers = true;
    }
    
    void OnMouseOver()
    {
        int firstIndex = this.name.IndexOf('-');
        int lastIndex = this.name.LastIndexOf('-');

        // Debug.Log(this.name.Substring(firstIndex + 1, lastIndex - firstIndex - 1));
        // Debug.Log(this.name.Substring(lastIndex + 1));

        int x = int.Parse(this.name.Substring(firstIndex + 1, lastIndex - firstIndex - 1));
        int y = int.Parse(this.name.Substring(lastIndex + 1));

        int zonaActual = (2500 - (y + 1) * 50) + (x + 1);
        TextfieldZona.text = $"Zona: {zonaActual}";
        TextfieldPromedio.text = $"Promedio: {zonaPromedioGas}";
        TextFieldLecturas.text = $"# Lecturas: {numeroLecturas}";    
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
        numeroLecturas = colorCalc[2];



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

        int firstIndex = this.name.IndexOf('-');
        int lastIndex = this.name.LastIndexOf('-');

        int x = int.Parse(this.name.Substring(firstIndex + 1, lastIndex - firstIndex - 1));
        int y = int.Parse(this.name.Substring(lastIndex + 1));

        // Quitar valores fuera del mapa
        if((x == 0 && ((y <= 49 && y >= 14) || (y <= 8 && y >= 0))) || 
            (x == 1 && ((y <= 49 && y >= 20) || (y <= 7 && y >= 0))) ||
            (x == 2 && ((y <= 49 && y >= 30) || (y <= 7 && y >= 0))) ||
            (x == 3 && ((y <= 49 && y >= 35) || (y <= 6 && y >= 0))) ||
            (x == 4 && ((y <= 49 && y >= 35) || (y <= 6 && y >= 0))) ||
            (x == 5 && ((y <= 49 && y >= 36) || (y <= 5 && y >= 0))) ||
            (x == 6 && ((y <= 49 && y >= 37) || (y <= 5 && y >= 0))) ||
            (x == 7 && ((y <= 49 && y >= 37) || (y <= 4 && y >= 0))) ||
            (x == 8 && ((y <= 49 && y >= 38) || (y <= 4 && y >= 0))) ||
            (x == 9 && ((y <= 49 && y >= 39) || (y <= 3 && y >= 0))) ||
            (x == 10 && ((y <= 49 && y >= 39) || (y <= 3 && y >= 0))) ||
            (x == 11 && ((y <= 49 && y >= 40) || (y <= 2 && y >= 0))) ||
            (x == 12 && ((y <= 49 && y >= 41) || (y <= 2 && y >= 0))) ||
            (x == 13 && ((y <= 49 && y >= 42) || (y <= 1 && y >= 0))) ||
            (x == 14 && ((y <= 49 && y >= 43) || (y <= 1 && y >= 0))) ||
            (x == 15 && ((y <= 49 && y >= 44) || (y <= 0 && y >= 0))) ||
            (x == 16 && ((y <= 49 && y >= 45) || (y <= 0 && y >= 0))) ||
            (x == 17 && ((y <= 49 && y >= 46) || (y <= 0 && y >= 0))) ||
            (x == 18 && ((y <= 49 && y >= 47) )) ||
            (x == 19 && ((y <= 49 && y >= 48) )) ||
            (x == 20 && ((y <= 49 && y >= 48) )) ||
            (x == 21 && ((y <= 49 && y >= 47) )) ||
            (x == 22 && ((y <= 49 && y >= 47) || (y <= 0 && y >= 0))) ||
            (x == 23 && ((y <= 49 && y >= 46) || (y <= 0 && y >= 0))) ||
            (x == 24 && ((y <= 49 && y >= 45) || (y <= 1 && y >= 0))) ||
            (x == 25 && ((y <= 49 && y >= 44) || (y <= 1 && y >= 0))) ||
            (x == 26 && ((y <= 49 && y >= 43) || (y <= 2 && y >= 0))) ||
            (x == 27 && ((y <= 49 && y >= 43) || (y <= 2 && y >= 0))) ||
            (x == 28 && ((y <= 49 && y >= 42) || (y <= 2 && y >= 0))) ||
            (x == 29 && ((y <= 49 && y >= 41) || (y <= 3 && y >= 0))) ||
            (x == 30 && ((y <= 49 && y >= 40) || (y <= 3 && y >= 0))) ||
            (x == 31 && ((y <= 49 && y >= 39) || (y <= 4 && y >= 0))) ||
            (x == 32 && ((y <= 49 && y >= 38) || (y <= 4 && y >= 0))) ||
            (x == 33 && ((y <= 49 && y >= 38) || (y <= 5 && y >= 0))) ||
            (x == 34 && ((y <= 49 && y >= 37) || (y <= 5 && y >= 0))) ||
            (x == 35 && ((y <= 49 && y >= 36) || (y <= 6 && y >= 0))) ||
            (x == 36 && ((y <= 49 && y >= 35) || (y <= 6 && y >= 0))) ||
            (x == 37 && ((y <= 49 && y >= 34) || (y <= 7 && y >= 0))) ||
            (x == 38 && ((y <= 49 && y >= 34) || (y <= 7 && y >= 0))) ||
            (x == 39 && ((y <= 49 && y >= 33) || (y <= 8 && y >= 0))) ||
            (x == 40 && ((y <= 49 && y >= 32) || (y <= 8 && y >= 0))) ||
            (x == 41 && ((y <= 49 && y >= 31) || (y <= 9 && y >= 0))) ||
            (x == 42 && ((y <= 49 && y >= 30) || (y <= 9 && y >= 0))) ||
            (x == 43 && ((y <= 49 && y >= 30) || (y <= 10 && y >= 0))) ||
            (x == 44 && ((y <= 49 && y >= 29) || (y <= 10 && y >= 0))) ||
            (x == 45 && ((y <= 49 && y >= 28) || (y <= 11 && y >= 0))) ||
            (x == 46 && ((y <= 49 && y >= 27) || (y <= 14 && y >= 0))) ||
            (x == 47 && ((y <= 49 && y >= 26) || (y <= 16 && y >= 0))) ||
            (x == 48 && ((y <= 49 && y >= 25) || (y <= 19 && y >= 0))) ||
            (x == 49 && ((y <= 49 && y >= 24) || (y <= 21 && y >= 0)))
          )
        {
            _renderer.color = _baseColor;
        }

    }
}
