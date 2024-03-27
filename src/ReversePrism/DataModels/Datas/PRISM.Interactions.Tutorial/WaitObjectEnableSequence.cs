using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectName                               000186671910 ModelPrimitiveType string string string String
    // 018 Exists                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WaitObjectEnableSequence
    {
        public string                                   ObjectName                              { get; set; }
        public bool                                     Exists                                  { get; set; }

        public static WaitObjectEnableSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitObjectEnableSequence();

            value.ObjectName                                = GetString(new IntPtr(p + 0x010)); // 0270DBC126E8 0x10 ObjectName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Exists                                    = GetBool(new IntPtr(p + 0x018)); // 0270DBC12708 0x18 Exists                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
