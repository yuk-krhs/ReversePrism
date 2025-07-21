using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProfileTag                               string IL2CPP_TYPE_STRING
    // 000 ProfileSampler                           ProfileSampler IL2CPP_TYPE_CLASS
    // 020 ClipPlaneOffset                          ModelPrimitiveType float float float Single
    // 028 ReflectionCamera                         ModelClassType Camera Camera Camera Pointer
    // 030 ReflectionTexture                        ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 038 OldReflectionTextureSize                 ModelPrimitiveType int int int Int32
    // 008 _insideWater                             bool IL2CPP_TYPE_BOOLEAN
    // 040 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 048 MyRenderer                               ModelClassType Renderer Renderer Renderer Pointer
    // 050 IsEnableRender                           ModelPrimitiveType bool bool bool Bool
    // 009 _enableReflection                        bool IL2CPP_TYPE_BOOLEAN
    // 00C <ForceResolution>k__BackingField         Resolution IL2CPP_TYPE_VALUETYPE
    // 010 KeepForceResolution                      ModelEnumType Resolution Resolution Resolution Int32
    // 018 ReflectionPassNames                      ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ReflectionPlane : DataModel
    {
        public float                                    ClipPlaneOffset                         { get; set; }
        public Camera?                                  ReflectionCamera                        { get; set; }
        public RenderTexture?                           ReflectionTexture                       { get; set; }
        public int                                      OldReflectionTextureSize                { get; set; }
        public Camera?                                  Camera                                  { get; set; }
        public Renderer?                                MyRenderer                              { get; set; }
        public bool                                     IsEnableRender                          { get; set; }
        public Resolution                               KeepForceResolution                     { get; set; }
        public List<string>?                            ReflectionPassNames                     { get; set; }

        public static ReflectionPlane? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionPlane() { Pointer= p0 };

            value.ClipPlaneOffset                           = GetSingle(new IntPtr(p + 0x020)); // 0x20 ClipPlaneOffset             ( ModelPrimitiveType float float float Single )
            value.ReflectionCamera                          = GetObject<Camera>(new IntPtr(p + 0x028), ReversePrism.DataModels.Camera.FromPointer); // 0x28 ReflectionCamera            ( ModelClassType Camera Camera Camera Pointer )
            value.ReflectionTexture                         = GetObject<RenderTexture>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x30 ReflectionTexture           ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.OldReflectionTextureSize                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 OldReflectionTextureSize    ( ModelPrimitiveType int int int Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x040), ReversePrism.DataModels.Camera.FromPointer); // 0x40 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.MyRenderer                                = GetObject<Renderer>(new IntPtr(p + 0x048), ReversePrism.DataModels.Renderer.FromPointer); // 0x48 MyRenderer                  ( ModelClassType Renderer Renderer Renderer Pointer )
            value.IsEnableRender                            = GetBool(new IntPtr(p + 0x050)); // 0x50 IsEnableRender              ( ModelPrimitiveType bool bool bool Bool )
            value.KeepForceResolution                       = (Resolution)GetInt32(new IntPtr(p + 0x010)); // 0x10 KeepForceResolution         ( ModelEnumType Resolution Resolution Resolution Int32 )
            value.ReflectionPassNames                       = GetStringList(new IntPtr(p + 0x018)); // 0x18 ReflectionPassNames         ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
