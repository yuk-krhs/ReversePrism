using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 BodyParamType                            ModelEnumType BodyParamType BodyParamType BodyParamType Int32
    // 01C MinBodyParamValue                        ModelPrimitiveType float float float Single
    // 020 MaxBodyParamValue                        ModelPrimitiveType float float float Single
    // 028 SpringPower                              ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 030 LimitDistance                            ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 038 Inertia                                  ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 040 Radius                                   ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 048 ClothSerializeData                       ModelClassType ClothSerializeData ClothSerializeData ClothSerializeData Pointer
    // 050 IsSupportedAdditiveAnimation             ModelPrimitiveType bool bool bool Bool
    public partial class MagicaPhysicsParam : DataModel
    {
        public string                                   Name                                    { get; set; }
        public BodyParamType                            BodyParamType                           { get; set; }
        public float                                    MinBodyParamValue                       { get; set; }
        public float                                    MaxBodyParamValue                       { get; set; }
        public BodyParamFloatProperty?                  SpringPower                             { get; set; }
        public BodyParamFloatProperty?                  LimitDistance                           { get; set; }
        public BodyParamFloatProperty?                  Inertia                                 { get; set; }
        public BodyParamFloatProperty?                  Radius                                  { get; set; }
        public ClothSerializeData?                      ClothSerializeData                      { get; set; }
        public bool                                     IsSupportedAdditiveAnimation            { get; set; }

        public static MagicaPhysicsParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaPhysicsParam() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.BodyParamType                             = (BodyParamType)GetInt32(new IntPtr(p + 0x018)); // 0x18 BodyParamType               ( ModelEnumType BodyParamType BodyParamType BodyParamType Int32 )
            value.MinBodyParamValue                         = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MinBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.MaxBodyParamValue                         = GetSingle(new IntPtr(p + 0x020)); // 0x20 MaxBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.SpringPower                               = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x28 SpringPower                 ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.LimitDistance                             = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x30 LimitDistance               ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.Inertia                                   = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x38 Inertia                     ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.Radius                                    = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x040), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x40 Radius                      ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.ClothSerializeData                        = GetObject<ClothSerializeData>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClothSerializeData.FromPointer); // 0x48 ClothSerializeData          ( ModelClassType ClothSerializeData ClothSerializeData ClothSerializeData Pointer )
            value.IsSupportedAdditiveAnimation              = GetBool(new IntPtr(p + 0x050)); // 0x50 IsSupportedAdditiveAnimation ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
