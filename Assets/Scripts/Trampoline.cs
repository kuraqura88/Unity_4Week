using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float bounceForce = 10f;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();

        if (rigidbody != null)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
