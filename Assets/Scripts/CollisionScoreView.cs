using TMPro;
using UnityEngine;

public class CollisionScoreView : MonoBehaviour
{
   [SerializeField] private TMP_Text _collision;

   public void Display(int collision)
   {
      _collision.text = "Столкновений: " + collision;
   }
}