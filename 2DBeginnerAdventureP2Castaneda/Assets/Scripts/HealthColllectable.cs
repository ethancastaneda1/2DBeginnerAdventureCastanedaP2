using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColllectable : MonoBehaviour
{
    public AudioClip collectedClip;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SugarLandController controller = other.GetComponent<SugarLandController>();
        if (controller != null)
        {     
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }

            

        }
    }
}
