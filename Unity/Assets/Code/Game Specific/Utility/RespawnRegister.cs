﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class RespawnRegister
{
    private List<RespawnMe> ActiveRespawners = new List<RespawnMe>();

    public void Register(RespawnMe toAdd)
    {
        ActiveRespawners.Add(toAdd);
    }

    public void UnRegister(RespawnMe toRemove)
    {
        if (ActiveRespawners.Contains(toRemove))
            ActiveRespawners.Remove(toRemove);
    }

    public void RespawnAll()
    {
        ActiveRespawners = ActiveRespawners.OrderByDescending(t => t.Priority).ToList();
        foreach (RespawnMe rs in ActiveRespawners)
        {
            rs.Respawn();
        }
    }

    //public void RespawnPlayer()
    //{

    //}

    //public void RespawnTag()
    //{

    //}

}
