using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWebSocket;
public class WSTest : MonoBehaviour
{
    // Start is called before the first frame update
    WebSocket socket = new("ws://127.0.0.1:7860/queue/join");
    void Start()
    {
        socket.OnMessage += Socket_OnMessage;
        socket.ConnectAsync();
        //socket.SendAsync(sendText);
    }

    private void Socket_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log(e.Data);
        WebUIData webUIData = JsonConvert.DeserializeObject<WebUIData>(e.Data);
        switch (webUIData.msg)
        {
            case "send_hash":
                socket.SendAsync("{\"fn_index\":317,\"session_hash\":\"\"}");
                break;
            case "send_data":
                NovelAIDataTools.Join join = new();
                join.fn_index = 317;
                join.session_hash = "";
                join.data = new();
                join.data.prompt = " <lora:Mahiro-000020:1> ,1girl,loli,Mahiro,ahoge,library, <lora:animixAnimeScreenshotLikeStyleMixLora_v10:1>";
                join.data.negativePrompt = " bad_prompt_version2, easynegative, 修手";
                join.data.batchSize = 2;
                string senderData = JsonConvert.SerializeObject(NovelAIDataTools.Convert(join));
                Debug.Log(senderData);
                socket.SendAsync(senderData);
                break;
            case "process_completed":
                Debug.Log(webUIData.output.ToString());
                break;
        }
    }
}
