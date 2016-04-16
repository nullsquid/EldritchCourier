using UnityEngine;
using System.Collections;

public abstract class Thing : MonoBehaviour {

    private string _name;

    #region public parameters
    public string Name
    {
        get
        {
            return _name;
        }

        
    }
    #endregion
}
