using UnityEngine;

public class CollisionForceController : MonoBehaviour
{
    [SerializeField] private float _pushForce = 100f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        var direction = transform.position - collision.transform.position;
        _rigidbody.AddForce(direction * _pushForce);
    }
}