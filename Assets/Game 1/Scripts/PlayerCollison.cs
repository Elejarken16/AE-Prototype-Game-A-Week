using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    //public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //movement.enabled = false;
            //FindObjectiveOfType<GameManager>().EndGame();
        }
    }
}
