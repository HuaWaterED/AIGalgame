using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovelAI_WebUIInteractionData
{
    [Serializable]
    public class Join
    {
        //我看到WebUI返回的json吃了一大惊
        //他的一个数组数据，里边有string，有int，有float，里边有数组，甚至里边还有json
        //现在就是，要么硬写，要么用拆箱装箱操作。(划掉)
        //硬写就真的是虐待自己（划掉）
        //我选择拆装箱（划掉）
        //我可能要两个都要弄了
        public int fn_index;
        public string session_hash;
        public object[] data;
    }
}
