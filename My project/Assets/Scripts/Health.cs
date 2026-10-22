using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp;
    public Slider hpSlider;
    public static int killCount;     // 모든 Health 가 같이 쓰는 값 하나

    public float invincibleTime = 0f;   // 플레이어는 0.5
    float lastHitTime = -999f;

    public GameObject dropPrefab;
    public GameObject hitEffect;

    public float dropChance = 0.5f; // 50% 확률로 드롭


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
    }

    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        UpdateBar();
    }



    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;
        if (Time.time < lastHitTime + invincibleTime) return;
        lastHitTime = Time.time;

        currentHp -= damage;
        Debug.Log(name + " HP: " + currentHp);
        UpdateBar();

        Vector3 hitPos = transform.position + Vector3.up;
        if (hitEffect != null) Instantiate(hitEffect, hitPos, Quaternion.identity);

        if (currentHp <= 0) Die();
        else Blink();

    }



    void UpdateBar()
    {
        if (hpSlider != null)
            hpSlider.value = (float)currentHp / maxHp;
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            killCount++;  // 적 처치 수 증가 
            if(dropPrefab != null && Random.value < dropChance)
            {
                Vector3 pos = transform.position + Vector3.up * 0.5f;
                Instantiate(dropPrefab, pos, Quaternion.identity);
            }
            Destroy(gameObject);
             
        }
    }
    void Blink()
    {
        SetVisible(false);
        Invoke(nameof(ShowAgain), 0.1f);
    }

    void ShowAgain()
    {
        SetVisible(true);
    }

    void SetVisible(bool on)
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = on;
    }


}
