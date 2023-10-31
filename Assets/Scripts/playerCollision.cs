using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement pMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            pMovement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }

        ;
    }
}
