using UnityEngine;

public class ColliderColorizer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var contactPoints = collision.contacts;

        foreach (var contactPoint in contactPoints)
        {
            var collider = contactPoint.thisCollider;
            collider.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}