using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SerializeData                            ModelClassType ClothSerializeData ClothSerializeData ClothSerializeData Pointer
    // 028 SerializeData2                           ModelClassType ClothSerializeData2 ClothSerializeData2 ClothSerializeData2 Pointer
    // 030 Process                                  ModelClassType ClothProcess ClothProcess ClothProcess Pointer
    // 038 AnimationPoseRatioProperty               ModelPrimitiveType float float float Single
    // 03C AnimationPoseRatioProperty               ModelPrimitiveType float float float Single
    // 040 GravityProperty                          ModelPrimitiveType float float float Single
    // 044 GravityProperty                          ModelPrimitiveType float float float Single
    // 048 DampingProperty                          ModelPrimitiveType float float float Single
    // 04C DampingProperty                          ModelPrimitiveType float float float Single
    // 050 WorldInertiaProperty                     ModelPrimitiveType float float float Single
    // 054 WorldInertiaProperty                     ModelPrimitiveType float float float Single
    // 058 LocalInertiaProperty                     ModelPrimitiveType float float float Single
    // 05C LocalInertiaProperty                     ModelPrimitiveType float float float Single
    // 060 WindInfluenceProperty                    ModelPrimitiveType float float float Single
    // 064 WindInfluenceProperty                    ModelPrimitiveType float float float Single
    // 068 OnBuildComplete                          Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class MagicaCloth : DataModel
    {
        public ClothSerializeData?                      SerializeData                           { get; set; }
        public ClothSerializeData2?                     SerializeData2                          { get; set; }
        public ClothProcess?                            Process                                 { get; set; }
        public float                                    AnimationPoseRatioProperty              { get; set; }
        public float                                    GravityProperty                         { get; set; }
        public float                                    DampingProperty                         { get; set; }
        public float                                    WorldInertiaProperty                    { get; set; }
        public float                                    LocalInertiaProperty                    { get; set; }
        public float                                    WindInfluenceProperty                   { get; set; }

        public static MagicaCloth? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaCloth() { Pointer= p0 };

            value.SerializeData                             = GetObject<ClothSerializeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ClothSerializeData.FromPointer); // 0x20 SerializeData               ( ModelClassType ClothSerializeData ClothSerializeData ClothSerializeData Pointer )
            value.SerializeData2                            = GetObject<ClothSerializeData2>(new IntPtr(p + 0x028), ReversePrism.DataModels.ClothSerializeData2.FromPointer); // 0x28 SerializeData2              ( ModelClassType ClothSerializeData2 ClothSerializeData2 ClothSerializeData2 Pointer )
            value.Process                                   = GetObject<ClothProcess>(new IntPtr(p + 0x030), ReversePrism.DataModels.ClothProcess.FromPointer); // 0x30 Process                     ( ModelClassType ClothProcess ClothProcess ClothProcess Pointer )
            value.AnimationPoseRatioProperty                = GetSingle(new IntPtr(p + 0x03C)); // 0x3C AnimationPoseRatioProperty  ( ModelPrimitiveType float float float Single )
            value.GravityProperty                           = GetSingle(new IntPtr(p + 0x044)); // 0x44 GravityProperty             ( ModelPrimitiveType float float float Single )
            value.DampingProperty                           = GetSingle(new IntPtr(p + 0x04C)); // 0x4C DampingProperty             ( ModelPrimitiveType float float float Single )
            value.WorldInertiaProperty                      = GetSingle(new IntPtr(p + 0x054)); // 0x54 WorldInertiaProperty        ( ModelPrimitiveType float float float Single )
            value.LocalInertiaProperty                      = GetSingle(new IntPtr(p + 0x05C)); // 0x5C LocalInertiaProperty        ( ModelPrimitiveType float float float Single )
            value.WindInfluenceProperty                     = GetSingle(new IntPtr(p + 0x064)); // 0x64 WindInfluenceProperty       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
