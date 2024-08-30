using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Functions : MonoBehaviour
{
    public GameObject LivingRoom;
    public GameObject Cantina;
    public GameObject Mezzanine;
    public GameObject Cube;

    private GameObject[] Rooms;
    
    void Start()
    {
        Rooms = new GameObject[4];
        Rooms[0] = LivingRoom;
        Rooms[1] = Cantina;
        Rooms[2] = Mezzanine;
        Rooms[3] = Cube;
    }

    public void ChangeRoom(int RoomNumber)
    {
        if (RoomNumber < 0 || RoomNumber > Rooms.Length)
        {
            Debug.Log("Wrong room number");
            return;
        }
        for (int i = 0; i < Rooms.Length; i++ )
            Rooms[i].SetActive(false);

        Rooms[RoomNumber].SetActive(true);
        
    }

    public void ToggleText()
    {
        GameObject button = EventSystem.current.currentSelectedGameObject;

        if (button == null)
        {
            Debug.LogWarning("No Button selected in ToggleText() - Functions.cs");
            return;
        }

        foreach(Transform child in button.transform)
        {
            bool isActive = child.gameObject.activeSelf;
            child.gameObject.SetActive(!isActive);
        }
    }
}
