using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerData playerData;
    private PlayerMoveForce playerMove;

    private void Start()
    {
        playerData = GetComponent<PlayerData>();
        playerMove = GetComponent<PlayerMoveForce>();
    }

    private void OnCollisionEnter(Collision other)
    {
          if (other.gameObject.CompareTag("Bullets"))
        {
                Destroy(other.gameObject);
                playerData.Damage(other.gameObject.GetComponent<ObstaculeData>().DamagePoints);
                if (playerData.HP <= 0)
                {
                     transform.position = playerData.StartPosition;
                     playerData.Healing(5);
                }
                GameManager.Score--;
                Debug.Log(playerData.HP);
                Debug.Log(GameManager.Score);
        }

          if (other.gameObject.CompareTag("Spikes"))
        {          
                GameManager.Score--;
                playerData.Damage(other.gameObject.GetComponent<ObstaculeData>().DamagePoints);
                if (playerData.HP <= 0)
                {
                     transform.position = playerData.StartPosition;
                     playerData.Healing(5);
                }
                Debug.Log(GameManager.Score);
        }
     
    }

    private void OnCollisionExit(Collision other)
    {
    
    }

    private void OnCollisionStay(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
          if (other.gameObject.CompareTag("Jewel"))
        {        
                Destroy(other.gameObject);  
                GameManager.Score++;
                Debug.Log(GameManager.Score);
        }  

          if (other.gameObject.CompareTag("Life"))
        {          
                Destroy(other.gameObject);
                playerData.Healing(other.gameObject.GetComponent<LifeUpData>().HealPoints);
                Debug.Log(GameManager.Score);
        } 

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
