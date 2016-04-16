using UnityEngine;
using System.Collections;
using Fungus;
public class TestCharacter1 : Character {
    

    public override void Interact(string name)
    {
        Debug.Log(name);
        if(HasMetPlayer == false)
        {
            dialogueTree.SendFungusMessage("startTreeFirstTime" + _name);
            HasMetPlayer = true;
        }
        else if (HasMetPlayer)
        {
            dialogueTree.SendFungusMessage("startTree" + _name);
        }
        
    }
    public override void Interact()
    {
        Debug.Log(_name);
    }
}
