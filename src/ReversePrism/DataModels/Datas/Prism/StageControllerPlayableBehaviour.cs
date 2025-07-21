using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartLightColor                          ModelEnumType Color Color Color Int32
    // 020 StartLightIntensity                      ModelPrimitiveType float float float Single
    // 024 EndLightColor                            ModelEnumType Color Color Color Int32
    // 034 EndLightIntensity                        ModelPrimitiveType float float float Single
    // 038 StageController                          ModelClassType StageController StageController StageController Pointer
    public partial class StageControllerPlayableBehaviour : DataModel
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
            var value   = new StageControllerPlayableBehaviour() { Pointer= p0 };

            value.StartLightColor                           = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 StartLightColor             ( ModelEnumType Color Color Color Int32 )
            value.StartLightIntensity                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 StartLightIntensity         ( ModelPrimitiveType float float float Single )
            value.EndLightColor                             = (Color)GetInt32(new IntPtr(p + 0x024)); // 0x24 EndLightColor               ( ModelEnumType Color Color Color Int32 )
            value.EndLightIntensity                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 EndLightIntensity           ( ModelPrimitiveType float float float Single )
            value.StageController                           = GetObject<StageController>(new IntPtr(p + 0x038), ReversePrism.DataModels.StageController.FromPointer); // 0x38 StageController             ( ModelClassType StageController StageController StageController Pointer )

            return value;
        }
    }
}
