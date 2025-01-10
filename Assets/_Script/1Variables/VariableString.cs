using UnityEngine;

public class VariableString : MonoBehaviour
{
    public string s;

    void Start()
    {
        
    }

    void Update()
    {
        //변수 i에 t의 변수 Length 대입
        //int i = s.Length;
        int getlength = GetLength(s);
        Debug.Log(getlength);
    }

    int GetLength(string t)
    {
       int i = t.Length;
       return i;
    }
}
