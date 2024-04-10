using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsPreset                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 PositionList                             000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 020 PositionIndex                            000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 Mouth_A                                  000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 030 Mouth_I                                  000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 038 Mouth_U                                  000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 Mouth_E                                  000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 Mouth_O                                  000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 050 Mouth_SA                                 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 Mouth_SI                                 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 060 Mouth_SE                                 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 068 MouthSerious                             000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 070 MouthShy                                 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 078 MouthSurprise                            000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 080 MouthAnger                               000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 088 EyeLClose                                000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 090 EyeRClose                                000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 098 EyeLSmile                                000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0A0 EyeRSmile                                000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0A8 EyeBrowSerious                           000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0B0 EyeBrowSad                               000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0B8 EyeBrowUnique                            000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0C0 EyeBrowUp                                000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0C8 EyeBrowDown                              000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0D0 LipSyncRate                              000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class AnimParamCurve : DataModel
    {
        public bool                                     IsPreset                                { get; set; }
        public List<Vector3>?                           PositionList                            { get; set; }
        public AnimationCurve?                          PositionIndex                           { get; set; }
        public AnimationCurve?                          Mouth_A                                 { get; set; }
        public AnimationCurve?                          Mouth_I                                 { get; set; }
        public AnimationCurve?                          Mouth_U                                 { get; set; }
        public AnimationCurve?                          Mouth_E                                 { get; set; }
        public AnimationCurve?                          Mouth_O                                 { get; set; }
        public AnimationCurve?                          Mouth_SA                                { get; set; }
        public AnimationCurve?                          Mouth_SI                                { get; set; }
        public AnimationCurve?                          Mouth_SE                                { get; set; }
        public AnimationCurve?                          MouthSerious                            { get; set; }
        public AnimationCurve?                          MouthShy                                { get; set; }
        public AnimationCurve?                          MouthSurprise                           { get; set; }
        public AnimationCurve?                          MouthAnger                              { get; set; }
        public AnimationCurve?                          EyeLClose                               { get; set; }
        public AnimationCurve?                          EyeRClose                               { get; set; }
        public AnimationCurve?                          EyeLSmile                               { get; set; }
        public AnimationCurve?                          EyeRSmile                               { get; set; }
        public AnimationCurve?                          EyeBrowSerious                          { get; set; }
        public AnimationCurve?                          EyeBrowSad                              { get; set; }
        public AnimationCurve?                          EyeBrowUnique                           { get; set; }
        public AnimationCurve?                          EyeBrowUp                               { get; set; }
        public AnimationCurve?                          EyeBrowDown                             { get; set; }
        public AnimationCurve?                          LipSyncRate                             { get; set; }

        public static AnimParamCurve? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimParamCurve() { Pointer= p0 };

            value.IsPreset                                  = GetBool(new IntPtr(p + 0x010)); // 0245A72A63F8 0x10 IsPreset                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PositionList                              = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0245A72A6418 0x18 PositionList                ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.PositionIndex                             = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6438 0x20 PositionIndex               ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_A                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6458 0x28 Mouth_A                     ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_I                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6478 0x30 Mouth_I                     ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_U                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6498 0x38 Mouth_U                     ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_E                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A64B8 0x40 Mouth_E                     ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_O                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A64D8 0x48 Mouth_O                     ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_SA                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A64F8 0x50 Mouth_SA                    ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_SI                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6518 0x58 Mouth_SI                    ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_SE                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6538 0x60 Mouth_SE                    ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthSerious                              = GetObject<AnimationCurve>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6558 0x68 MouthSerious                ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthShy                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6578 0x70 MouthShy                    ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthSurprise                             = GetObject<AnimationCurve>(new IntPtr(p + 0x078), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6598 0x78 MouthSurprise               ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthAnger                                = GetObject<AnimationCurve>(new IntPtr(p + 0x080), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A65B8 0x80 MouthAnger                  ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeLClose                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A65D8 0x88 EyeLClose                   ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeRClose                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x090), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A65F8 0x90 EyeRClose                   ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeLSmile                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x098), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6618 0x98 EyeLSmile                   ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeRSmile                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6638 0xA0 EyeRSmile                   ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowSerious                            = GetObject<AnimationCurve>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6658 0xA8 EyeBrowSerious              ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowSad                                = GetObject<AnimationCurve>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6678 0xB0 EyeBrowSad                  ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowUnique                             = GetObject<AnimationCurve>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A6698 0xB8 EyeBrowUnique               ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowUp                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A66B8 0xC0 EyeBrowUp                   ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowDown                               = GetObject<AnimationCurve>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A66D8 0xC8 EyeBrowDown                 ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.LipSyncRate                               = GetObject<AnimationCurve>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A72A66F8 0xD0 LipSyncRate                 ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
