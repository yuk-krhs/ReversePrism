using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ToolboxItemTypeName                      ModelPrimitiveType string string string String
    // 000 Default                                  ToolboxItemAttribute IL2CPP_TYPE_CLASS
    // 008 None                                     ToolboxItemAttribute IL2CPP_TYPE_CLASS
    public partial class ToolboxItemAttribute : DataModel
    {
        public string                                   ToolboxItemTypeName                     { get; set; }

        public static ToolboxItemAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToolboxItemAttribute() { Pointer= p0 };

            value.ToolboxItemTypeName                       = GetString(new IntPtr(p + 0x010)); // 0x10 ToolboxItemTypeName         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
