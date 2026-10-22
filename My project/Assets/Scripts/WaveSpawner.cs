using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // 적 프리팹
    public Transform[] spawnPoints; // 스폰 위치
    public int firstCount = 3; // 첫 웨이브 적 수
    public int addPerWave = 2; // 웨이브마다 증가하는 적 수

    public float spawnGap = 1f; // 적 스폰 간격
    public TMP_Text waveText; // 웨이브 표시 UI

    int wave = 0; // 현재 웨이브 수

    int toSpawn = 0; // 이번 웨이브에서 남은 수

    float timer = 0f; // 스폰 타이머

    public int lastWave = 0;   // 0 이면 끝없음

    void SpawnOne()
    {
        int e = Random.Range(0, enemyPrefabs.Length);
        int s = Random.Range(0, spawnPoints.Length);
        Vector3 pos = spawnPoints[s].position;
        Instantiate(enemyPrefabs[e], pos,
            Quaternion.identity);
    }




    // Update is called once per frame
    void Update()
    {
        if (toSpawn > 0)    // 내보내는 중
        {
            timer += Time.deltaTime;
            if (timer < spawnGap) return;
            timer = 0f;
            SpawnOne();
            toSpawn--;
            return;
        }
        int alive = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (alive > 0) return;            // 다 잡을 때까지 대기

        if (lastWave > 0 && wave == lastWave)
        {
            GameManager.Instance.GameClear();
            enabled = false;
            return;
        }


        wave++;
        toSpawn = firstCount + addPerWave * (wave - 1);
        if (waveText != null) waveText.text = "WAVE " + wave;
    }

}

