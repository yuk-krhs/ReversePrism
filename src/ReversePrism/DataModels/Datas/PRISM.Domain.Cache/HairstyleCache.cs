using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 hairstyleMap                             Dictionary`2<int, IHairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 018 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HairstyleCache
    {
        public bool                                     IsReady                                 { get; set; }

        public static HairstyleCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HairstyleCache();

            value.IsReady                                   = GetBool(new IntPtr(p + 0x018)); // 027004A87E78 0x18 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
