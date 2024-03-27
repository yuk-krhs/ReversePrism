using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Root                                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 RootScaling                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Pos_x                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 Pos_y                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 Pos_z                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 030 Rot_x                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 038 Rot_y                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 Rot_z                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 Rot_w                                    000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class RootCurveData
    {
        public bool                                     Root                                    { get; set; }
        public bool                                     RootScaling                             { get; set; }
        public AnimationCurve?                          Pos_x                                   { get; set; }
        public AnimationCurve?                          Pos_y                                   { get; set; }
        public AnimationCurve?                          Pos_z                                   { get; set; }
        public AnimationCurve?                          Rot_x                                   { get; set; }
        public AnimationCurve?                          Rot_y                                   { get; set; }
        public AnimationCurve?                          Rot_z                                   { get; set; }
        public AnimationCurve?                          Rot_w                                   { get; set; }

        public static RootCurveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RootCurveData();

            value.Root                                      = GetBool(new IntPtr(p + 0x010)); // 0270D4D99818 0x10 Root                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RootScaling                               = GetBool(new IntPtr(p + 0x011)); // 0270D4D99838 0x11 RootScaling                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Pos_x                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4D99858 0x18 Pos_x                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Pos_y                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4D99878 0x20 Pos_y                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Pos_z                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4D99898 0x28 Pos_z                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_x                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4D998B8 0x30 Rot_x                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_y                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4D998D8 0x38 Rot_y                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_z                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4D998F8 0x40 Rot_z                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_w                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4D99918 0x48 Rot_w                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
