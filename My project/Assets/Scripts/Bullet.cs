using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int damage = 10;
    public float lifeTime = 2f;
    public string targetTag = "Enemy"; // The tag of the target object
    public string ownerTag = "Player"; // The tag of the owner object


    void Start()
    {
        Destroy(gameObject, lifeTime);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.isTrigger) return;
        if (other.CompareTag(ownerTag)) return;

        if (other.CompareTag(targetTag))
        {
            Health hp = other.GetComponent<Health>();
            if (hp != null) hp.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
