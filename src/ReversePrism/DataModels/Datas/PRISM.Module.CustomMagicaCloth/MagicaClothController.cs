using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ClothGroup                               ModelClassType MagicaClothGroup MagicaClothGroup MagicaClothGroup Pointer
    // 028 MagicaCloth                              ModelClassType MagicaCloth MagicaCloth MagicaCloth Pointer
    // 030 BodyParamType                            ModelEnumType BodyParamType BodyParamType BodyParamType Int32
    // 034 MinBodyParamValue                        ModelPrimitiveType float float float Single
    // 038 MaxBodyParamValue                        ModelPrimitiveType float float float Single
    // 040 SpringPower                              ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 048 LimitDistance                            ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 050 Inertia                                  ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 058 Radius                                   ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 060 CollideCategories                        ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 068 IsSupportedAdditiveAnimation             ModelPrimitiveType bool bool bool Bool
    // 069 CurrentDoAdditiveAnim                    ModelPrimitiveType bool bool bool Bool
    public partial class MagicaClothController : DataModel
    {
        public MagicaClothGroup?                        ClothGroup                              { get; set; }
        public MagicaCloth?                             MagicaCloth                             { get; set; }
        public BodyParamType                            BodyParamType                           { get; set; }
        public float                                    MinBodyParamValue                       { get; set; }
        public float                                    MaxBodyParamValue                       { get; set; }
        public BodyParamFloatProperty?                  SpringPower                             { get; set; }
        public BodyParamFloatProperty?                  LimitDistance                           { get; set; }
        public BodyParamFloatProperty?                  Inertia                                 { get; set; }
        public BodyParamFloatProperty?                  Radius                                  { get; set; }
        public List<string>?                            CollideCategories                       { get; set; }
        public bool                                     IsSupportedAdditiveAnimation            { get; set; }
        public bool                                     CurrentDoAdditiveAnim                   { get; set; }

        public static MagicaClothController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaClothController() { Pointer= p0 };

            value.ClothGroup                                = GetObject<MagicaClothGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.MagicaClothGroup.FromPointer); // 0x20 ClothGroup                  ( ModelClassType MagicaClothGroup MagicaClothGroup MagicaClothGroup Pointer )
            value.MagicaCloth                               = GetObject<MagicaCloth>(new IntPtr(p + 0x028), ReversePrism.DataModels.MagicaCloth.FromPointer); // 0x28 MagicaCloth                 ( ModelClassType MagicaCloth MagicaCloth MagicaCloth Pointer )
            value.BodyParamType                             = (BodyParamType)GetInt32(new IntPtr(p + 0x030)); // 0x30 BodyParamType               ( ModelEnumType BodyParamType BodyParamType BodyParamType Int32 )
            value.MinBodyParamValue                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 MinBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.MaxBodyParamValue                         = GetSingle(new IntPtr(p + 0x038)); // 0x38 MaxBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.SpringPower                               = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x040), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x40 SpringPower                 ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.LimitDistance                             = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x48 LimitDistance               ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.Inertia                                   = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x50 Inertia                     ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.Radius                                    = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x58 Radius                      ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.CollideCategories                         = GetStringList(new IntPtr(p + 0x060)); // 0x60 CollideCategories           ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.IsSupportedAdditiveAnimation              = GetBool(new IntPtr(p + 0x068)); // 0x68 IsSupportedAdditiveAnimation ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentDoAdditiveAnim                     = GetBool(new IntPtr(p + 0x069)); // 0x69 CurrentDoAdditiveAnim       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
