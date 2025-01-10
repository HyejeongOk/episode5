using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class VariableSwitch : MonoBehaviour
{
    public int a = 11;
    public int b = 8;
    
    void Start()
    {
        SwitchVar();
        Debug.Log($"a의 값은 {a}, b의 값은 {b}");

        int c;
        int d;
        SwitchVar2(a, b, out c, out d);

        Debug.Log($"a의 값은 {c}, b의 값은 {d}");
    }

    void SwitchVar()
    {
        int temp;
        temp = a; //최초 a의 값을 잠시 보관
        a = b; //b의 값을 a 대입
        b = temp; // 잠시 보관 중인 a의 값을 b에 대입
    }

    void SwitchVar2(int a, int b, out int oa, out int ob)
    {
        oa = b;
        ob = a;
    }
}
