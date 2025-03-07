using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f; // Base speed (private with SerializeField for Inspector access)

    // ENCAPSULATION
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Set initial player color to yellow
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    void Update()
    {
        // 3D movement using Horizontal and Vertical axes
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0, moveZ).normalized * speed;
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z); // Preserve Y velocity for gravity
    }

    void OnTriggerEnter(Collider other)
    {
        Orb orb = other.GetComponent<Orb>();
        if (orb != null)
        {
            orb.ApplyEffect(this); // ABSTRACTION
            Destroy(other.gameObject); // Remove orb after collection
        }
    }
}