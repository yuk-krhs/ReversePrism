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
    // 010 Curve                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 018 M_Loop                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C M_ZeroValue                              0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_Range                                  0001866656B0 ModelPrimitiveType float float float Single
    // 028 M_InternalLoopingCurve                   000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 030 FrameCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 CachedData                               000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class Spline : DataModel
    {
        public AnimationCurve?                          Curve                                   { get; set; }
        public bool                                     M_Loop                                  { get; set; }
        public float                                    M_ZeroValue                             { get; set; }
        public float                                    M_Range                                 { get; set; }
        public AnimationCurve?                          M_InternalLoopingCurve                  { get; set; }
        public int                                      FrameCount                              { get; set; }
        public List<float>?                             CachedData                              { get; set; }

        public static Spline? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Spline() { Pointer= p0 };

            value.Curve                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A60E0380 0x10 Curve                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_Loop                                    = GetBool(new IntPtr(p + 0x018)); // 0245A60E03A0 0x18 M_Loop                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ZeroValue                               = GetSingle(new IntPtr(p + 0x01C)); // 0245A60E03C0 0x1C M_ZeroValue                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Range                                   = GetSingle(new IntPtr(p + 0x020)); // 0245A60E03E0 0x20 M_Range                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_InternalLoopingCurve                    = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A60E0400 0x28 M_InternalLoopingCurve      ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.FrameCount                                = GetInt32(new IntPtr(p + 0x030)); // 0245A60E0420 0x30 FrameCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CachedData                                = GetSingleList(new IntPtr(p + 0x038)); // 0245A60E0440 0x38 CachedData                  ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
