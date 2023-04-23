using UnityEngine;

public class TimeControllerView : MonoBehaviour
{
    [SerializeField] private TimeView _timeView;

    private float _currentTime;
    
    private void Update()
    {
        _currentTime += Time.deltaTime;
        _timeView.Display(_currentTime);
    }

    public void ResetTime()
    {
        _currentTime = 0;
    }
}