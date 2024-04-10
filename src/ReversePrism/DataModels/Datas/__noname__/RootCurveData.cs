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
    public partial class RootCurveData : DataModel
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
            var value   = new RootCurveData() { Pointer= p0 };

            value.Root                                      = GetBool(new IntPtr(p + 0x010)); // 024664DF2C70 0x10 Root                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RootScaling                               = GetBool(new IntPtr(p + 0x011)); // 024664DF2C90 0x11 RootScaling                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Pos_x                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 024664DF2CB0 0x18 Pos_x                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Pos_y                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 024664DF2CD0 0x20 Pos_y                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Pos_z                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 024664DF2CF0 0x28 Pos_z                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_x                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 024664DF2D10 0x30 Rot_x                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_y                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 024664DF2D30 0x38 Rot_y                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_z                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 024664DF2D50 0x40 Rot_z                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Rot_w                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimationCurve.FromPointer); // 024664DF2D70 0x48 Rot_w                       ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
