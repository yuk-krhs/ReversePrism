using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MethodName                               000186672F10 ModelPrimitiveType string string string String
    // 018 DebugInfo                                00018669CEB0 ModelClassType DebugInfo DebugInfo DebugInfo Pointer
    public partial class InterpretedFrameInfo : DataModel
    {
        public string                                   MethodName                              { get; set; }
        public DebugInfo?                               DebugInfo                               { get; set; }

        public static InterpretedFrameInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterpretedFrameInfo() { Pointer= p0 };

            value.MethodName                                = GetString(new IntPtr(p + 0x010)); // 02466A049B68 0x10 MethodName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.DebugInfo                                 = GetObject<DebugInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.DebugInfo.FromPointer); // 02466A049B88 0x18 DebugInfo                   ( 00018669CEB0 ModelClassType DebugInfo DebugInfo DebugInfo Pointer )

            return value;
        }
    }
}
