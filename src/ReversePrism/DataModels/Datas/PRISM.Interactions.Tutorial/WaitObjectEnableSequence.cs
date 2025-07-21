using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectName                               ModelPrimitiveType string string string String
    // 018 Exists                                   ModelPrimitiveType bool bool bool Bool
    public partial class WaitObjectEnableSequence : DataModel
    {
        public string                                   ObjectName                              { get; set; }
        public bool                                     Exists                                  { get; set; }

        public static WaitObjectEnableSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitObjectEnableSequence() { Pointer= p0 };

            value.ObjectName                                = GetString(new IntPtr(p + 0x010)); // 0x10 ObjectName                  ( ModelPrimitiveType string string string String )
            value.Exists                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 Exists                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
