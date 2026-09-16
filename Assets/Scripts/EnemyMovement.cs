using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;

    Rigidbody2D myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.linearVelocity = new Vector2(moveSpeed, 0f);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;
        // todo
    }

    void FlipEnemyFacing()
    {
         transform.localScale = new Vector2(-Mathf.Sign(myRigidbody.linearVelocity.x), 1f);
    }
}
