using UnityEngine;

public class MethodTutorial2 : MonoBehaviour
{
    public MethodTutorial mt;
        void Start()
    {
        //mt.Method2();

        //Debug.Log($"{mt.volume2}");

        // 다른 곳에서 선언한 메소드를 호출한다.
        int A = mt.Add(mt.num1, mt.num2);
        int B = mt.Minus(mt.num1, mt.num2);
        int C = mt.Mul(mt.num1, mt.num2);
        Debug.Log(A);
        Debug.Log($"{B}");
        Debug.Log($"{C}");
    }
}
