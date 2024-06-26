using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadManager : MonoBehaviour
{
    public UserData userData;
    GameData gameData;

    void Start()
    {
        userData = new UserData(1);
    }

    public void Save()
    {
        // !! 유저데이터 , 게임 데이터 제작 후 바이너리 저장 호출

        SaveBinaryUserData();
        SaveBinaryGameData();
    }

    public void SaveBinaryUserData()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        string saveFileName = "UserData.dat";
        string savePath = Application.persistentDataPath + "/" + saveFileName;

        FileStream fileStream = new FileStream(savePath, FileMode.Create);
        userData = new UserData(1 /*!! 유저 아이디 불러오기 */ );

        binaryFormatter.Serialize(fileStream, userData);
        fileStream.Close();

    }

    public void SaveBinaryGameData()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        string saveFileName = "GameData.dat";
        string savePath = Application.persistentDataPath + "/" + saveFileName;

        FileStream fileStream = new FileStream(savePath, FileMode.Create);
        gameData = new GameData( /*!! 유저 아이디 불러오기 */ );

        binaryFormatter.Serialize(fileStream, gameData);
        fileStream.Close();

    }

    public UserData LoadBianryUserData()
    {
        string loadFileName = "UserData.dat";
        string loadPath = Application.persistentDataPath + "/" + loadFileName;

        if (!File.Exists(loadPath))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(loadPath, FileMode.Open);

            userData = binaryFormatter.Deserialize(fileStream) as UserData;
            fileStream.Close();

            return userData;
        }

        else
        {
            return null;
        }
    }

    public GameData LoadBianryGameData()
    {
        string loadFileName = "GameData.dat";
        string loadPath = Application.persistentDataPath + "/" + loadFileName;

        if (!File.Exists(loadPath))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(loadPath, FileMode.Open);

            gameData = binaryFormatter.Deserialize(fileStream) as GameData;
            fileStream.Close();

            return gameData;
        }

        else
        {
            return null;
        }
    }
}