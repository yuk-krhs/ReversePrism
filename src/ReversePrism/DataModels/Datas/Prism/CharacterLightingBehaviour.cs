using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RimPower                                 000186666050 ModelPrimitiveType float float float Single
    // 014 RimIntensity                             000186666050 ModelPrimitiveType float float float Single
    // 018 RimColor                                 0001865AB0A0 ModelEnumType Color Color Color Int32
    // 028 RimLightDirection                        0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 RimFeather                               000186666050 ModelPrimitiveType float float float Single
    // 038 RimDiffuseRate                           000186666050 ModelPrimitiveType float float float Single
    public partial class CharacterLightingBehaviour
    {
        public float                                    RimPower                                { get; set; }
        public float                                    RimIntensity                            { get; set; }
        public Color                                    RimColor                                { get; set; }
        public Vector3                                  RimLightDirection                       { get; set; }
        public float                                    RimFeather                              { get; set; }
        public float                                    RimDiffuseRate                          { get; set; }

        public static CharacterLightingBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterLightingBehaviour();

            value.RimPower                                  = GetSingle(new IntPtr(p + 0x010)); // 0270D4DFE0B0 0x10 RimPower                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.RimIntensity                              = GetSingle(new IntPtr(p + 0x014)); // 0270D4DFE0D0 0x14 RimIntensity                ( 000186666050 ModelPrimitiveType float float float Single )
            value.RimColor                                  = (Color)GetInt32(new IntPtr(p + 0x018)); // 0270D4DFE0F0 0x18 RimColor                    ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RimLightDirection                         = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0270D4DFE110 0x28 RimLightDirection           ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RimFeather                                = GetSingle(new IntPtr(p + 0x034)); // 0270D4DFE130 0x34 RimFeather                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.RimDiffuseRate                            = GetSingle(new IntPtr(p + 0x038)); // 0270D4DFE150 0x38 RimDiffuseRate              ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
