using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret_enable : MonoBehaviour {
    public GameObject acamera,ship,head;
    bool usingThis = false;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.W) && (!other.gameObject.GetComponent<Player_Movement>().busy || usingThis))
        {
            if (other.gameObject.GetComponent<Player_Movement>().speed != 0)
                other.gameObject.GetComponent<Player_Movement>().speed = 0;
            else other.gameObject.GetComponent<Player_Movement>().speed = 10000;
            head.GetComponent<Turret>().enabled = !head.GetComponent<Turret>().enabled;
            other.gameObject.GetComponent<SpriteRenderer>().enabled = !other.gameObject.GetComponent<SpriteRenderer>().enabled;
            acamera.GetComponent<Camera>().enabled = !acamera.GetComponent<Camera>().enabled;
            ship.GetComponent<SpriteRenderer>().enabled = !ship.GetComponent<SpriteRenderer>().enabled;
            other.gameObject.GetComponent<Player_Movement>().busy = !other.gameObject.GetComponent<Player_Movement>().busy;
            usingThis = !usingThis;
        }
    }
}
