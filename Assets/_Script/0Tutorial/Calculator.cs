//네임스페이스 (NameSpace)
using UnityEngine;


//클래스 (Class)
public class Calculator : MonoBehaviour
{
    //멤버 변수 (Variables)
    public int num1;
    public int num2;

    //많이 쓰이거나, 상속 받은, 공용 영역 (Public Area)
    //메소드, 함수, 서브루틴 (Method, Function, SubRoutine)
       void Start()
    {
        //메소드를 호출 (Method Call)
        Debug.Log($"{num1} + {num2} = {plus(num1, num2)}");
        Debug.Log($"{num1} - {num2} = {minus(num1, num2)}");
        Debug.Log($"{num1} * {num2} = {mul(num1, num2)}");
        Debug.Log($"{num1} / {num2} = {div(num1, num2)}");
    }

//개인적인 영역 (Private Area)

// 메소드를 선언 (Method Declare)
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