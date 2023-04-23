using TMPro;
using UnityEngine;

public class TimeView : MonoBehaviour
{
    [SerializeField] private TMP_Text _time;

    public void Display(float currentTime)
    {
        _time.text = "Времени прошло: " + Mathf.Round(currentTime);
    }
}


