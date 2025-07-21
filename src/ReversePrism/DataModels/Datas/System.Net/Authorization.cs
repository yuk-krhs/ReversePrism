using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Message                                ModelPrimitiveType string string string String
    // 018 M_Complete                               ModelPrimitiveType bool bool bool Bool
    // 020 ModuleAuthenticationType                 ModelPrimitiveType string string string String
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

            value.M_Message                                 = GetString(new IntPtr(p + 0x010)); // 0x10 M_Message                   ( ModelPrimitiveType string string string String )
            value.M_Complete                                = GetBool(new IntPtr(p + 0x018)); // 0x18 M_Complete                  ( ModelPrimitiveType bool bool bool Bool )
            value.ModuleAuthenticationType                  = GetString(new IntPtr(p + 0x020)); // 0x20 ModuleAuthenticationType    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
