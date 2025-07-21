using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 IgnoreCase                               ModelPrimitiveType bool bool bool Bool
    public partial class InvokeMemberBinder : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     IgnoreCase                              { get; set; }

        public static InvokeMemberBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvokeMemberBinder() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.IgnoreCase                                = GetBool(new IntPtr(p + 0x020)); // 0x20 IgnoreCase                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
