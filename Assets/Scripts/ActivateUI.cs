using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ActivateUI : MonoBehaviour
{
    public static GameObject Prefab1;
    public static GameObject Prefab2;
    public static GameObject Prefab3;
    public static GameObject Prefab4;

    private KeyCode LastKeyHit;
    
    void Start()
    {
        Prefab1 = GameObject.FindGameObjectWithTag("BrownBlock");
        Prefab2 = GameObject.FindGameObjectWithTag("YellowBlock");
        Prefab3 = GameObject.FindGameObjectWithTag("Enemy1");
        Prefab4 = GameObject.FindGameObjectWithTag("Enemy2");
    }
    //use instantiation to create a new block or enemy

    public abstract class Command
    {
        public abstract void Execute();
    }

    public void Undo()
    {
        if (LastKeyHit != KeyCode.None && LastKeyHit == KeyCode.Alpha1)
        {
            //remove gameobject
            Destroy(GameObject.FindGameObjectWithTag("BrownBlock"));
        }
        if (LastKeyHit != KeyCode.None && LastKeyHit == KeyCode.Alpha2)
        {
            //remove gameobject
            Destroy(GameObject.FindGameObjectWithTag("YellowBlock"));
        }
        if (LastKeyHit != KeyCode.None && LastKeyHit == KeyCode.Alpha2)
        {
            //remove gameobject
            Destroy(GameObject.FindGameObjectWithTag("Enemy1"));
        }
        if (LastKeyHit != KeyCode.None && LastKeyHit == KeyCode.Alpha2)
        {
            //remove gameobject
            Destroy(GameObject.FindGameObjectWithTag("Enemy2"));
        }
    }

    public class Spawn1 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 1
            Instantiate(Prefab1, new Vector3(-5, 3, 0), Quaternion.identity);
        }
    }

    public class Spawn2 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 2
            Instantiate(Prefab2, new Vector3(-2, 3, 0), Quaternion.identity);
        }
    }
    public class Spawn3 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 3
            Instantiate(Prefab3, new Vector3(0.5f, 0.5f, 0), Quaternion.identity);
        }
    }
    public class Spawn4 : Command
    {
        public override void Execute()
        {
            //instantiate prefab 4
            Instantiate(Prefab4, new Vector3(3, 0.5f, 0), Quaternion.identity);
        }
    }
    
    Command buttonA = new Spawn1();
    Command buttonB = new Spawn2();
    Command buttonC = new Spawn3();
    Command buttonD = new Spawn4();

    void Update()
    {
        getInput();
    }
    void getInput()
    { 
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            LastKeyHit = KeyCode.Alpha1;
            buttonA.Execute();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            LastKeyHit = KeyCode.Alpha2;
            buttonB.Execute();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            LastKeyHit = KeyCode.Alpha3;
            buttonC.Execute();
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            LastKeyHit = KeyCode.Alpha4;
            buttonD.Execute();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Undo();
        }
    }

}
