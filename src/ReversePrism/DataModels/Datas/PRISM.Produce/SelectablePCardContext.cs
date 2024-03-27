using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 AssetTag                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class SelectablePCardContext
    {
        public string                                   AssetTag                                { get; set; }

        public static SelectablePCardContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectablePCardContext();

            value.AssetTag                                  = GetString(new IntPtr(p + 0x058)); // 0270D5CBCFA8 0x58 AssetTag                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
