using UnityEngine;

public class CollisionСounterControllerView : MonoBehaviour
{
   [SerializeField] private CollisionScoreView _collisionScoreView;
   [SerializeField] private CollisionCounterController _collisionCounterController;

   private void Start()
   {
      _collisionCounterController._objectCollision += СountСollisions;
   }

   private void СountСollisions()
   {
      var collisionCount = _collisionCounterController.GetСollisionsСount();
      _collisionScoreView.Display(collisionCount);
   }

   public void ResetСollisionCount()
   {
      var resetCount = _collisionCounterController.GetСollisionCountReset();
      _collisionScoreView.Display(resetCount);
   }

   private void OnDestroy()
   {
      _collisionCounterController._objectCollision -= СountСollisions;
   }
}