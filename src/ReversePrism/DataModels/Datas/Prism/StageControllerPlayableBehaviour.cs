using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartLightColor                          0001865AA8E0 ModelEnumType Color Color Color Int32
    // 020 StartLightIntensity                      0001866656B0 ModelPrimitiveType float float float Single
    // 024 EndLightColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 034 EndLightIntensity                        0001866656B0 ModelPrimitiveType float float float Single
    // 038 StageController                          000186562560 ModelClassType StageController StageController StageController Pointer
    public partial class StageControllerPlayableBehaviour
    {
        public Color                                    StartLightColor                         { get; set; }
        public float                                    StartLightIntensity                     { get; set; }
        public Color                                    EndLightColor                           { get; set; }
        public float                                    EndLightIntensity                       { get; set; }
        public StageController?                         StageController                         { get; set; }

        public static StageControllerPlayableBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StageControllerPlayableBehaviour();

            value.StartLightColor                           = (Color)GetInt32(new IntPtr(p + 0x010)); // 0270D4DFF230 0x10 StartLightColor             ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.StartLightIntensity                       = GetSingle(new IntPtr(p + 0x020)); // 0270D4DFF250 0x20 StartLightIntensity         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.EndLightColor                             = (Color)GetInt32(new IntPtr(p + 0x024)); // 0270D4DFF270 0x24 EndLightColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.EndLightIntensity                         = GetSingle(new IntPtr(p + 0x034)); // 0270D4DFF290 0x34 EndLightIntensity           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StageController                           = GetObject<StageController>(new IntPtr(p + 0x038), ReversePrism.DataModels.StageController.FromPointer); // 0270D4DFF2B0 0x38 StageController             ( 000186562560 ModelClassType StageController StageController StageController Pointer )

            return value;
        }
    }
}
