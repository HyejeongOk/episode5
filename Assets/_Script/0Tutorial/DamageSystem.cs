using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    public int health = 100;
    public int damage = 5;
        void Start()
    {
         Debug.Log($"데미지 {damage}을 입고, 체력이 {Damage(damage)}으로 감소");
         Debug.Log($"데미지 {damage}을 입고, 체력이 {Damage(damage)}으로 감소");
         Debug.Log($"데미지 {damage}을 입고, 체력이 {Damage(damage)}으로 감소");
    }
    

    int Damage(int damage)
    {
       return health = health - damage;
    }
           
}
