using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 AssetTag                                 ModelPrimitiveType string string string String
    public partial class SelectablePCardContext : DataModel
    {
        public string                                   AssetTag                                { get; set; }

        public static SelectablePCardContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectablePCardContext() { Pointer= p0 };

            value.AssetTag                                  = GetString(new IntPtr(p + 0x060)); // 0x60 AssetTag                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
