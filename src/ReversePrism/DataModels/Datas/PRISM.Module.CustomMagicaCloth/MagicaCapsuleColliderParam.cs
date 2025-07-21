using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Direction                                ModelEnumType Direction Direction Direction Int32
    // 06C RadiusSeparation                         ModelPrimitiveType bool bool bool Bool
    // 06D AlignedOnCenter                          ModelPrimitiveType bool bool bool Bool
    // 070 StartRadius                              ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 078 EndRadius                                ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 080 Length                                   ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    public partial class MagicaCapsuleColliderParam : DataModel
    {
        public Direction                                Direction                               { get; set; }
        public bool                                     RadiusSeparation                        { get; set; }
        public bool                                     AlignedOnCenter                         { get; set; }
        public BodyParamFloatProperty?                  StartRadius                             { get; set; }
        public BodyParamFloatProperty?                  EndRadius                               { get; set; }
        public BodyParamFloatProperty?                  Length                                  { get; set; }

        public static MagicaCapsuleColliderParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaCapsuleColliderParam() { Pointer= p0 };

            value.Direction                                 = (Direction)GetInt32(new IntPtr(p + 0x068)); // 0x68 Direction                   ( ModelEnumType Direction Direction Direction Int32 )
            value.RadiusSeparation                          = GetBool(new IntPtr(p + 0x06C)); // 0x6C RadiusSeparation            ( ModelPrimitiveType bool bool bool Bool )
            value.AlignedOnCenter                           = GetBool(new IntPtr(p + 0x06D)); // 0x6D AlignedOnCenter             ( ModelPrimitiveType bool bool bool Bool )
            value.StartRadius                               = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x070), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x70 StartRadius                 ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.EndRadius                                 = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x078), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x78 EndRadius                   ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.Length                                    = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x080), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x80 Length                      ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )

            return value;
        }
    }
}
