using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MenuItem                                 0001866736C0 ModelPrimitiveType string string string String
    // 018 Validate                                 000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 01C Priority                                 0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ContextMenu
    {
        public string                                   MenuItem                                { get; set; }
        public bool                                     Validate                                { get; set; }
        public int                                      Priority                                { get; set; }

        public static ContextMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextMenu();

            value.MenuItem                                  = GetString(new IntPtr(p + 0x010)); // 02700234AE98 0x10 MenuItem                    ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Validate                                  = GetBool(new IntPtr(p + 0x018)); // 02700234AEB8 0x18 Validate                    ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x01C)); // 02700234AED8 0x1C Priority                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
