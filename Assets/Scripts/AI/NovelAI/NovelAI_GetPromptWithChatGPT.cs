using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovelAI_GetPromptWithChatGPT : MonoBehaviourSingleton<NovelAI_GetPromptWithChatGPT>
{
    public const string Prompt_HEAD = "<lora:Mahiro-000020:1> ,1girl,loli,Mahiro,ahoge,";
    public const string Prompt_Tail = "<lora:animixAnimeScreenshotLikeStyleMixLora_v10:1>";
    public string Prompt_Receive = "(looking at viewer),(straight-on),upper body,simple background,light smile,blush" + ",";

    public string Prompt => $"{Prompt_HEAD}{Prompt_Receive}{Prompt_Tail}";
    public string NegativePrompt => "bad_prompt_version2, easynegative, 修手";

}
