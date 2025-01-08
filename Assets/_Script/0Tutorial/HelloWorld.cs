using UnityEngine;

class HelloWorld : MonoBehaviour
{
    public int number1;
    public int number2;
    public string text;
    public string text2 = "텍스트2";

    private void Start()
    {
       Debug.Log("<b><i><color=red>시작 </color></i></b>" + $"<b><color=blue>{number1}</color></b>\n" + " " + $"<color=yellow>{text}</color>");
       Debug.Log($"{number1} {number2}");
       Debug.Log($"{text} {text2}");
       Debug.Log($"{number1} + {number2} = {number1 + number2}");
       //Debug.Log(number1+number2);

    }
}