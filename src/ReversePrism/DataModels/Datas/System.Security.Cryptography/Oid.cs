using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186671910 ModelPrimitiveType string string string String
    // 018 FriendlyName                             000186671910 ModelPrimitiveType string string string String
    // 020 Group                                    0001866D9490 ModelEnumType OidGroup OidGroup OidGroup Int32
    public partial class Oid
    {
        public string                                   Value                                   { get; set; }
        public string                                   FriendlyName                            { get; set; }
        public OidGroup                                 Group                                   { get; set; }

        public static Oid? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Oid();

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0270D79A48D0 0x10 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.FriendlyName                              = GetString(new IntPtr(p + 0x018)); // 0270D79A48F0 0x18 FriendlyName                ( 000186671910 ModelPrimitiveType string string string String )
            value.Group                                     = (OidGroup)GetInt32(new IntPtr(p + 0x020)); // 0270D79A4910 0x20 Group                       ( 0001866D9490 ModelEnumType OidGroup OidGroup OidGroup Int32 )

            return value;
        }
    }
}
