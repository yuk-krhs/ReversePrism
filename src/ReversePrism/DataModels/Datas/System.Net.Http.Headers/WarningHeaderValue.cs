using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Agent                                    ModelPrimitiveType string string string String
    // 018 Code                                     ModelPrimitiveType int int int Int32
    // 020 <Date>k__BackingField                    Nullable`1<DateTimeOffset> IL2CPP_TYPE_GENERICINST
    // 038 Text                                     ModelPrimitiveType string string string String
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

            value.Agent                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Agent                       ( ModelPrimitiveType string string string String )
            value.Code                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Code                        ( ModelPrimitiveType int int int Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x038)); // 0x38 Text                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
