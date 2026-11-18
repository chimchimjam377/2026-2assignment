using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasShield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);  // true
        Debug.Log(isDead && !hasShield);  // false
        Debug.Log(isDead || hasShield);  // true , true
        Debug.Log(!(hp > 0) == isDead);  // true
    }
    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;  
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }


    [ContextMenu("체력 상태")]
    void HpState()
    {
        int hp = 5;
        int maxHp = 10;
        float ratio = (float)hp / maxHp;
        if (ratio >= 0.7f)
        {
            Debug.Log("양호");
        }
        else if (ratio >= 0.3f)
        {
            Debug.Log("주의");
        }
        else
        {
            Debug.Log("위험");
        }
    }

    [ContextMenu("예측 2")]
    void Predict2()
    {
        int score = 95;
        if (score >= 60) Debug.Log("C");
        else if (score >= 80) Debug.Log("B");
        else if (score >= 90) Debug.Log("A");

        if (score >= 90) Debug.Log("A");
        if (score >= 80) Debug.Log("B");
        if (score >= 60) Debug.Log("C");
    }


    [ContextMenu("중괄호")]
    void Braces()
    {
        int hp = 10;
        if (hp <= 0)
            Debug.Log("사망");
        Debug.Log("게임 오버");

        if (hp <= 0)
        {
            Debug.Log("사망");
            Debug.Log("게임 오버");
        }
    }
    [ContextMenu("무기")]
    void Weapon()
    {
        int weaponId = 2;
        switch (weaponId)
        {
            case 1:
                Debug.Log("검");
                break;
            case 2:
                Debug.Log("활");
                break;
            default:
                Debug.Log("맨손");
                break;
        }
    }

    [ContextMenu("무기 종류")]
    void WeaponType()
    {
        int weaponId = 2;
        switch (weaponId)
        {
            case 1:
            case 2:
                Debug.Log("근접 무기");
                break;
            case 3:
                Debug.Log("원거리 무기");
                break;
        }
    }









}
