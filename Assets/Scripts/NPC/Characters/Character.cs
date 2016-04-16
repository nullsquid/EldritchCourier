using UnityEngine;
using System.Collections;
using Fungus;
public abstract class Character : MonoBehaviour {

    public string _name;
    #region private variables
    private float _disposition;

    private bool _hasMetPlayer;
    #endregion


    #region public parameters
    public float Disposition
    {
        get
        {
            return _disposition;
        }
        set
        {
            _disposition = value;
        }
    }
    public bool HasMetPlayer
    {
        get
        {
            return _hasMetPlayer;
        }
        set
        {
            _hasMetPlayer = value;
        }
    }
    #endregion

    #region fungus flowcharts
    public Flowchart dialogueTree;
    #endregion

    public virtual void Interact(string name)
    {

    }
    public virtual void Interact()
    {
        Debug.Log("Interact");
    }

    

}
