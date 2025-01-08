using UnityEngine;

public class VariableDialog : MonoBehaviour
{
    [Header("대화상대")]
    public string player1;
    public string player2;

    [Header("대사")]
    public string dlg1;
    public string dlg2;
    public string dlg3;
    public string dlg4;
    public string dlg5;
    public string dlg6;
    public string dlg7;
    public string dlg8;
    public string dlg9;
    public string dlg10;

    [Header("데이터")]
    public float temperature;
    public string ampm;
    public int time;
    public bool answer;
    public int num1;
    public int num2;
    public string mark;

    void Start()
    {
        string d1 = $"{player1}{dlg1}\n";
        string d2 = $"{player2}{dlg2}\n";
        string d3 = $"{player1}{temperature}{dlg3}\n";
        string d4 = $"{player2}{dlg4}\n";
        string d5 = $"{player1}{dlg5}\n";
        string d6 = $"{player2}{time}{dlg6}\n";
        string d7 = $"{player1}{dlg7}\n";
        string d8 = $"{player2}{answer}{dlg8}\n";
        string d9 = $"{player2}{num1}{mark}{num2}{dlg9}\n";
        string d10 = $"{player1}{mul(num1,num2)}{dlg10}";
        
        string dialog = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10;
        Debug.Log(dialog);
    }
    int mul(int x, int y)
    {
        return x * y;
    }
}

        //철수 : 안녕, 오늘 날씨 정말 좋다.
        //영희 : 그러게, 온도가 어떻게 되?
        //철수 : xx℃야.
        //영희 : 꽃들도 예쁘게 피었더라.

        //철수 : 그래 지금 몇시야?
        //영희 : xx시야

        //철수 : 근처 공원으로 가자
        //영희 : True, False
        //영희 : 7 * 6은
        //철수 : xx이야