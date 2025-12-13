using System;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Minimal stubs to keep optional systems compiling when those features are stripped.
// No runtime functionality is provided.

namespace UnityEngine.Rendering.Universal
{
    public class PlanarReflections : MonoBehaviour
    {
        public class PlanarReflectionSettings { }

        public static event Action<ScriptableRenderContext, Camera> BeginPlanarReflections
        {
            add { }
            remove { }
        }
    }
}

namespace WaterSystem
{
    public static class GerstnerWavesJobs
    {
        public static void Init() { }
        public static void Cleanup() { }
        public static void UpdateHeights() { }

        public static void UpdateSamplePoints(ref NativeArray<float3> samplePoints, int guid) { }

        public static void GetData(int guid, ref float3[] outPos, ref float3[] outNorm)
        {
            if (outPos == null) return;
            for (var i = 0; i < outPos.Length; i++)
            {
                outPos[i] = float3.zero;
                if (outNorm != null && i < outNorm.Length)
                {
                    outNorm[i] = new float3(0, 1, 0);
                }
            }
        }
    }
}
