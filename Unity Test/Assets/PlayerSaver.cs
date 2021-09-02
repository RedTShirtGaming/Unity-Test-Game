using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaver : MonoBehaviour
{
    public int level = 3;
    public int health = 100;
    public Vector3 position;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;

        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = new Vector3(position.x, position.y, position.z);
    }
}
