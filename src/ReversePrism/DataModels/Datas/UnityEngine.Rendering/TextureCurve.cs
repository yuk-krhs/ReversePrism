using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_Precision                              int IL2CPP_TYPE_I4
    // 000 k_Step                                   float IL2CPP_TYPE_R4
    // 010 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_Loop                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_ZeroValue                              0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_Range                                  0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_Curve                                  000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 M_LoopingCurve                           000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 030 M_Texture                                000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 038 M_IsCurveDirty                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 M_IsTextureDirty                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TextureCurve : DataModel
    {
        public int                                      Length                                  { get; set; }
        public bool                                     M_Loop                                  { get; set; }
        public float                                    M_ZeroValue                             { get; set; }
        public float                                    M_Range                                 { get; set; }
        public AnimationCurve?                          M_Curve                                 { get; set; }
        public AnimationCurve?                          M_LoopingCurve                          { get; set; }
        public Texture2D?                               M_Texture                               { get; set; }
        public bool                                     M_IsCurveDirty                          { get; set; }
        public bool                                     M_IsTextureDirty                        { get; set; }

        public static TextureCurve? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureCurve() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x010)); // 0246692BD158 0x10 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Loop                                    = GetBool(new IntPtr(p + 0x014)); // 0246692BD178 0x14 M_Loop                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ZeroValue                               = GetSingle(new IntPtr(p + 0x018)); // 0246692BD198 0x18 M_ZeroValue                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Range                                   = GetSingle(new IntPtr(p + 0x01C)); // 0246692BD1B8 0x1C M_Range                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Curve                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0246692BD1D8 0x20 M_Curve                     ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_LoopingCurve                            = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0246692BD1F8 0x28 M_LoopingCurve              ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_Texture                                 = GetObject<Texture2D>(new IntPtr(p + 0x030), ReversePrism.DataModels.Texture2D.FromPointer); // 0246692BD218 0x30 M_Texture                   ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_IsCurveDirty                            = GetBool(new IntPtr(p + 0x038)); // 0246692BD238 0x38 M_IsCurveDirty              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsTextureDirty                          = GetBool(new IntPtr(p + 0x039)); // 0246692BD258 0x39 M_IsTextureDirty            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
