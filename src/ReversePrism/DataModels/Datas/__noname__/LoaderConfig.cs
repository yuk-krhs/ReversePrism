using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShouldLoadAwbOnMemory                    ModelPrimitiveType bool bool bool Bool
    public partial class LoaderConfig : DataModel
    {
        public bool                                     ShouldLoadAwbOnMemory                   { get; set; }

        public static LoaderConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoaderConfig() { Pointer= p0 };

            value.ShouldLoadAwbOnMemory                     = GetBool(new IntPtr(p + 0x010)); // 0x10 ShouldLoadAwbOnMemory       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
