using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace UniOSC
{

    static class statics
    {
        public static bool DEBUGGING = true;
        public static string DEBUGGINGTEXT = "";
        public static bool VIBRATE = false;
        public static int OCTAVA = 5; // la octava seleccionada

        // public static string IP = "158.42.127.79";
        //public static int PORT = 9000;

        public static string IP
        {
            get { return m_IP; }
            set { m_IP = value; PlayerPrefs.SetString("IP", value); }
        }
        public static string m_IP;

        public static int PORT
        {
            get { return m_PORT; }
            set { m_PORT = value; PlayerPrefs.SetInt("PORT", value); }
        }
        public static int m_PORT;

        public static Dictionary<int, string> midiDictionary = new Dictionary<int, string>
        {
         {
            1, "Acoustic Grand Piano"}, {
            2, "Bright Acoustic Piano"}, {
            3, "Electric Grand Piano"}, {
            4, "Honky-tonk Piano"}, {
            5, "Electric Piano 1"}, {
            6, "Electric Piano 2"}, {
            7, "Harpsichord"}, {
            8, "Clavi"}, {
            9, "Celesta"}, {
            10, "Glockenspiel"}, {
            11, "Music Box"}, {
            12, "Vibraphone"}, {
            13, "Marimba"}, {
            14, "Xylophone"}, {
            15, "Tubular Bells"}, {
            16, "Dulcimer"}, {
            17, "Drawbar Organ"}, {
            18, "Percussive Organ"}, {
            19, "Rock Organ"}, {
            20, "Church Organ"}, {
            21, "Reed Organ"}, {
            22, "Accordion"}, {
            23, "Harmonica"}, {
            24, "Tango Accordion"}, {
            25, "Acoustic Guitar (nylon) "}, {
            26, "Acoustic Guitar (steel) "}, {
            27, "Electric Guitar (jazz) "}, {
            28, "Electric Guitar (clean) "}, {
            29, "Electric Guitar (muted) "}, {
            30, "Overdriven Guitar"}, {
            31, "Distortion Guitar"}, {
            32, "Guitar harmonics"}, {
            33, "Acoustic Bass"}, {
            34, "Electric Bass (finger) "}, {
            35, "Electric Bass (pick) "}, {
            36, "Fretless Bass"}, {
            37, "Slap Bass 1"}, {
            38, "Slap Bass 2"}, {
            39, "Synth Bass 1"}, {
            40, "Synth Bass 2"}, {
            41, "Violin"}, {
            42, "Viola"}, {
            43, "Cello"}, {
            44, "Contrabass"}, {
            45, "Tremolo Strings"}, {
            46, "Pizzicato Strings"}, {
            47, "Orchestral Harp"}, {
            48, "Timpani"}, {
            49, "String Ensemble 1"}, {
            50, "String Ensemble 2"}, {
            51, "SynthStrings 1"}, {
            52, "SynthStrings 2"}, {
            53, "Choir Aahs"}, {
            54, "Voice Oohs"}, {
            55, "Synth Voice"}, {
            56, "Orchestra Hit"}, {
            57, "Trumpet"}, {
            58, "Trombone"}, {
            59, "Tuba"}, {
            60, "Muted Trumpet"}, {
            61, "French Horn"}, {
            62, "Brass Section"}, {
            63, "SynthBrass 1"}, {
            64, "SynthBrass 2"}, {
            65, "Soprano Sax"}, {
            66, "Alto Sax"}, {
            67, "Tenor Sax"}, {
            68, "Baritone Sax"}, {
            69, "Oboe"}, {
            70, "English Horn"}, {
            71, "Bassoon"}, {
            72, "Clarinet"}, {
            73, "Piccolo"}, {
            74, "Flute"}, {
            75, "Recorder"}, {
            76, "Pan Flute"}, {
            77, "Blown Bottle"}, {
            78, "Shakuhachi"}, {
            79, "Whistle"}, {
            80, "Ocarina"}, {
            81, "Lead 1 (square)"}, {
            82, "Lead 2 (sawtooth)"}, {
            83, "Lead 3 (calliope)"}, {
            84, "Lead 4 (chiff)"}, {
            85, "Lead 5 (charang) "}, {
            86, "Lead 6 (voice)"}, {
            87, "Lead 7 (fifths)"}, {
            88, "Lead 8 (bass + lead)"}, {
            89, "Pad 1 (new age)"}, {
            90, "Pad 2 (warm)"}, {
            91, "Pad 3 (polysynth)"}, {
            92, "Pad 4 (choir)"}, {
            93, "Pad 5 (bowed)"}, {
            94, "Pad 6 (metallic)"}, {
            95, "Pad 7 (halo)"}, {
            96, "Pad 8 (sweep)"}, {
            97, "FX 1 (rain)"}, {
            98, "FX 2 (soundtrack)"}, {
            99, "FX 3 (crystal) "}, {
            100, "FX 4 (atmosphere)"}, {
            101, "FX 5 (brightness)"}, {
            102, "FX 6 (goblins)"}, {
            103, "FX 7 (echoes)"}, {
            104, "FX 8 (sci-fi)"}, {
            105, "Sitar"}, {
            106, "Banjo"}, {
            107, "Shamisen"}, {
            108, "Koto"}, {
            109, "Kalimba"}, {
            110, "Bag pipe"}, {
            111, "Fiddle"}, {
            112, "Shanai"}, {
            113, "Tinkle Bell"}, {
            114, "Agogo"}, {
            115, "Steel Drums"}, {
            116, "Woodblock"}, {
            117, "Taiko Drum"}, {
            118, "Melodic Tom"}, {
            119, "Synth Drum"}, {
            120, "Reverse Cymbal"}, {
            121, "Guitar Fret Noise"}, {
            122, "Breath Noise"}, {
            123, "Seashore"}, {
            124, "Bird Tweet"}, {
            125, "Telephone Ring"}, {
            126, "Helicopter"}, {
            127, "Applause"}, {
            128, "Gunshot"}
        };


        public static Dictionary<int, string> screenDictionary = new Dictionary<int, string>
        {
             {
                1, "1920 1080"}, {
                2, "1080 720"}, {
                3, "854 480"}, {
                4, "640 360"}, {
                5, "425 240"}, {
                6, "256 144"}

            };


        public static Dictionary<int, string> modDictionary = new Dictionary<int, string>
        {
             {
                1, "Audio Wave"}, {
                2, "LED Spectrum"}, {
                3, "Lotto Wave"}, {
                4, "Lotto Freq"}, {
                5, "Matrix Tunnel"}, {
                6, "Complex 1"}, {
                7, "Complex 2"}, {
                8, "Complex 3"}, {
                9, "Complex 4"}, {
                10, "Complex 5"}, {
                11, "Complex 6"}, {
                12, "Complex 7"}, {
                13, "Complex 8"}, {
                14, "Complex 9"}, {
                15, "Complex 10"}, {
                16, "Complex 11"}, {
                17, "Complex 12"}, {
                18, "Complex 13"}, {
                19, "Complex 14"}, {
                20, "Complex 15"}, {
                21, "Complex 16"}, {
                22, "Complex 17"}, {
                23, "Complex 18"}, {
                24, "Complex 19"}, {
                25, "Complex 20"}, {
                26, "Complex 21"}, {
                27, "Complex 22"}, {
                28, "Sonogram 1"}, {
                29, "Sonogram 2"}, {
                30, "Sonogram 3"}, {
                31, "Sonogram 4"}, {
                32, "Sonogram 3D"}, {
                33, "Twisted Toro"}, {
                34, "Spheres"}
            };

        }
}

