using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Order                                    ModelPrimitiveType int int int Int32
    public partial class DisplayInfoAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Order                                   { get; set; }

        public static DisplayInfoAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisplayInfoAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Order                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
