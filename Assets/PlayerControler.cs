using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

enum playerState { idle, falling, Grounded, climbing, overhangClimbing, dead };

public class PlayerControler : MonoBehaviour
{
    public int health;

    private SpriteRenderer sprite;
    public string PlayerID;
    public float Grip;
    public float damage;
    public bool murderer;

    float walkingSpeed;
    string horizontal;
    string vertical;
    string actionButtin;


    public float fireDelta = 0.3F;
    private float time = 0.0F;


    // Use this for initialization
    void Start()
    {
        health = 100;
        walkingSpeed = 3.0f;
        damage = 35;

        horizontal = PlayerID + "Horizontal";
        vertical = PlayerID + "Vertical";
        actionButtin = PlayerID + "Jump";
    }

 

    // Update is called once per frame
    void FixedUpdate()
    {
        Walking();
    }

    void Walking()
    {
        Vector3 walk = Vector3.zero;
        float h = Input.GetAxis(horizontal);
        float v = Input.GetAxis(vertical);
        walk = new Vector3(h, v, 0);
        this.transform.position += walk * walkingSpeed * Time.deltaTime;
    }

}

