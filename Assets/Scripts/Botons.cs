
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botons : MonoBehaviour
{
    Jugador Player;
    public Animator anim;
    void Start()
    {
        Player = GameObject.FindObjectOfType<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dretaOn()
    {
        Player.XMOVEMENT(1);
        anim.SetBool("Walk", true);

    }
    public void dretaOff()
    {
        Player.XMOVEMENT(0);
        anim.SetBool("Walk", false);

    }

    public void esquerraOn()
    {
        Player.XMOVEMENT(-1);
        anim.SetBool("Walk_back", true);
    }

    public void esquerraOff()
    {
        Player.XMOVEMENT(0);
        anim.SetBool("Walk_back", false);
    }
}
