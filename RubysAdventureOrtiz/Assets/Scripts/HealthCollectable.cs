using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyControler controller = other.GetComponent<RubyControler>();
        
        if (controller != null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
            Debug.Log("Object that entered the trigger is: " + other);
        }
    }
}    