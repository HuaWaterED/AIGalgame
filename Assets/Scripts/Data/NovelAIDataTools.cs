using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NovelAIDataTools
{
    public static NovelAIWebUIInteractionData.Join Convert(Join join)
    {
        NovelAIWebUIInteractionData.Join interactionDataJoin = new()
        {
            fn_index = join.fn_index,
            session_hash = join.session_hash
        };
        List<object> join_Data = new();
        for (int i = 0; i < join.data.dataLength; i++)
        {
            join_Data.Add(join.data[i]);
        }
        interactionDataJoin.data = join_Data.ToArray();
        return interactionDataJoin;
    }
    [Serializable]
    public class Join
    {
        public int fn_index;
        public string session_hash;
        public Data data;
    }
    [Serializable]
    public class Data
    {
        public string taskID = "";
        public string prompt = "";
        public string negativePrompt = "";
        public string[] styles = new string[0];
        public int samplingSetps = 20;
        public string samplingMethod = "Euler a";
        public bool restoreFaces = false;
        public bool tiling = false;
        public int batchCount = 1;
        public int batchSize = 1;
        public float cfgScale = 7;
        public int seed = -1;
        public int variationSeed = -1;
        public int variationStrength = 0;
        public int resizeSeedFromHeight = 0;
        public int resizeSeedFromWidth = 0;
        public bool extra = false;
        public int height = 512;
        public int width = 512;
        public bool hiresFix = false;
        public float denoisingStrength = .7f;
        public float upscaleBy = 2;
        public string upscaler = "Latent";
        public int hiresSteps = 0;
        public int resizeWidthTo = 0;//
        public int resizeHeightTo = 0;//
        public object i26 = new int[0];
        public object i27 = "None";
        public object i28 = false;
        public object i29 = "MultiDiffusion";
        public object i30 = false;
        public object i31 = 10;
        public object i32 = 1;
        public object i33 = 1;
        public object i34 = 64;
        public object i35 = false;
        public object i36 = true;
        public object i37 = 1024;
        public object i38 = 1024;
        public object i39 = 96;
        public object i40 = 96;
        public object i41 = 48;
        public object i42 = 1;
        public object i43 = "None";
        public object i44 = 2;
        public object i45 = false;
        public object i46 = false;
        public object i47 = false;
        public object i48 = false;
        public object i49 = false;
        public object i50 = 0.4;
        public object i51 = 0.4;
        public object i52 = 0.2;
        public object i53 = 0.2;
        public object i54 = "";
        public object i55 = "";
        public object i56 = "Background";
        public object i57 = 0.2;
        public object i58 = -1;
        public object i59 = false;
        public object i60 = 0.4;
        public object i61 = 0.4;
        public object i62 = 0.2;
        public object i63 = 0.2;
        public object i64 = "";
        public object i65 = "";
        public object i66 = "Background";
        public object i67 = 0.2;
        public object i68 = -1;
        public object i69 = false;
        public object i70 = 0.4;
        public object i71 = 0.4;
        public object i72 = 0.2;
        public object i73 = 0.2;
        public object i74 = "";
        public object i75 = "";
        public object i76 = "Background";
        public object i77 = 0.2;
        public object i78 = -1;
        public object i79 = false;
        public object i80 = 0.4;
        public object i81 = 0.4;
        public object i82 = 0.2;
        public object i83 = 0.2;
        public object i84 = "";
        public object i85 = "";
        public object i86 = "Background";
        public object i87 = 0.2;
        public object i88 = -1;
        public object i89 = false;
        public object i90 = 0.4;
        public object i91 = 0.4;
        public object i92 = 0.2;
        public object i93 = 0.2;
        public object i94 = "";
        public object i95 = "";
        public object i96 = "Background";
        public object i97 = 0.2;
        public object i98 = -1;
        public object i99 = false;
        public object i100 = 0.4;
        public object i101 = 0.4;
        public object i102 = 0.2;
        public object i103 = 0.2;
        public object i104 = "";
        public object i105 = "";
        public object i106 = "Background";
        public object i107 = 0.2;
        public object i108 = -1;
        public object i109 = false;
        public object i110 = 0.4;
        public object i111 = 0.4;
        public object i112 = 0.2;
        public object i113 = 0.2;
        public object i114 = "";
        public object i115 = "";
        public object i116 = "Background";
        public object i117 = 0.2;
        public object i118 = -1;
        public object i119 = false;
        public object i120 = 0.4;
        public object i121 = 0.4;
        public object i122 = 0.2;
        public object i123 = 0.2;
        public object i124 = "";
        public object i125 = "";
        public object i126 = "Background";
        public object i127 = 0.2;
        public object i128 = -1;
        public object i129 = false;
        public object i130 = false;
        public object i131 = true;
        public object i132 = true;
        public object i133 = false;
        public object i134 = 960;
        public object i135 = 64;
        public object i136 = false;
        public object i137 = false;
        public object i138 = "LoRA";
        public object i139 = "None";
        public object i140 = 1;
        public object i141 = 1;
        public object i142 = "LoRA";
        public object i143 = "None";
        public object i144 = 1;
        public object i145 = 1;
        public object i146 = "LoRA";
        public object i147 = "None";
        public object i148 = 1;
        public object i149 = 1;
        public object i150 = "LoRA";
        public object i151 = "None";
        public object i152 = 1;
        public object i153 = 1;
        public object i154 = "LoRA";
        public object i155 = "None";
        public object i156 = 1;
        public object i157 = 1;
        public object i158 = null;
        public object i159 = "Refresh models";
        public object i160 = null;
        public object i161 = 0.9;
        public object i162 = 5;
        public object i163 = "0.0001";
        public object i164 = false;
        public object i165 = "None";
        public object i166 = "";
        public object i167 = 0.1;
        public object i168 = false;
        public object i169 = false;
        public object i170 = false;
        public object i171 = "positive";
        public object i172 = "comma";
        public object i173 = 0;
        public object i174 = false;
        public object i175 = false;
        public object i176 = "";
        public object i177 = "Seed";
        public object i178 = "";
        public object i179 = "Nothing";
        public object i180 = "";
        public object i181 = "Nothing";
        public object i182 = "";
        public object i183 = true;
        public object i184 = false;
        public object i185 = false;
        public object i186 = false;
        public object i187 = 0;
        public object i188 = null;
        public object i189 = false;
        public object i190 = 50;
        public ImageFile[] imageFiles = new ImageFile[0];
        public object i192 = "";
        public object i193 = "";
        public object i194 = "";

        public object this[int index] =>
        index switch
        {
            0 => taskID,
            1 => prompt,
            2 => negativePrompt,
            3 => styles,
            4 => samplingSetps,
            5 => samplingMethod,
            6 => restoreFaces,
            7 => tiling,
            8 => batchCount,
            9 => batchSize,
            10 => cfgScale,
            11 => seed,
            12 => variationSeed,
            13 => variationStrength,
            14 => resizeSeedFromHeight,
            15 => resizeSeedFromWidth,
            16 => extra,
            17 => height,
            18 => width,
            19 => hiresFix,
            20 => denoisingStrength,
            21 => upscaleBy,
            22 => upscaler,
            23 => hiresSteps,
            24 => resizeWidthTo,
            25 => resizeHeightTo,
            26 => i26,
            27 => i27,
            28 => i28,
            29 => i29,
            30 => i30,
            31 => i31,
            32 => i32,
            33 => i33,
            34 => i34,
            35 => i35,
            36 => i36,
            37 => i37,
            38 => i38,
            39 => i39,
            40 => i40,
            41 => i41,
            42 => i42,
            43 => i43,
            44 => i44,
            45 => i45,
            46 => i46,
            47 => i47,
            48 => i48,
            49 => i49,
            50 => i50,
            51 => i51,
            52 => i52,
            53 => i53,
            54 => i54,
            55 => i55,
            56 => i56,
            57 => i57,
            58 => i58,
            59 => i59,
            60 => i60,
            61 => i61,
            62 => i62,
            63 => i63,
            64 => i64,
            65 => i65,
            66 => i66,
            67 => i67,
            68 => i68,
            69 => i69,
            70 => i70,
            71 => i71,
            72 => i72,
            73 => i73,
            74 => i74,
            75 => i75,
            76 => i76,
            77 => i77,
            78 => i78,
            79 => i79,
            80 => i80,
            81 => i81,
            82 => i82,
            83 => i83,
            84 => i84,
            85 => i85,
            86 => i86,
            87 => i87,
            88 => i88,
            89 => i89,
            90 => i90,
            91 => i91,
            92 => i92,
            93 => i93,
            94 => i94,
            95 => i95,
            96 => i96,
            97 => i97,
            98 => i98,
            99 => i99,
            100 => i100,
            101 => i101,
            102 => i102,
            103 => i103,
            104 => i104,
            105 => i105,
            106 => i106,
            107 => i107,
            108 => i108,
            109 => i109,
            110 => i110,
            111 => i111,
            112 => i112,
            113 => i113,
            114 => i114,
            115 => i115,
            116 => i116,
            117 => i117,
            118 => i118,
            119 => i119,
            120 => i120,
            121 => i121,
            122 => i122,
            123 => i123,
            124 => i124,
            125 => i125,
            126 => i126,
            127 => i127,
            128 => i128,
            129 => i129,
            130 => i130,
            131 => i131,
            132 => i132,
            133 => i133,
            134 => i134,
            135 => i135,
            136 => i136,
            137 => i137,
            138 => i138,
            139 => i139,
            140 => i140,
            141 => i141,
            142 => i142,
            143 => i143,
            144 => i144,
            145 => i145,
            146 => i146,
            147 => i147,
            148 => i148,
            149 => i149,
            150 => i150,
            151 => i151,
            152 => i152,
            153 => i153,
            154 => i154,
            155 => i155,
            156 => i156,
            157 => i157,
            158 => i158,
            159 => i159,
            160 => i160,
            161 => i161,
            162 => i162,
            163 => i163,
            164 => i164,
            165 => i165,
            166 => i166,
            167 => i167,
            168 => i168,
            169 => i169,
            170 => i170,
            171 => i171,
            172 => i172,
            173 => i173,
            174 => i174,
            175 => i175,
            176 => i176,
            177 => i177,
            178 => i178,
            179 => i179,
            180 => i180,
            181 => i181,
            182 => i182,
            183 => i183,
            184 => i184,
            185 => i185,
            186 => i186,
            187 => i187,
            188 => i188,
            189 => i189,
            190 => i190,
            191 => imageFiles,
            192 => i192,
            193 => i193,
            194 => i194,
            _ => throw new Exception("OutOfIndex!")
        };
        public int dataLength => 195;
    }
    [Serializable]
    public class ImageFile
    {
        public string data;
        public bool is_file;
        public string name;
    }
}
