using UnityEngine;
using TMPro;

public class CalculatorUI : MonoBehaviour
{
    //SerializeField : 프라빗한 것을 인스펙터에 노출
    [Header("덧셈")]
    [SerializeField] private TextMeshProUGUI tmptitle;
    [SerializeField] private TextMeshProUGUI tmpinfo;

    [Header("나눗셈")]
     [SerializeField] private TextMeshProUGUI tmptitle1;
    [SerializeField] private TextMeshProUGUI tmpinfo1;

    [Header("나머지")]
     [SerializeField] private TextMeshProUGUI tmptitle2;
    [SerializeField] private TextMeshProUGUI tmpinfo2;



    //HideInInspector : 퍼브릭한 것을 인스펙터에서 숨김
    [HideInInspector] public string info;
     [HideInInspector] public string info1;
      [HideInInspector] public string info2;

    [Header("입력값")]
    public int A;
    public int B;

    void Update()
    {
        //string 타입 <= int 타입
        info = $"{add(A,B)}";
        tmpinfo.text = $"{info}";
        tmptitle.text = $"{A} + {B} = ";

        info1 = $"{div(A,B)}";
        tmpinfo1.text = $"{info1}";
        tmptitle1.text = $"{A} / {B} = ";

        info2 = $"{mod(A,B)}";
        tmpinfo2.text = $"{info2}";
        tmptitle2.text = $"{A} % {B} = ";
    }

    // 1. 덧셈 함수를 만든다.
    // 2. A, B를 입력받는다.
    // 3. 결과를 tmpinfo 출력한다.
    int add(int x, int y)
    {
         return x+y;
    }

    int div(int x, int y)
    {
        return x/y;
    }

    int mod(int x, int y)
    {
        return x%y;
    }
}
