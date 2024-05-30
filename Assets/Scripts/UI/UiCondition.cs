using UnityEngine;

public class UiCondition : MonoBehaviour
{
    public Condition health;
    public Condition hunger;
    public Condition stamina;

    // Start is called before the first frame update
    void Start()
    {
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}
