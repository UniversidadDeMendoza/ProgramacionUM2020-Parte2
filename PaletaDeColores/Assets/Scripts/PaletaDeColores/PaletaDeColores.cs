using UnityEngine;

[CreateAssetMenu(fileName = "Paleta", menuName = "ScriptableObjects/PaletaDeColores")]
public class PaletaDeColores : ScriptableObject
{
    public Color[] paleta;

    [Range(1, 10)]
    public int tiempoDeRecarga = 5;

    public Color DameColorAleatorio()
    {
        return paleta[Random.Range(0, paleta.Length)];
    }
}