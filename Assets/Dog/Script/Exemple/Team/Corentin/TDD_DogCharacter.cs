using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDD_DogCharacter  : MonoBehaviour
{

    #region Public Members

    [SerializeField]
    private Dog _dog;
    private IDog _dogInterface;

    [SerializeField]
    private float _timeBetweenJumpMin = 0.1f;
    [SerializeField]
    private float _timeBetweenJumpMax = 5f;

    [SerializeField]
    private float _timeBetweenBarkMin = 0.5f;
    [SerializeField]
    private float _timeBetweenBarkMax = 3f;
    #endregion


    #region Public Void

    #endregion


    #region System

    void Start () 
    {
        StartCoroutine(Bark());
        StartCoroutine(Jump());
    }

    private IEnumerator Bark()
    {
        while (true)
        {
            yield return new WaitForSeconds(
               UnityEngine.Random.Range(_timeBetweenBarkMin, _timeBetweenBarkMax));
            _dog.Bark(UnityEngine.Random.Range(-0.5f, 2f), UnityEngine.Random.Range(0, 1000));
            

        }

    }
    private IEnumerator Jump()
    {
        while (true)
        {
            yield return new WaitForSeconds(
                UnityEngine.Random.Range(_timeBetweenJumpMin, _timeBetweenJumpMax));
            _dog.Jump(UnityEngine.Random.Range(100, 200));
        }

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
