using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Order                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Unique                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class IndexedAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Order                                   { get; set; }
        public bool                                     Unique                                  { get; set; }

        public static IndexedAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexedAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0245A3D99630 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A3D99650 0x18 Order                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Unique                                    = GetBool(new IntPtr(p + 0x01C)); // 0245A3D99670 0x1C Unique                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
