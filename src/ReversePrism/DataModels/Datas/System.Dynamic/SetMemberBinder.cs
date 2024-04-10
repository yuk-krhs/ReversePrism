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
    public partial class SetMemberBinder : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     IgnoreCase                              { get; set; }

        public static SetMemberBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetMemberBinder() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0246687801C8 0x18 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.IgnoreCase                                = GetBool(new IntPtr(p + 0x020)); // 0246687801E8 0x20 IgnoreCase                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
