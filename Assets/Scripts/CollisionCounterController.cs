using System;
using UnityEngine;

public class CollisionCounterController : MonoBehaviour
{
    public Action _objectCollision;
    private int _collisionCount;

    private void OnCollisionEnter(Collision collision)
    {
        _collisionCount++;
        _objectCollision?.Invoke();
    }
    
    public int GetСollisionCountReset()
    {
        return _collisionCount = 0;
    }
    
    public int GetСollisionsСount()
    {
        return _collisionCount;
    }
}