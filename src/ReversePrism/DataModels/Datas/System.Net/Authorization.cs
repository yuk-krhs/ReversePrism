using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Message                                000186671910 ModelPrimitiveType string string string String
    // 018 M_Complete                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 ModuleAuthenticationType                 000186671BA0 ModelPrimitiveType string string string String
    public partial class Authorization : DataModel
    {
        public string                                   M_Message                               { get; set; }
        public bool                                     M_Complete                              { get; set; }
        public string                                   ModuleAuthenticationType                { get; set; }

        public static Authorization? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Authorization() { Pointer= p0 };

            value.M_Message                                 = GetString(new IntPtr(p + 0x010)); // 0246679A4088 0x10 M_Message                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Complete                                = GetBool(new IntPtr(p + 0x018)); // 0246679A40A8 0x18 M_Complete                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ModuleAuthenticationType                  = GetString(new IntPtr(p + 0x020)); // 0246679A40C8 0x20 ModuleAuthenticationType    ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
