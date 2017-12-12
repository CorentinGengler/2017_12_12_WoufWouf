using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBark  : MonoBehaviour
{

    #region Public Members
    public List<AudioClip> ListOfBarks = new List<AudioClip>();
    public AudioSource m_audioSourceOfBark;
    #endregion


    #region Public Void
    public void SwitchToNextBark()
    {
        if(i<ListOfBarks.Count-1)
        {
            i++;
        }
        else
        {
            i = 0;
        }
        m_audioSourceOfBark.clip = ListOfBarks[i];
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
    private int i = 0;
    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
