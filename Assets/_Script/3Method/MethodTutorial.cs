using UnityEngine;

public class MethodTutorial : MonoBehaviour
{
    private void Start()
    {
        //Method1();
    }

        // (지역 -> 멤버) 변수
        int volume = 10;
        public int volume2;

        public int num1, num2;
    
    //메소드 선언
    private void Method1(/* input 파라미터 */)
    {
        //Debug.Log($"{volume}");
    }

    public void Method2()
    {
        //Debug.Log(volume);
    }

    //덧셈
    //Add 메소드를 만들고 (MethodTutorial)
    //멤버변수 A, B (MethodTutorial2) 
    //Add 메소드를 활용해서 로그로 출력 (MethodTutorial2)

    //Add 메소드 선언
    public int Add(int x, int y)
    {
        return x+y;
    }

    public int Minus(int x, int y)
    {
        return x-y;
    }

    public int Mul(int x, int y)
    {
        return x*y;
    }
}
