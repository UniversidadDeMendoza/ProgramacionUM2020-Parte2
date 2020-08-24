using UnityEngine;

[CreateAssetMenu(fileName = "CurveValue", menuName = "Settings/CurveValue", order = 1)]
public class CurveValue : ScriptableObject
{
    public AnimationCurve value;
}