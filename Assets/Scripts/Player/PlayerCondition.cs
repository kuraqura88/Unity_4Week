using UnityEngine;
using System;

public interface IDamagable
{
    void TakePhysicalDamage(int damage);
}
public class PlayerCondition : MonoBehaviour, IDamagable
{
    public UiCondition uiCondition;
    public PlayerController playerController;

    Condition health { get { return uiCondition.health; }}
    Condition hunger {  get { return uiCondition.hunger; }}
    Condition stamina {  get { return uiCondition.stamina; }}

    public float noHungerHealthDecay;

    public event Action onTakeDamage;

    void Start()
    {
        playerController = CharacterManager.Instance.Player.GetComponent<PlayerController>();
    }

    void Update()
    {
        hunger.Subtract(hunger.passiveValue * Time.deltaTime);
        stamina.Add(stamina.passiveValue * Time.deltaTime);

        if (hunger.curValue == 0.0f)
        {
            health.Subtract(noHungerHealthDecay * Time.deltaTime);
        }
        if(health.curValue == 0.0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }

    public void Eat(float amount)
    {
        health.Add(amount);
    }

    public void UseSpeedUp(float amount, float Duration)
    {
        playerController.SpeedUp(amount, Duration);
    }
    
    public void Die()
    {
        Debug.Log("Á×À½");
    }

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
        onTakeDamage?.Invoke();
    }

    public bool UseStamina(float amount)
    {
        if(stamina.curValue - amount < 0f)
        {
            return false;
        }

        stamina.Subtract(amount);
        return true;
    }
}
