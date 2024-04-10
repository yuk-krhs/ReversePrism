using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 StartLightColor                          0001865AB0A0 ModelEnumType Color Color Color Int32
    // 028 StartLightIntensity                      000186666050 ModelPrimitiveType float float float Single
    // 02C EndLightColor                            0001865AB0A0 ModelEnumType Color Color Color Int32
    // 03C EndLightIntensity                        000186666050 ModelPrimitiveType float float float Single
    // 040 stageController                          ExposedReference`1<StageController> IL2CPP_TYPE_GENERICINST
    public partial class StageControllerPlayableAsset : DataModel
    {
        public Color                                    StartLightColor                         { get; set; }
        public float                                    StartLightIntensity                     { get; set; }
        public Color                                    EndLightColor                           { get; set; }
        public float                                    EndLightIntensity                       { get; set; }

        public static StageControllerPlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StageControllerPlayableAsset() { Pointer= p0 };

            value.StartLightColor                           = (Color)GetInt32(new IntPtr(p + 0x018)); // 024664E74230 0x18 StartLightColor             ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.StartLightIntensity                       = GetSingle(new IntPtr(p + 0x028)); // 024664E74250 0x28 StartLightIntensity         ( 000186666050 ModelPrimitiveType float float float Single )
            value.EndLightColor                             = (Color)GetInt32(new IntPtr(p + 0x02C)); // 024664E74270 0x2C EndLightColor               ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.EndLightIntensity                         = GetSingle(new IntPtr(p + 0x03C)); // 024664E74290 0x3C EndLightIntensity           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
