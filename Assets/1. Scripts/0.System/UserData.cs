using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UserData
{
    public int userID;
    public string userName;

    public UserData(int userID)
    {
        this.userID = userID;
       
    }
}
