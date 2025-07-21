using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsPreset                                 ModelPrimitiveType bool bool bool Bool
    // 018 PositionList                             ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 020 PositionIndex                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 Mouth_A                                  ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 030 Mouth_I                                  ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 038 Mouth_U                                  ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 Mouth_E                                  ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 Mouth_O                                  ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 050 Mouth_SA                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 Mouth_SI                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 060 Mouth_SE                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 068 MouthSerious                             ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 070 MouthShy                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 078 MouthSurprise                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 080 MouthAnger                               ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 088 EyeLClose                                ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 090 EyeRClose                                ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 098 EyeLSmile                                ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0A0 EyeRSmile                                ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0A8 EyeBrowSerious                           ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0B0 EyeBrowSad                               ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0B8 EyeBrowUnique                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0C0 EyeBrowUp                                ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0C8 EyeBrowDown                              ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0D0 LipSyncRate                              ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
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

            value.IsPreset                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsPreset                    ( ModelPrimitiveType bool bool bool Bool )
            value.PositionList                              = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0x18 PositionList                ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.PositionIndex                             = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x20 PositionIndex               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_A                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x28 Mouth_A                     ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_I                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x30 Mouth_I                     ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_U                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x38 Mouth_U                     ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_E                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x40 Mouth_E                     ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_O                                   = GetObject<AnimationCurve>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x48 Mouth_O                     ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_SA                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x50 Mouth_SA                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_SI                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x58 Mouth_SI                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Mouth_SE                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x60 Mouth_SE                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthSerious                              = GetObject<AnimationCurve>(new IntPtr(p + 0x068), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x68 MouthSerious                ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthShy                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x70 MouthShy                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthSurprise                             = GetObject<AnimationCurve>(new IntPtr(p + 0x078), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x78 MouthSurprise               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MouthAnger                                = GetObject<AnimationCurve>(new IntPtr(p + 0x080), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x80 MouthAnger                  ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeLClose                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x88 EyeLClose                   ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeRClose                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x090), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x90 EyeRClose                   ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeLSmile                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x098), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x98 EyeLSmile                   ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeRSmile                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xA0 EyeRSmile                   ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowSerious                            = GetObject<AnimationCurve>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xA8 EyeBrowSerious              ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowSad                                = GetObject<AnimationCurve>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xB0 EyeBrowSad                  ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowUnique                             = GetObject<AnimationCurve>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xB8 EyeBrowUnique               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowUp                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xC0 EyeBrowUp                   ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeBrowDown                               = GetObject<AnimationCurve>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xC8 EyeBrowDown                 ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.LipSyncRate                               = GetObject<AnimationCurve>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xD0 LipSyncRate                 ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
