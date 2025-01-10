using UnityEngine;

public class OPand2 : MonoBehaviour
{
    //
    public int a;
    void Start()
    {
        bool b= Comparea();
        Debug.Log(b);
    }

    bool Comparea()
    {
        bool c = (a>1)&&(a<10);
        return c;
    }

}
