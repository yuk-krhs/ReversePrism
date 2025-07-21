using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Human                                    ModelEnumListType HumanBone[] HumanBone[] List<HumanBone> Pointer
    // 018 Skeleton                                 ModelEnumListType SkeletonBone[] SkeletonBone[] List<SkeletonBone> Pointer
    // 020 M_ArmTwist                               ModelPrimitiveType float float float Single
    // 024 M_ForeArmTwist                           ModelPrimitiveType float float float Single
    // 028 M_UpperLegTwist                          ModelPrimitiveType float float float Single
    // 02C M_LegTwist                               ModelPrimitiveType float float float Single
    // 030 M_ArmStretch                             ModelPrimitiveType float float float Single
    // 034 M_LegStretch                             ModelPrimitiveType float float float Single
    // 038 M_FeetSpacing                            ModelPrimitiveType float float float Single
    // 03C M_GlobalScale                            ModelPrimitiveType float float float Single
    // 040 M_RootMotionBoneName                     ModelPrimitiveType string string string String
    // 048 M_HasTranslationDoF                      ModelPrimitiveType bool bool bool Bool
    // 049 M_HasExtraRoot                           ModelPrimitiveType bool bool bool Bool
    // 04A M_SkeletonHasParents                     ModelPrimitiveType bool bool bool Bool
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

            value.Human                                     = GetEnumList<HumanBone>(new IntPtr(p + 0x010)); // 0x10 Human                       ( ModelEnumListType HumanBone[] HumanBone[] List<HumanBone> Pointer )
            value.Skeleton                                  = GetEnumList<SkeletonBone>(new IntPtr(p + 0x018)); // 0x18 Skeleton                    ( ModelEnumListType SkeletonBone[] SkeletonBone[] List<SkeletonBone> Pointer )
            value.M_ArmTwist                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_ArmTwist                  ( ModelPrimitiveType float float float Single )
            value.M_ForeArmTwist                            = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_ForeArmTwist              ( ModelPrimitiveType float float float Single )
            value.M_UpperLegTwist                           = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_UpperLegTwist             ( ModelPrimitiveType float float float Single )
            value.M_LegTwist                                = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_LegTwist                  ( ModelPrimitiveType float float float Single )
            value.M_ArmStretch                              = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_ArmStretch                ( ModelPrimitiveType float float float Single )
            value.M_LegStretch                              = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_LegStretch                ( ModelPrimitiveType float float float Single )
            value.M_FeetSpacing                             = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_FeetSpacing               ( ModelPrimitiveType float float float Single )
            value.M_GlobalScale                             = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_GlobalScale               ( ModelPrimitiveType float float float Single )
            value.M_RootMotionBoneName                      = GetString(new IntPtr(p + 0x040)); // 0x40 M_RootMotionBoneName        ( ModelPrimitiveType string string string String )
            value.M_HasTranslationDoF                       = GetBool(new IntPtr(p + 0x048)); // 0x48 M_HasTranslationDoF         ( ModelPrimitiveType bool bool bool Bool )
            value.M_HasExtraRoot                            = GetBool(new IntPtr(p + 0x049)); // 0x49 M_HasExtraRoot              ( ModelPrimitiveType bool bool bool Bool )
            value.M_SkeletonHasParents                      = GetBool(new IntPtr(p + 0x04A)); // 0x4A M_SkeletonHasParents        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
