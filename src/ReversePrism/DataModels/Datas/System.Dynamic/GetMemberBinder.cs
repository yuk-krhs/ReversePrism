using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 020 IgnoreCase                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class GetMemberBinder : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     IgnoreCase                              { get; set; }

        public static GetMemberBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetMemberBinder() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466877F7C0 0x18 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.IgnoreCase                                = GetBool(new IntPtr(p + 0x020)); // 02466877F7E0 0x20 IgnoreCase                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
