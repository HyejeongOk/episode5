using System;
using UnityEngine;

public class Operator1 : MonoBehaviour
{
    //연산자 (Operator)

    public float A;
    public float B;
    public float C;

    public bool bA;
    public bool bB;
    public bool bC;

    [Header("연산자 결과")]
    [ReadOnly] public bool andOp; // AND 연산 결과
    [ReadOnly] public bool orOp; // OR 연산 결과
    [ReadOnly] public bool notOp; // NOT 연산 결과
    [ReadOnly] public bool ifOp; // 삼항 연산 결과
    [ReadOnly] public string ifOpstring; // 삼항 연산 결과 문자
    [ReadOnly] public string ageString; // 삼항 연산 결과 문자
    [ReadOnly] public string bmiString; 

    const int adultage = 19;
    public float w;
    public float h;

    // public string tA;
    // public string tB;

    void Start()
    {
        // float mod = Mod(A,B);
        // string result = $"나머지 연산 = {mod}";
        // // % 나머지 연산자료 A, B를 연산하기 -> 로그
        // // % 연산자용 메소드를 만든다.
        // Debug.Log($"{A} % {B} = {result}");

        // 5 , 8

        // 비교연산자 (왼쪽 기준)
        // == ? True : False
        // != ? True : False
        // <= ? (이하)
        // >= ? (이상)
        // < ? (미만)
        // > ? (초과)

        // bool A op B ?  16 >= 7 TRUE

        // Debug.Log($" == {tA == tB}");
        // Debug.Log($" == {tA != tB}");
        // Debug.Log($" == {tA.Length <= tB.Length}");

        //논리연산
        // && 그리고 (AND연산) : 모두가 참 일 때 TRUE
        // || 또는   (OR연산) : 둘 중 하나만 참 일 때 TRUE
        // !  아니다 (NOT연산)

        // A = 13, B = 13, C = 10
        // 반환 : True, False 순서는 ()

        // 삼항연산
        // 조건1 ? 참 : 거짓;
        
    }

    public int age  = 20;
    

    void Update()
    {
        andOp = (A == B);
        andOp = (A > B);
        andOp = bA && bB && bC;
        orOp= bA || bB || bC;
        notOp = !bA;

        ifOp = bA == bB? true : false;

        ifOpstring = bA == bB ? "bA bB가 같다" : "bA bB가 다르다";

        // 변수 = xx ? yy : zz;

        //ageString = isAdult(age);
        bmiString = isbmi(w,h);
        Debug.Log(bmiString);
    }

    // 나머지 연산자
    public float Mod(float x, float y)
    {
        return x % y;
    }

    // bool : True, False
    // 비교 연산
    // bool CompareOp(int x, int y)
    // {
    //     // == ? 같으면 True : 다르면 False
    //     return x == y;
    // }


    //19세 이상 성인, 미성년

    //목적  : 나이를 입력(int age) 결과 : 성인, 미성년
    string isAdult(int a)
    {
        //삼항 연산
        return ageString = a > 19 ? "성인" : "미성년";
    }

    // bmi 수치 : 몸무게(60) / (키(1.8) * 키)
    // 20 이상 과체중 아니면 표준
    string isbmi(float weight, float height)
    {
        float result = weight / (height * height);
        return bmiString = result >= 20 ? "과체중" : "표준";
    }
}
