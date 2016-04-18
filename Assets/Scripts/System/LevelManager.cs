using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(int levelIndex)
    {
        Application.LoadLevel(levelIndex);
    }
}
