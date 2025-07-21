using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 CueName                                  ModelPrimitiveType string string string String
    // 020 Volume                                   ModelPrimitiveType float float float Single
    public partial class CueVolumePlayableAsset : DataModel
    {
        public string                                   CueName                                 { get; set; }
        public float                                    Volume                                  { get; set; }

        public static CueVolumePlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueVolumePlayableAsset() { Pointer= p0 };

            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0x18 CueName                     ( ModelPrimitiveType string string string String )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x020)); // 0x20 Volume                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
