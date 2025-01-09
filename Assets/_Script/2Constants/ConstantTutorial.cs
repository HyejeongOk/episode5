//네임스페이스 영역
using UnityEngine;

//클래스 영역
public class ConstantTutorial : MonoBehaviour
{
#region 멤버변수
//Attribute
    [Header("스코어")]
    [Space, SerializeField] int score1;
    private const int MAX_SCORE = 123;

    [ReadOnly]
    public int score3;
#endregion

#region 상수

#endregion

#region 메소드 (함수)
    private void Start()
    {
        score1 = 7;

        Debug.Log($"{MAX_SCORE}");
    }
#endregion

    // void = f( )
    void Update()
    {
        //지역(Local) 변수
        //int score3 = score1;
        //업데이트에서 score1 -> score3 값을 (전달, 대입, 넣는다)
        score3 = score1;
        Debug.Log($"score3의 값은 {score3}");
    }
}