using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 Ns                                       ModelPrimitiveType string string string String
    public partial class NamespacePrefixForQName : DataModel
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   Ns                                      { get; set; }

        public static NamespacePrefixForQName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespacePrefixForQName() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
