using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName = "왕뿌뿡 응뿌찍";

    public float attack = 10f;
    public int level = 1;

    public bool isBoss =    false;

    [ContextMenu("스탯 확인")]
    void ShowStat()
    {
        Debug.Log("이름 : " + playerName);
        Debug.Log("공격력 : " + attack);
        Debug.Log("레벨 : " + level);
        Debug.Log("보스 여부 : " + isBoss);
    }


    
}
