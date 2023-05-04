using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityWebSocket;
using Prompt = NovelAI_GetPromptWithChatGPT;
public class NovelAI_GetTexture : MonoBehaviourSingleton<NovelAI_GetTexture>
{
    WebSocket socket = new("ws://127.0.0.1:7860/queue/join");
    void Start()
    {
        socket.OnMessage += Socket_OnMessage;
        socket.ConnectAsync();
    }

    private void Socket_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log(e.Data);
        NovelAI_WebUIData webUIData = JsonConvert.DeserializeObject<NovelAI_WebUIData>(e.Data).ValueChangedCallBack();
        switch (webUIData.msg)
        {
            case "send_hash":
                SendHash();
                break;
            case "send_data":
                SendData();
                break;
            case "process_completed":
                StartCoroutine(GetTextureWithWebUI($"http://127.0.0.1:7860/file={webUIData.outputData.dataData[0].name}"));
                break;
        }
    }
    private void SendHash()
    {
        socket.SendAsync("{\"fn_index\":317,\"session_hash\":\"\"}");
    }
    private void SendData()
    {
        NovelAIDataTools.Join join = new();
        join.fn_index = 317;
        join.session_hash = "";
        join.data = new();
        join.data.prompt = Prompt.Instance.Prompt;
        join.data.negativePrompt = Prompt.Instance.NegativePrompt;
        string senderData = JsonConvert.SerializeObject(NovelAIDataTools.Convert(join));
        Debug.Log(senderData);
        socket.SendAsync(senderData);
    }
    IEnumerator GetTextureWithWebUI(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();
        if (!string.IsNullOrEmpty(www.error)) Debug.Log(www.error);
        else
        {
            Texture2D myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            Sprite createSprite = Sprite.Create(myTexture, new Rect(0, 0, myTexture.width, myTexture.height), new Vector2(0, 0));
            AssetManager.Instance.background.sprite = createSprite;
        }
    }
}
