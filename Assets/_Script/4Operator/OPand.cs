using UnityEngine;

public class OPand : MonoBehaviour
{
    [Header("입력창")]
    public bool A;
    public bool B;

    [Header("결과창")]
    [ReadOnly]public bool opSame;
    [ReadOnly]public bool opDiff;

    void Update()
    {
        bool isSame = A == B;
        bool isDiff = A != B;

        opSame = isSame;
        opDiff = isDiff;
    }
}    
