using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ActivateUI : MonoBehaviour
{
    public Rigidbody rb;   
    public GameObject[] Prefabs;
    
    //use instantiation to create a new block or enemy

    public abstract class Command
    {
        public abstract void Execute();
    }

    public class Spawn1 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 1
        }
    }

    public class Spawn2 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 2
        }
    }
    public class Spawn3 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 3
        }
    }
    public class Spawn4 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 4
        }
    }
    
    Command buttonA = new Spawn1();
    Command buttonB = new Spawn2();
    Command buttonC = new Spawn3();
    Command buttonD = new Spawn4();

    void getInput()
    { 
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(Prefabs[0], new Vector3(-5, 3, 0), Quaternion.identity);
            buttonA.Execute();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(Prefabs[1], new Vector3(-2, 3, 0), Quaternion.identity);
            buttonB.Execute();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(Prefabs[2], new Vector3(0.5f, 0.5f, 0), Quaternion.identity);
            buttonC.Execute();
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            Instantiate(Prefabs[3], new Vector3(3, 0.5f, 0), Quaternion.identity);
            buttonD.Execute();
        }
    }

}
