using UnityEngine;

public class CircleBehaviour : MonoBehaviour
{
    public CircleCalculator cc;
    void Start()
    {
        float resulta = cc.Area(cc.radius);
        cc.area = resulta;
        float results = cc.Surround(cc.radius);
        cc.surround = results;

        Debug.Log(cc.area);
        Debug.Log(cc.surround);
    }

  
}
