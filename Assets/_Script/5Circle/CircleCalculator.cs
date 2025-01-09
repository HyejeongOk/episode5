using UnityEngine;

public class CircleCalculator : MonoBehaviour
{
    public int radius;
    const float PI = 3.14f;
    [ReadOnly] public float area;
    [ReadOnly] public float surround;

    void Start()
    {
    }
      public float Area(int r)
    {
        return PI * r * r;
    }

    public float Surround(int r)
    {
        return 2 * PI * r;
    }
   
}
