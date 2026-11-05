using UnityEngine;

public class RewardCalc : MonoBehaviour
{

    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;


    [ContextMenu("정산")]
    void Setle()
    {
        int minutes = playSeconds / 60;
        int seconds = playSeconds % 60;
        int hours = minutes / 60;
        int finalseconds = minutes - (hours * 60);

        Debug.Log(hours + "시간" +  finalseconds  + "분" + seconds + "초");

        int memderPerGold = gold / members;
        int rederBonus = gold % members;

        Debug.Log("1인당 : " + memderPerGold + "G");
        Debug.Log("리더 보너스" + rederBonus + "G");

        int exp = kills * expPerKill;
        int totalExp = (int)(exp * expRate);

        Debug.Log("경험치" + totalExp + "(기본 " + exp + ")");

        int level = (exp / 100) +1;
        int currentlevel = 100 - (exp % 100);
        Debug.Log("Lv" + level + ", 다음 레벨 까지" + currentlevel);

        float Damage =  (float)totalDamage / hits;
        Debug.Log("평균 데미지 " + Damage);

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
