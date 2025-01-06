using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int num1;
    public int num2;
       void Start()
    {
        Debug.Log($"{num1} + {num2} = {plus(num1, num2)}");
        Debug.Log($"{num1} - {num2} = {minus(num1, num2)}");
        Debug.Log($"{num1} * {num2} = {mul(num1, num2)}");
        Debug.Log($"{num1} / {num2} = {div(num1, num2)}");
    }

int plus(int num1, int num2)
{
    return num1 + num2;
}

int minus(int num1, int num2)
{
    return num1 - num2;
}

int mul(int num1, int num2)
{
    return num1 * num2;
}

int div(int num1, int num2)
{
    return num1 / num2;
}

}