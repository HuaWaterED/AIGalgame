using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class WebUIData
{
    public string msg;
    public object output;
    public bool success;
}
[Serializable]
public class Output
{
    public ImageFilePath[] imageFilePath;
    public string info;
}
[Serializable]
public class ImageFilePath
{
    public bool is_file;
    public string name;
}