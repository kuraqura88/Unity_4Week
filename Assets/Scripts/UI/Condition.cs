using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxValue;
    public float passiveValue;
    public Image uiBar;
    void Start()
    {
        curValue = startValue;
    }
    void Update()
    {
        uiBar.fillAmount = GetPercentage();
    }
    public void Add(float value)
    {
        curValue = Mathf.Min(curValue + value, maxValue); // curValue + value랑 maxValue를 비교해서 작은 값을 반환
    }
    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0.0f); // curValue - value랑 0을 비교해서 큰 값을 반환
    }
    float GetPercentage()
    {
        return curValue / maxValue;
    }
}
