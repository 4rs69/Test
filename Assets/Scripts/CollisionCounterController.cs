using UnityEngine;
using UnityEngine.Events;

public class CollisionCounterController : MonoBehaviour
{
    public UnityEvent<int> _cubeCollision;
    public int CollisionCount { get; set; }

    private void OnCollisionEnter(Collision collision)
    {
        CollisionCount++;
        _cubeCollision?.Invoke(CollisionCount);
    }
}