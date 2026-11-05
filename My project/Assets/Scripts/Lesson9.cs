using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public int attack = 10;


    public int gold = 100;

    int KillCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(attack);

        Hello();
    }

    [ContextMenu("Hello 기능 테스트")]
    void Hello()
    {
        
        Debug.Log("Hello, World!");
    }
    [ContextMenu("테스트 1")]
    void Test1()
    {
        Debug.Log("테스트 1");
    }

    [ContextMenu("테스트 2")]
    void Test2()
    {
        int hp = 6974;
        Debug.Log("테스트 2 : " + hp);
    }

    [ContextMenu("Gold 기능 테스트")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("예측1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp -3;
        Debug.Log("예측1 : " + hp);
        hp = 20;
        Debug.Log("예측1 : " + hp);
        int maxHp = hp;
        hp =5;
        Debug.Log("예측1 : " + maxHp);
    }

    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;
        KillCount = KillCount + 1;
        Debug.Log(attack - defense);
        Debug.Log("처치 수 : " + KillCount);
    }

    public string itemName = "빨간 포션";
    public int price = 100;
    public float discount = 0.5f;
    public bool isSaleOut = true;

    [ContextMenu("아이템 정보 확인")]
    void ShowPrice()
    {
        float finalPrice = price * discount;

        Debug.Log(itemName + "의 최종 가격 : " + finalPrice);
    }

    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        
        Debug.Log("최대값 : " + gold);
        gold = gold + 1;
        Debug.Log("최대값 : " + gold);

        byte red = 255;
        red++;
        Debug.Log(red);
    }

    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1+0.2;
        Debug.Log( d == 0.3 );

        float half = 1/2;
        Debug.Log(half);
    }

    [ContextMenu("자료형")]
    void Type()
    {
        int level = 30;
        byte red = 255;
        char grade = 'S';
        float speed = 5.5f;
        bool isHigh = level >= 10;

        Debug.Log(level + " " + red + " " + grade);
        Debug.Log(speed + " " + isHigh);
    }

    [ContextMenu("예측2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log("예측2 : " + (hp / maxHp));
        Debug.Log("예측2 : " + ((float)hp / maxHp));
        Debug.Log("예측2 : " + (hp / 2));
        Debug.Log("예측2 : " + (hp / 2f));
        Debug.Log("예측2 : " + (hp % 2));
    }

    [ContextMenu("나머지")]
    void Remainder()
    {
        int shotCount = 6;
        int totalSeconds = 135;

        bool isEven = shotCount % 2 == 0;
        bool strongShot = totalSeconds % 3 == 0;
        int min = totalSeconds / 60;

        int sec = totalSeconds % 60;

        Debug.Log(min+ ":" + sec);

    }

    [ContextMenu("예측3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합:" + (a + b));
        Debug.Log("합:" + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log("HP" + 7/2);
    }

}
