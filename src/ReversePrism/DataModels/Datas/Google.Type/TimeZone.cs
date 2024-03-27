using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TimeZone> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdFieldNumber                            int IL2CPP_TYPE_I4
    // 018 Id                                       000186671910 ModelPrimitiveType string string string String
    // 000 VersionFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Version                                  000186671910 ModelPrimitiveType string string string String
    public partial class TimeZone
    {
        public string                                   Id                                      { get; set; }
        public string                                   Version                                 { get; set; }

        public static TimeZone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeZone();

            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0270DA68D440 0x18 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x020)); // 0270DA68D480 0x20 Version                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
