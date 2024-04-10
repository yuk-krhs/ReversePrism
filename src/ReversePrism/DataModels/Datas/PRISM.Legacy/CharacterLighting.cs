using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RimPower                                 000186666050 ModelPrimitiveType float float float Single
    // 024 RimIntensity                             000186666050 ModelPrimitiveType float float float Single
    // 028 RimColor                                 0001865AB0A0 ModelEnumType Color Color Color Int32
    // 038 RimLightDirection                        0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 RimFeather                               000186666050 ModelPrimitiveType float float float Single
    // 048 RimDiffuseRate                           000186666050 ModelPrimitiveType float float float Single
    // 000 CharacterLightingList                    List`1<CharacterLighting> IL2CPP_TYPE_GENERICINST
    public partial class CharacterLighting : DataModel
    {
        public float                                    RimPower                                { get; set; }
        public float                                    RimIntensity                            { get; set; }
        public Color                                    RimColor                                { get; set; }
        public Vector3                                  RimLightDirection                       { get; set; }
        public float                                    RimFeather                              { get; set; }
        public float                                    RimDiffuseRate                          { get; set; }

        public static CharacterLighting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterLighting() { Pointer= p0 };

            value.RimPower                                  = GetSingle(new IntPtr(p + 0x020)); // 024660DFB2B0 0x20 RimPower                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.RimIntensity                              = GetSingle(new IntPtr(p + 0x024)); // 024660DFB2D0 0x24 RimIntensity                ( 000186666050 ModelPrimitiveType float float float Single )
            value.RimColor                                  = (Color)GetInt32(new IntPtr(p + 0x028)); // 024660DFB2F0 0x28 RimColor                    ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RimLightDirection                         = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 024660DFB310 0x38 RimLightDirection           ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RimFeather                                = GetSingle(new IntPtr(p + 0x044)); // 024660DFB330 0x44 RimFeather                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.RimDiffuseRate                            = GetSingle(new IntPtr(p + 0x048)); // 024660DFB350 0x48 RimDiffuseRate              ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
