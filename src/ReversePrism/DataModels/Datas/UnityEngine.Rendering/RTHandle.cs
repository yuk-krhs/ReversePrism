using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Owner                                  000186606930 ModelClassType RTHandleSystem RTHandleSystem RTHandleSystem Pointer
    // 018 M_RT                                     000186656230 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 020 M_ExternalTexture                        00018664D240 ModelClassType Texture Texture Texture Pointer
    // 028 M_NameID                                 000186655700 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 050 M_EnableMSAA                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 051 M_EnableRandomWrite                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 052 M_EnableHWDynamicScale                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 058 M_Name                                   000186671BA0 ModelPrimitiveType string string string String
    // 060 M_UseCustomHandleScales                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 064 M_CustomHandleProperties                 00018664C420 ModelEnumType RTHandleProperties RTHandleProperties RTHandleProperties Int32
    // 094 ScaleFactor                              0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0A0 ScaleFunc                                0001866C10B0 ModelClassType ScaleFunc ScaleFunc ScaleFunc Pointer
    // 0A8 UseScaling                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AC ReferenceSize                            0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    public partial class RTHandle : DataModel
    {
        public RTHandleSystem?                          M_Owner                                 { get; set; }
        public RenderTexture?                           M_RT                                    { get; set; }
        public Texture?                                 M_ExternalTexture                       { get; set; }
        public RenderTargetIdentifier                   M_NameID                                { get; set; }
        public bool                                     M_EnableMSAA                            { get; set; }
        public bool                                     M_EnableRandomWrite                     { get; set; }
        public bool                                     M_EnableHWDynamicScale                  { get; set; }
        public string                                   M_Name                                  { get; set; }
        public bool                                     M_UseCustomHandleScales                 { get; set; }
        public RTHandleProperties                       M_CustomHandleProperties                { get; set; }
        public Vector2                                  ScaleFactor                             { get; set; }
        public ScaleFunc?                               ScaleFunc                               { get; set; }
        public bool                                     UseScaling                              { get; set; }
        public Vector2Int                               ReferenceSize                           { get; set; }

        public static RTHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RTHandle() { Pointer= p0 };

            value.M_Owner                                   = GetObject<RTHandleSystem>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandleSystem.FromPointer); // 0245A3FBD3C8 0x10 M_Owner                     ( 000186606930 ModelClassType RTHandleSystem RTHandleSystem RTHandleSystem Pointer )
            value.M_RT                                      = GetObject<RenderTexture>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A3FBD3E8 0x18 M_RT                        ( 000186656230 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_ExternalTexture                         = GetObject<Texture>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture.FromPointer); // 0245A3FBD408 0x20 M_ExternalTexture           ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.M_NameID                                  = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x028)); // 0245A3FBD428 0x28 M_NameID                    ( 000186655700 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.M_EnableMSAA                              = GetBool(new IntPtr(p + 0x050)); // 0245A3FBD448 0x50 M_EnableMSAA                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_EnableRandomWrite                       = GetBool(new IntPtr(p + 0x051)); // 0245A3FBD468 0x51 M_EnableRandomWrite         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_EnableHWDynamicScale                    = GetBool(new IntPtr(p + 0x052)); // 0245A3FBD488 0x52 M_EnableHWDynamicScale      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_Name                                    = GetString(new IntPtr(p + 0x058)); // 0245A3FBD4A8 0x58 M_Name                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_UseCustomHandleScales                   = GetBool(new IntPtr(p + 0x060)); // 0245A3FBD4C8 0x60 M_UseCustomHandleScales     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_CustomHandleProperties                  = (RTHandleProperties)GetInt32(new IntPtr(p + 0x064)); // 0245A3FBD4E8 0x64 M_CustomHandleProperties    ( 00018664C420 ModelEnumType RTHandleProperties RTHandleProperties RTHandleProperties Int32 )
            value.ScaleFactor                               = (Vector2)GetInt32(new IntPtr(p + 0x094)); // 0245A3FBD508 0x94 ScaleFactor                 ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ScaleFunc                                 = GetObject<ScaleFunc>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ScaleFunc.FromPointer); // 0245A3FBD528 0xA0 ScaleFunc                   ( 0001866C10B0 ModelClassType ScaleFunc ScaleFunc ScaleFunc Pointer )
            value.UseScaling                                = GetBool(new IntPtr(p + 0x0A8)); // 0245A3FBD548 0xA8 UseScaling                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReferenceSize                             = (Vector2Int)GetInt32(new IntPtr(p + 0x0AC)); // 0245A3FBD568 0xAC ReferenceSize               ( 0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )

            return value;
        }
    }
}
