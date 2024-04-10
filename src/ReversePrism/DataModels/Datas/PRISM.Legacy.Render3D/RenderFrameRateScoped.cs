using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SavedFPS                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class RenderFrameRateScoped : DataModel
    {
        public int                                      SavedFPS                                { get; set; }

        public static RenderFrameRateScoped? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderFrameRateScoped() { Pointer= p0 };

            value.SavedFPS                                  = GetInt32(new IntPtr(p + 0x010)); // 024665EB13A0 0x10 SavedFPS                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
