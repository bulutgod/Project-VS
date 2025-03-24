using System.Collections;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int health;

    public void Hitted (int damagevalue)
    {
        health -= damagevalue;
        if(health < 0)
        {
            StartCoroutine(Destroy());
        }
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(7f);
        Destroy(gameObject);

    }
}
