using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 beginContextRendering                    ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 endContextRendering                      ProfilingSampler IL2CPP_TYPE_CLASS
    // 010 BeginCameraRendering                     ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 018 EndCameraRendering                       ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 000 k_Name                                   string IL2CPP_TYPE_STRING
    // 020 InitializeCameraData                     ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 028 InitializeStackedCameraData              ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 030 InitializeAdditionalCameraData           ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 038 InitializeRenderingData                  ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 040 InitializeShadowData                     ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 048 InitializeLightData                      ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 050 GetPerObjectLightFlags                   ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 058 GetMainLightIndex                        ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 060 SetupPerFrameShaderConstants             ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 068 SetupPerCameraShaderConstants            ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    public partial class Pipeline : DataModel
    {
        public ProfilingSampler?                        BeginCameraRendering                    { get; set; }
        public ProfilingSampler?                        EndCameraRendering                      { get; set; }
        public ProfilingSampler?                        InitializeCameraData                    { get; set; }
        public ProfilingSampler?                        InitializeStackedCameraData             { get; set; }
        public ProfilingSampler?                        InitializeAdditionalCameraData          { get; set; }
        public ProfilingSampler?                        InitializeRenderingData                 { get; set; }
        public ProfilingSampler?                        InitializeShadowData                    { get; set; }
        public ProfilingSampler?                        InitializeLightData                     { get; set; }
        public ProfilingSampler?                        GetPerObjectLightFlags                  { get; set; }
        public ProfilingSampler?                        GetMainLightIndex                       { get; set; }
        public ProfilingSampler?                        SetupPerFrameShaderConstants            { get; set; }
        public ProfilingSampler?                        SetupPerCameraShaderConstants           { get; set; }

        public static Pipeline? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Pipeline() { Pointer= p0 };

            value.BeginCameraRendering                      = GetObject<ProfilingSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x10 BeginCameraRendering        ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.EndCameraRendering                        = GetObject<ProfilingSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x18 EndCameraRendering          ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.InitializeCameraData                      = GetObject<ProfilingSampler>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x20 InitializeCameraData        ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.InitializeStackedCameraData               = GetObject<ProfilingSampler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x28 InitializeStackedCameraData ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.InitializeAdditionalCameraData            = GetObject<ProfilingSampler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x30 InitializeAdditionalCameraData ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.InitializeRenderingData                   = GetObject<ProfilingSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x38 InitializeRenderingData     ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.InitializeShadowData                      = GetObject<ProfilingSampler>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x40 InitializeShadowData        ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.InitializeLightData                       = GetObject<ProfilingSampler>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x48 InitializeLightData         ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.GetPerObjectLightFlags                    = GetObject<ProfilingSampler>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x50 GetPerObjectLightFlags      ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.GetMainLightIndex                         = GetObject<ProfilingSampler>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x58 GetMainLightIndex           ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.SetupPerFrameShaderConstants              = GetObject<ProfilingSampler>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x60 SetupPerFrameShaderConstants ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.SetupPerCameraShaderConstants             = GetObject<ProfilingSampler>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x68 SetupPerCameraShaderConstants ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )

            return value;
        }
    }
}
