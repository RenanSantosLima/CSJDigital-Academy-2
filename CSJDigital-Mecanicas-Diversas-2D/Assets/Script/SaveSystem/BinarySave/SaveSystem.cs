using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{


    public static void SavePlayer(Player player)
    {
        BinaryFormatter binary = new BinaryFormatter();


        //Caminho do arquivo
        string path = Application.persistentDataPath + "/player.csj";
        //Criando o arquivo
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        binary.Serialize(stream, data);
        stream.Close();

        Debug.Log("Jogo salvo!");
    }


    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.csj";

        if(File.Exists(path))
        {
            //Carrega os dados
            BinaryFormatter binary = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = binary.Deserialize(stream) as PlayerData;
            Debug.Log("Jogo carregado com sucesso!");

            return data;
        }
        else
        {
            //Debuga erro ou não faz nada
            Debug.Log("Arquivo não existe!" + path);
            return null;
        }
    }
}
