using UnityEngine;
using System.Collections;

public class TestCharacter2 : Character {

    public override void Interact(string name)
    {
        Debug.Log(name);
        if (HasMetPlayer == false)
        {
            dialogueTree.SendFungusMessage("startTreeFirstTime" + _name);
            HasMetPlayer = true;
        }
        else if (HasMetPlayer)
        {
            dialogueTree.SendFungusMessage("startTree" + _name);
        }

    }
}
