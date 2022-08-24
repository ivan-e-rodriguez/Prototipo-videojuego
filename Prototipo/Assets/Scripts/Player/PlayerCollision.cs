using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerData playerData;
    private PlayerMoveCC playerMove;

    private void Start()
    {
        playerData = GetComponent<PlayerData>();
        playerMove = GetComponent<PlayerMoveCC>();
    }

    private void OnCollisionEnter(Collision other)
    {
/*         
        if (other.gameObject.CompareTag("Powerups"))
        {
            Destroy(other.gameObject);
            
            playerData.Healing(other.gameObject.GetComponent<Pumpkin>().HealPoints);
        }

        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("ENTRANDO EN COLISION CON " + other.gameObject.name);
            playerData.Damage(other.gameObject.GetComponent<Bullet>().DamagePoints);
            Destroy(other.gameObject);
            if (playerData.HP <= 0)
            {
                
            }
        }

        if (other.gameObject.CompareTag("Floor"))
        {
           playerMove.CanJump = true;
        } */
    }

    private void OnCollisionExit(Collision other)
    {
    
    }

    private void OnCollisionStay(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
/*         if (other.gameObject.CompareTag("Powerups"))
        {
            Destroy(other.gameObject);
    
            playerData.Healing(other.gameObject.GetComponent<Pumpkin>().HealPoints);
        } */
    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnControllerColliderHit(ControllerColliderHit hit) {
     
    }
}
