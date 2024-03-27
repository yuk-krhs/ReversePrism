using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Volume                                   000186666050 ModelPrimitiveType float float float Single
    // 018 CueName                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 BackUpVolume                             000186666050 ModelPrimitiveType float float float Single
    public partial class CueVolumePlayableBehaviour
    {
        public float                                    Volume                                  { get; set; }
        public string                                   CueName                                 { get; set; }
        public float                                    BackUpVolume                            { get; set; }

        public static CueVolumePlayableBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueVolumePlayableBehaviour();

            value.Volume                                    = GetSingle(new IntPtr(p + 0x010)); // 0270D4B1B040 0x10 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0270D4B1B060 0x18 CueName                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.BackUpVolume                              = GetSingle(new IntPtr(p + 0x020)); // 0270D4B1B080 0x20 BackUpVolume                ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
