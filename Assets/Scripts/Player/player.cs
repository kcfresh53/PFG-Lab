using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Vector3 _moveDir;
    [SerializeField]
    private HealthBar healthBar;

    private float HP = 100;
    private float maxHP = 100;

    // Start is called before the first frame update
    void Start()
    {
        inputManager.Init(this);
        inputManager.GameMode();
        //update health bar
        updateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3) (speed * Time.deltaTime * _moveDir);
    }

    public void SetMovementDirection(Vector3 newDirection) 
    { 
        _moveDir = newDirection;
    }
    //health functions, to be optimized later
    public void SetHP(float newHP) 
    { 
        HP = newHP;
        updateHealthBar();
    }

    private void updateHealthBar()
    {
        healthBar.hp = HP;
        healthBar.maxHP = maxHP;
        healthBar.setHP(HP);
    }

    //debug functions
    public void SubHP(float value)
    {
        HP -= value;
        // clamp health to minimum
        HP = Mathf.Clamp(HP, 0, 100);
        SetHP(HP);
        Debug.Log(HP);
    }
    public void AddHP(float value)
    {;
        HP += value;
        // clamp health to maximum
        HP = Mathf.Clamp(HP, 0, 100);
        SetHP(HP);
        Debug.Log(HP);
    }
}
