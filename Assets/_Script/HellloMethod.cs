using UnityEngine;
using UnityEngine.Rendering;

public class HellloMethod : MonoBehaviour
{
    
    void Start()
    {
        // Method1
        // Method1
        // Method1
        // Method2("체리콜라맛 쿠키");
        //Debug.Log($"{Method3(3,5)}");

        Debug.Log($"공격력은 {Method1(3)}입니다.");
    }

    int Method1(int attack)
    {
        return attack;
    }

    void Method2(string cookie)
    {
        Debug.Log($"내 이름은 {cookie}입니다.");
    }

    int Method3(int damage1, int damage2)
    {
        return damage1 + damage2;
    }
}
