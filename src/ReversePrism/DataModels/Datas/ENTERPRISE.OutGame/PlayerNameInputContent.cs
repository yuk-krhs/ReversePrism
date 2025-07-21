using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 IsChange                                 ModelPrimitiveType bool bool bool Bool
    // 0A0 InputString                              ModelPrimitiveType string string string String
    public partial class PlayerNameInputContent : DataModel
    {
        public bool                                     IsChange                                { get; set; }
        public string                                   InputString                             { get; set; }

        public static PlayerNameInputContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerNameInputContent() { Pointer= p0 };

            value.IsChange                                  = GetBool(new IntPtr(p + 0x098)); // 0x98 IsChange                    ( ModelPrimitiveType bool bool bool Bool )
            value.InputString                               = GetString(new IntPtr(p + 0x0A0)); // 0xA0 InputString                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
