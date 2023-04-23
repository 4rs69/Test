using UnityEngine;

public class AttractionPointController : MonoBehaviour
{
    [SerializeField] private Transform _attractionPoint;
    [SerializeField] private float _attractionForce = 10f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var direction = _attractionPoint.position - transform.position;
        _rigidbody.AddForce(direction.normalized * _attractionForce, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        _rigidbody.velocity = Vector3.zero;
    }
}