using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType string string string String
    // 018 FriendlyName                             ModelPrimitiveType string string string String
    // 020 Group                                    ModelEnumType OidGroup OidGroup OidGroup Int32
    public partial class Oid : DataModel
    {
        public string                                   Value                                   { get; set; }
        public string                                   FriendlyName                            { get; set; }
        public OidGroup                                 Group                                   { get; set; }

        public static Oid? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Oid() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType string string string String )
            value.FriendlyName                              = GetString(new IntPtr(p + 0x018)); // 0x18 FriendlyName                ( ModelPrimitiveType string string string String )
            value.Group                                     = (OidGroup)GetInt32(new IntPtr(p + 0x020)); // 0x20 Group                       ( ModelEnumType OidGroup OidGroup OidGroup Int32 )

            return value;
        }
    }
}
