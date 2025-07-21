using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UserName                                 ModelPrimitiveType string string string String
    // 030 ProduceIdolId                            ModelPrimitiveType int int int Int32
    public partial class MusicRateOverlayUserInfoViewModel : DataModel
    {
        public string                                   UserName                                { get; set; }
        public int                                      ProduceIdolId                           { get; set; }

        public static MusicRateOverlayUserInfoViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateOverlayUserInfoViewModel() { Pointer= p0 };

            value.UserName                                  = GetString(new IntPtr(p + 0x028)); // 0x28 UserName                    ( ModelPrimitiveType string string string String )
            value.ProduceIdolId                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 ProduceIdolId               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
