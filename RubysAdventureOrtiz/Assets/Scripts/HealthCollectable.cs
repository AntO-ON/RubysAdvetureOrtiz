using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyControler controler = other.GetComponent<RubyControler>();
        if (controler != null)
        {
            if(controller.
            controler.ChangeHealth (1);
            Destroy(gameObject);
        }
      Debug.Log("Object that entered the trigger is: " + other);  
    }
}
