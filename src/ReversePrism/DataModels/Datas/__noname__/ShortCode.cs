using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ShortCode> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RegionCodeFieldNumber                    int IL2CPP_TYPE_I4
    // 018 RegionCode                               000186671910 ModelPrimitiveType string string string String
    // 000 NumberFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Number                                   000186671910 ModelPrimitiveType string string string String
    public partial class ShortCode
    {
        public string                                   RegionCode                              { get; set; }
        public string                                   Number                                  { get; set; }

        public static ShortCode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShortCode();

            value.RegionCode                                = GetString(new IntPtr(p + 0x018)); // 0270DA6AB338 0x18 RegionCode                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Number                                    = GetString(new IntPtr(p + 0x020)); // 0270DA6AB378 0x20 Number                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
