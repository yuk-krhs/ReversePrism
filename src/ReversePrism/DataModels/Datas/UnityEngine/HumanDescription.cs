using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Human                                    000185B854D0 ModelEnumListType HumanBone[] HumanBone[] List<HumanBone> Pointer
    // 018 Skeleton                                 000185CA3EB8 ModelEnumListType SkeletonBone[] SkeletonBone[] List<SkeletonBone> Pointer
    // 020 M_ArmTwist                               000186665900 ModelPrimitiveType float float float Single
    // 024 M_ForeArmTwist                           000186665900 ModelPrimitiveType float float float Single
    // 028 M_UpperLegTwist                          000186665900 ModelPrimitiveType float float float Single
    // 02C M_LegTwist                               000186665900 ModelPrimitiveType float float float Single
    // 030 M_ArmStretch                             000186665900 ModelPrimitiveType float float float Single
    // 034 M_LegStretch                             000186665900 ModelPrimitiveType float float float Single
    // 038 M_FeetSpacing                            000186665900 ModelPrimitiveType float float float Single
    // 03C M_GlobalScale                            000186665900 ModelPrimitiveType float float float Single
    // 040 M_RootMotionBoneName                     000186671BA0 ModelPrimitiveType string string string String
    // 048 M_HasTranslationDoF                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 049 M_HasExtraRoot                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 04A M_SkeletonHasParents                     000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class HumanDescription : DataModel
    {
        public List<HumanBone>?                         Human                                   { get; set; }
        public List<SkeletonBone>?                      Skeleton                                { get; set; }
        public float                                    M_ArmTwist                              { get; set; }
        public float                                    M_ForeArmTwist                          { get; set; }
        public float                                    M_UpperLegTwist                         { get; set; }
        public float                                    M_LegTwist                              { get; set; }
        public float                                    M_ArmStretch                            { get; set; }
        public float                                    M_LegStretch                            { get; set; }
        public float                                    M_FeetSpacing                           { get; set; }
        public float                                    M_GlobalScale                           { get; set; }
        public string                                   M_RootMotionBoneName                    { get; set; }
        public bool                                     M_HasTranslationDoF                     { get; set; }
        public bool                                     M_HasExtraRoot                          { get; set; }
        public bool                                     M_SkeletonHasParents                    { get; set; }

        public static HumanDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HumanDescription() { Pointer= p0 };

            value.Human                                     = GetEnumList<HumanBone>(new IntPtr(p + 0x010)); // 0245A68F66B8 0x10 Human                       ( 000185B854D0 ModelEnumListType HumanBone[] HumanBone[] List<HumanBone> Pointer )
            value.Skeleton                                  = GetEnumList<SkeletonBone>(new IntPtr(p + 0x018)); // 0245A68F66D8 0x18 Skeleton                    ( 000185CA3EB8 ModelEnumListType SkeletonBone[] SkeletonBone[] List<SkeletonBone> Pointer )
            value.M_ArmTwist                                = GetSingle(new IntPtr(p + 0x020)); // 0245A68F66F8 0x20 M_ArmTwist                  ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_ForeArmTwist                            = GetSingle(new IntPtr(p + 0x024)); // 0245A68F6718 0x24 M_ForeArmTwist              ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_UpperLegTwist                           = GetSingle(new IntPtr(p + 0x028)); // 0245A68F6738 0x28 M_UpperLegTwist             ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_LegTwist                                = GetSingle(new IntPtr(p + 0x02C)); // 0245A68F6758 0x2C M_LegTwist                  ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_ArmStretch                              = GetSingle(new IntPtr(p + 0x030)); // 0245A68F6778 0x30 M_ArmStretch                ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_LegStretch                              = GetSingle(new IntPtr(p + 0x034)); // 0245A68F6798 0x34 M_LegStretch                ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_FeetSpacing                             = GetSingle(new IntPtr(p + 0x038)); // 0245A68F67B8 0x38 M_FeetSpacing               ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_GlobalScale                             = GetSingle(new IntPtr(p + 0x03C)); // 0245A68F67D8 0x3C M_GlobalScale               ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_RootMotionBoneName                      = GetString(new IntPtr(p + 0x040)); // 0245A68F67F8 0x40 M_RootMotionBoneName        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_HasTranslationDoF                       = GetBool(new IntPtr(p + 0x048)); // 0245A68F6818 0x48 M_HasTranslationDoF         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_HasExtraRoot                            = GetBool(new IntPtr(p + 0x049)); // 0245A68F6838 0x49 M_HasExtraRoot              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_SkeletonHasParents                      = GetBool(new IntPtr(p + 0x04A)); // 0245A68F6858 0x4A M_SkeletonHasParents        ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
