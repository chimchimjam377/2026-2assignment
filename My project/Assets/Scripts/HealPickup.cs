using UnityEngine;

public class HealPickup : MonoBehaviour
{
    public int amount = 20; // 회복량
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0); // 회전
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        other.GetComponent<Health>().Heal(amount);
        Destroy(gameObject);
    }

}
