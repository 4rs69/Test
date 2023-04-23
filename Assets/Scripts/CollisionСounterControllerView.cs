using JetBrains.Annotations;
using UnityEngine;

public class CollisionСounterControllerView : MonoBehaviour
{
   [SerializeField] private CollisionScoreView _collisionScoreView;
   [SerializeField] private CollisionCounterController _collisionCounterController;

   [UsedImplicitly]
   private void СountСollisions()
   {
      _collisionScoreView.Display(_collisionCounterController.CollisionCount);
   }

   public void ResetСollisionCount()
   {
      _collisionCounterController.CollisionCount = 0;
      _collisionScoreView.Display(_collisionCounterController.CollisionCount);
   }
   
}