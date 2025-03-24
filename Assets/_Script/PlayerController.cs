using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public HealthController healthController;

    void Start()
    {
        healthController = GetComponent<HealthController>();
        healthController.health = 100;
    }

    
    void Update()
    {
        
    }
}
