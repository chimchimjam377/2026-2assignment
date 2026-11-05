using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp = 7;
    public int maxHp = 10;

    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("체력 비율 : " + a + "%");

        int b = currentHp * 100 / maxHp;
        Debug.Log("체력 비율 : " + b + "%");
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
