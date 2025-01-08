using UnityEngine;

public class VariableType : MonoBehaviour
{
    // 정수 타입

    [Header("정수타입")]
    // int = -21억 4천만 ~ 21억 4천만, 크기 : 4byte
    public int inttype = 0;

    // long : -920경 ~ -920경, 크기 : 8byte
    public long longType = 0;

    // short : -3만 27백 ~ 3만 27백, 크기: 2byte
    public short shortType = 0;

    //byte : 0 ~ +255, 크기: 1byte (R, G, B, A) 4byte
    public byte byteType = 0;


    //실수 타입
    [Header("실수타입")]
    //float : ? ~ ?, 크기 : 4byte
    public float floatType = .0f;
    // //크기 : 8byte
    public double doubleType = 0.0;

    //128비트 : 16byte
    public decimal decimalType = 0;

    [Header("문자 타입")]
    public string stringType = "";

    [Header("부울타입")]
    public bool boolType;
    void Start()
    {
        //y = f(x)
        // out 메소드이름 (in) {작업}
        //sizeof()를 활용해서 int와 long 크기 비교 결과를 콘솔창에 출력
        //결과 : int : , long : ?

        //무언가의 크기를 가져오는 함수 : sizeof()
        //Debug.Log($"int : {sizeof(int)}");
        //Debug.Log($"long : {sizeof(long)}");
        //Debug.Log($"short : {sizeof(short)}");
        //Debug.Log($"byte : {sizeof(byte)}");
        //Debug.Log($"float : {sizeof(float)}");

        //floatType = 3.141592f;
        //Debug.Log($"float : {floatType}");

        // doubleType = 3.14;
        // Debug.Log($"Double : {doubleType}");

        // inttype = (int)3.14f;
        // Debug.Log($"inttype : {inttype}");

        // floatType = (float)inttype;
        // Debug.Log($"float : {floatType}");
        
        // String의 크기?
        // Debug.Log($"String Size = {}");
       
        //문자 내용은 xxxx입니다.
        //string result1 = $"문자 내용은 {stringType}입니다.";
        //string result2 = $"문자의 길이는 {stringType.Length}입니다.";
        //string result3 = $"asdasfads";

        // Debug.Log("\"안녕하세요\"");
        // Debug.Log("\"안녕하세요\"");

        //String 내역 출력
        //Debug.Log(result1 + result2 + result3);

        //부울의 크기
        // 값: True, False  크기 1byte
        string boolsize = $"Bool Size = {sizeof(bool)}";
        string boolvalue = $"Bool Value = {boolType}";

        Debug.Log(boolvalue);

    }

        void Update()
    {
        //Debug.Log($"정수(Integer) = {inttype}");
        //Debug.Log($"롱타입(Long) = {longType}");
        //Debug.Log($"short : {shortType}");
        //Debug.Log($"byte : {byteType}");
        //Debug.Log($"플롯타입(float) : {floatType}");
    }
}

//비트(bit), 바이트(byte)
//00000000 8bit = 1byte
//11
//2 ^ 8 = 256가지
// 4 byte = 32bit
// 8 byte = 64bit
// 16 byte = 128bit

//큐비트
//01