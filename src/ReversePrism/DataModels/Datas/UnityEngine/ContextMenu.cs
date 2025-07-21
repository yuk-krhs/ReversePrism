using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MenuItem                                 ModelPrimitiveType string string string String
    // 018 Validate                                 ModelPrimitiveType bool bool bool Bool
    // 01C Priority                                 ModelPrimitiveType int int int Int32
    public partial class ContextMenu : DataModel
    {
        public string                                   MenuItem                                { get; set; }
        public bool                                     Validate                                { get; set; }
        public int                                      Priority                                { get; set; }

        public static ContextMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextMenu() { Pointer= p0 };

            value.MenuItem                                  = GetString(new IntPtr(p + 0x010)); // 0x10 MenuItem                    ( ModelPrimitiveType string string string String )
            value.Validate                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 Validate                    ( ModelPrimitiveType bool bool bool Bool )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Priority                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
