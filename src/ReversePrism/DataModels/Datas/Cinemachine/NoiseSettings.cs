using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PositionNoise                            ModelEnumListType TransformNoiseParams[] TransformNoiseParams[] List<TransformNoiseParams> Pointer
    // 020 OrientationNoise                         ModelEnumListType TransformNoiseParams[] TransformNoiseParams[] List<TransformNoiseParams> Pointer
    public partial class NoiseSettings : DataModel
    {
        public List<TransformNoiseParams>?              PositionNoise                           { get; set; }
        public List<TransformNoiseParams>?              OrientationNoise                        { get; set; }

        public static NoiseSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoiseSettings() { Pointer= p0 };

            value.PositionNoise                             = GetEnumList<TransformNoiseParams>(new IntPtr(p + 0x018)); // 0x18 PositionNoise               ( ModelEnumListType TransformNoiseParams[] TransformNoiseParams[] List<TransformNoiseParams> Pointer )
            value.OrientationNoise                          = GetEnumList<TransformNoiseParams>(new IntPtr(p + 0x020)); // 0x20 OrientationNoise            ( ModelEnumListType TransformNoiseParams[] TransformNoiseParams[] List<TransformNoiseParams> Pointer )

            return value;
        }
    }
}
