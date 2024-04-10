using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      000186672F10 ModelPrimitiveType string string string String
    // 018 Value                                    000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyMetadataAttribute : DataModel
    {
        public string                                   Key                                     { get; set; }
        public string                                   Value                                   { get; set; }

        public static AssemblyMetadataAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyMetadataAttribute() { Pointer= p0 };

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 024666D38C08 0x10 Key                         ( 000186672F10 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 024666D38C28 0x18 Value                       ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
