using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Cloud.Speech.V1;
using Grpc.Core;

namespace GoogleCloudSamples
{
    public class findlokale : MonoBehaviour
    {
        // The name of the local audio file to transcribe
        public static string DEMO_FILE = "audio.raw";
        public static void Main(string[] args)
        {
            var speech = SpeechClient.Create();
            var response = speech.Recognize(new RecognitionConfig()
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                SampleRateHertz = 16000,
                LanguageCode = "en",
            }, RecognitionAudio.FromFile(DEMO_FILE));
            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    Debug.Log("Final: " + alternative.Transcript);
                }
            }
        }
    }
}