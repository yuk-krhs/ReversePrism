using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Name                                     ModelPrimitiveType string string string String
    // 038 Description                              ModelPrimitiveType string string string String
    public partial class NamedPermissionSet : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Description                             { get; set; }

        public static NamedPermissionSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamedPermissionSet() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Name                        ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x038)); // 0x38 Description                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
