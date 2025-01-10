using UnityEngine;

public class Login : MonoBehaviour
{
    public string id;
    public string pw;
    public int exp;
    public bool login;

    void Start()
    {
        login = loginbox();
        if(login)
        {Debug.Log("로그인 성공");}
    }

    bool loginbox()
    {
        bool l = (id == "superman")&&(pw == "pw12345");
        bool w = l || (exp >=1000);
        return w;
    }
}
