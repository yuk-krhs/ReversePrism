using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MenuKind                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class MenuParameter : DataModel
    {
        public string                                   MenuKind                                { get; set; }

        public static MenuParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MenuParameter() { Pointer= p0 };

            value.MenuKind                                  = GetString(new IntPtr(p + 0x010)); // 02466B535730 0x10 MenuKind                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
