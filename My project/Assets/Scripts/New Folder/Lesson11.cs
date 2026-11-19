using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    public int[] golds = { 300, 1200, 50, 800 };



    [ContextMenu("배열 실습")]
    public void UheheGold()
    {
        int total = 0;
        for (int i = 0; i < golds.Length; i++)
        {
            Debug.Log(i + "번: " + golds[i]);
            total += golds[i];
        }
        Debug.Log("합계 " + total);

    }
}
