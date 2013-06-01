using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class test : MonoBehaviour
{
    List<string> listTemp = new List<string>() { "one", "two","three"};
    Dictionary<string, int> dicTemp = new Dictionary<string, int>();

    string jsonString_listTemp;
    string jsonString_dicTemp;

	void Start ()
    {
        dicTemp.Add("one", 1);
        dicTemp.Add("two", 2);
        dicTemp.Add("three", 3);

        //Serialize
        jsonString_listTemp = Json.Serialize(listTemp);
        Debug.Log("json Serialize1 : " + jsonString_listTemp);

        jsonString_dicTemp = Json.Serialize(dicTemp);
        Debug.Log("json Serialize2 : " + jsonString_dicTemp);


        //Deserialize to List
        List<object> tt = Json.Deserialize(jsonString_listTemp) as List<object>;
        Debug.Log(tt[0]);
        Debug.Log(tt[1]);
        Debug.Log(tt[2]);

        //Deserialize to Dictionary
        Dictionary<string, object> ttt = Json.Deserialize(jsonString_dicTemp) as Dictionary<string, object>;
        Debug.Log(ttt["one"]);
        Debug.Log(ttt["two"]);
        Debug.Log(ttt["three"]);
	}
}