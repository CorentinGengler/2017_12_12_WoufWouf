using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCharacter  : Dog
{

    #region Public Members
    public Rigidbody _Rigidbody;
    public float _force;
    public AudioSource _DogSound;
    public SwitchBark ScriptBark; 
    #endregion
    

    #region Public Void
    public override void Bark(float volume, float frequence)
    {
        ScriptBark.SwitchToNextBark();
        _DogSound.volume = volume;
        _DogSound.Play();
    }


    public override void Jump(float heighCm)
    {
        _Rigidbody.AddForce(Vector3.up * heighCm * _force, ForceMode.Impulse);
    }
    #endregion


    #region System

    void Start () 
    {
		
	}
    void Awake () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
