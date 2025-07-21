using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Value                                    ModelPrimitiveType long long long Int64
    // 020 KnownColor                               ModelPrimitiveType short short short Int16
    // 022 State                                    ModelPrimitiveType short short short Int16
    public partial class Color : DataModel
    {
        public string                                   Name                                    { get; set; }
        public long                                     Value                                   { get; set; }
        public short                                    KnownColor                              { get; set; }
        public short                                    State                                   { get; set; }

        public static Color? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Color() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Value                                     = GetInt64(new IntPtr(p + 0x018)); // 0x18 Value                       ( ModelPrimitiveType long long long Int64 )
            value.KnownColor                                = GetInt16(new IntPtr(p + 0x020)); // 0x20 KnownColor                  ( ModelPrimitiveType short short short Int16 )
            value.State                                     = GetInt16(new IntPtr(p + 0x022)); // 0x22 State                       ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
