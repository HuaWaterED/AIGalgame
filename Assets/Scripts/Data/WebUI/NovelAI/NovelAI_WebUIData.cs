
using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class NovelAI_WebUIData
{
    public string msg;
    public object output;
    public NovelAI_WebUIData ValueChangedCallBack()
    {
        if (output == null) return this;
        string outputString = JsonConvert.SerializeObject(output);
        outputData = JsonConvert.DeserializeObject<Output>(outputString).ValueChangedCallBack();
        return this;
    }
    [JsonIgnore] public Output outputData;
    public bool success;
}

[Serializable]
public class Output
{
    public float average_duration;
    public object[] data;
    public float duration;
    public bool is_generating;
    public Output ValueChangedCallBack()
    {
        if (data == null) return this;
        dataData = JsonConvert.DeserializeObject<Data[]>(data[0].ToString());
        return this;
    }
    [JsonIgnore]
    public Data[] dataData;
}
[Serializable]
public class Data
{
    public bool is_file;
    public string name;
}