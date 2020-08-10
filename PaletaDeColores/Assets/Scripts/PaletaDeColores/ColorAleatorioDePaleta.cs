using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorAleatorioDePaleta : MonoBehaviour
{
    public PaletaDeColores laPaletaActual;

    private void Awake()
    {
        GetComponent<Image>().color = laPaletaActual.DameColorAleatorio();
    }
}
