using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Agent                                    000186671910 ModelPrimitiveType string string string String
    // 018 Code                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 <Date>k__BackingField                    Nullable`1<DateTimeOffset> IL2CPP_TYPE_GENERICINST
    // 038 Text                                     000186671910 ModelPrimitiveType string string string String
    public partial class WarningHeaderValue : DataModel
    {
        public string                                   Agent                                   { get; set; }
        public int                                      Code                                    { get; set; }
        public string                                   Text                                    { get; set; }

        public static WarningHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WarningHeaderValue() { Pointer= p0 };

            value.Agent                                     = GetString(new IntPtr(p + 0x010)); // 02466B949248 0x10 Agent                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Code                                      = GetInt32(new IntPtr(p + 0x018)); // 02466B949268 0x18 Code                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x038)); // 02466B9492A8 0x38 Text                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
