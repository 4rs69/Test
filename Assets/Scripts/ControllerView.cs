using UnityEngine;
using UnityEngine.UI;

public class ControllerView : MonoBehaviour
{
    [SerializeField] private Button _resetСounters;
    [SerializeField] private TimeControllerView _timeControllerView;
    [SerializeField] private CollisionСounterControllerView _collisionСounterControllerView;

    private void Start()
    {
        _resetСounters.onClick.AddListener(_timeControllerView.ResetTime);
        _resetСounters.onClick.AddListener(_collisionСounterControllerView.ResetСollisionCount);
    }
}