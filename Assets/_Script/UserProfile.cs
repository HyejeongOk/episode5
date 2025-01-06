using UnityEngine;

public class UserProfile : MonoBehaviour
{
    public string cookie;
    public int fight;

    public string school;
    public string blood;
    public int age;

        void Start()
    {
        SayHello();
        Print();
    }


void Print()
{
Debug.Log($"내 이름은 <b><color=green>{cookie}</color></b>이고. 전투력은 <b><color=green>{fight}</color></b>입니다. 나이는 {age}, 혈액형은 {blood}이고, {school} 다니고 있습니다.");
}

void SayHello()
{
    Debug.Log("안녕하세요");
}    
    void Update()
    {
        
    }
}
