using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColllectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        SugarLandController controller = other.GetComponent<SugarLandController>();
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);

        }
    }
}
