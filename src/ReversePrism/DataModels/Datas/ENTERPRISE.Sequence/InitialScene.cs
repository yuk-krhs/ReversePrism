using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scene                                    ModelPrimitiveType string string string String
    public partial class InitialScene : DataModel
    {
        public string                                   Scene                                   { get; set; }

        public static InitialScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitialScene() { Pointer= p0 };

            value.Scene                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Scene                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
