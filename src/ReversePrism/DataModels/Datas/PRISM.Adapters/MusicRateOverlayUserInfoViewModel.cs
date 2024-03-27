using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UserName                                 000186672F10 ModelPrimitiveType string string string String
    // 030 ProduceIdolId                            0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MusicRateOverlayUserInfoViewModel
    {
        public string                                   UserName                                { get; set; }
        public int                                      ProduceIdolId                           { get; set; }

        public static MusicRateOverlayUserInfoViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateOverlayUserInfoViewModel();

            value.UserName                                  = GetString(new IntPtr(p + 0x028)); // 0270D6415AA8 0x28 UserName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.ProduceIdolId                             = GetInt32(new IntPtr(p + 0x030)); // 0270D6415AC8 0x30 ProduceIdolId               ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
