using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 CueName                                  000186671910 ModelPrimitiveType string string string String
    // 020 Volume                                   0001866656B0 ModelPrimitiveType float float float Single
    public partial class CueVolumePlayableAsset
    {
        public string                                   CueName                                 { get; set; }
        public float                                    Volume                                  { get; set; }

        public static CueVolumePlayableAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueVolumePlayableAsset();

            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0270D4B1B000 0x18 CueName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x020)); // 0270D4B1B020 0x20 Volume                      ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
