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
    // 020 Resolution                               0001866BE580 ModelEnumType Resolution Resolution Resolution Int32
    // 024 ClipPlaneOffset                          000186666050 ModelPrimitiveType float float float Single
    // 028 reflectionCameras                        Dictionary`2<Camera, Camera> IL2CPP_TYPE_GENERICINST
    // 030 ReflectionTexture                        000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 038 OldReflectionTextureSize                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 008 _insideWater                             bool IL2CPP_TYPE_BOOLEAN
    // 040 Camera                                   0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 048 MyRenderer                               00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 050 IsEnableRender                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 009 _disableReflection                       bool IL2CPP_TYPE_BOOLEAN
    // 010 OpaquePassNames                          000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 TransparentPassNames                     000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ReflectionPlane : DataModel
    {
        public Resolution                               Resolution                              { get; set; }
        public float                                    ClipPlaneOffset                         { get; set; }
        public RenderTexture?                           ReflectionTexture                       { get; set; }
        public int                                      OldReflectionTextureSize                { get; set; }
        public Camera?                                  Camera                                  { get; set; }
        public Renderer?                                MyRenderer                              { get; set; }
        public bool                                     IsEnableRender                          { get; set; }
        public List<string>?                            OpaquePassNames                         { get; set; }
        public List<string>?                            TransparentPassNames                    { get; set; }

        public static ReflectionPlane? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionPlane() { Pointer= p0 };

            value.Resolution                                = (Resolution)GetInt32(new IntPtr(p + 0x020)); // 0245A699AE50 0x20 Resolution                  ( 0001866BE580 ModelEnumType Resolution Resolution Resolution Int32 )
            value.ClipPlaneOffset                           = GetSingle(new IntPtr(p + 0x024)); // 0245A699AE70 0x24 ClipPlaneOffset             ( 000186666050 ModelPrimitiveType float float float Single )
            value.ReflectionTexture                         = GetObject<RenderTexture>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A699AEB0 0x30 ReflectionTexture           ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.OldReflectionTextureSize                  = GetInt32(new IntPtr(p + 0x038)); // 0245A699AED0 0x38 OldReflectionTextureSize    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x040), ReversePrism.DataModels.Camera.FromPointer); // 0245A699AF10 0x40 Camera                      ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.MyRenderer                                = GetObject<Renderer>(new IntPtr(p + 0x048), ReversePrism.DataModels.Renderer.FromPointer); // 0245A699AF30 0x48 MyRenderer                  ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.IsEnableRender                            = GetBool(new IntPtr(p + 0x050)); // 0245A699AF50 0x50 IsEnableRender              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OpaquePassNames                           = GetStringList(new IntPtr(p + 0x010)); // 0245A699AF90 0x10 OpaquePassNames             ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.TransparentPassNames                      = GetStringList(new IntPtr(p + 0x018)); // 0245A699AFB0 0x18 TransparentPassNames        ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
