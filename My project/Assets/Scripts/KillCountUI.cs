using UnityEngine;
using TMPro;

public class KillCountUI : MonoBehaviour
{
    public TMP_Text label;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health.killCount = 0;  // 게임 시작 시 킬 카운트 초기화
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "Kill  " + Health.killCount;  // 킬 카운트 표시
    }
}
