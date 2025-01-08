using UnityEngine;

public class VariableTutorial : MonoBehaviour
{
    // 멤버 변수의 영역
    [SerializeField] private int health; //0 초기화


//Start는 초기값 세팅 역할
    void Start()
    {
        // 무언가는 하겠다!
        
        //health에 저장된 값을 확인하고 싶다

        //새로운 캐릭터마다 체력 설정을 적용
        health = 300; // 기획상의 설정값을 넣는다

        // Debug.Log()는 콘솔창에 값을 출력하는 역할
        Debug.Log($"health는 : {health}");
    }

//Update는 실시간으로 변화하는 값을 반영
    void Update()
    {
        Debug.Log($"health : {health}");
    }
}
