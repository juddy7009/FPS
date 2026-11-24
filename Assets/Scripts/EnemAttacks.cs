using UnityEngine;

public class EnemAttacks : MonoBehaviour
{
    PlayerHealth target;

    [SerializeField] float damage = 40f;

    void Start()
    {
        target = FindAnyObjectByType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if(target == null)
        {
            return;
        }

        //print("Ouch!");
        target.TakeDamage(damage);
    }
}
