using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 0001866736C0 ModelPrimitiveType string string string String
    // 018 Id                                       0001865F4940 ModelPrimitiveType int int int Int32
    public partial class LocalizationKey
    {
        public string                                   Category                                { get; set; }
        public int                                      Id                                      { get; set; }

        public static LocalizationKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalizationKey();

            value.Category                                  = GetString(new IntPtr(p + 0x010)); // 0270D5DFD310 0x10 Category                    ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 0270D5DFD330 0x18 Id                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
