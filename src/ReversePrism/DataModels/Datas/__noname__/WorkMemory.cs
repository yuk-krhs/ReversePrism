using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LightMappings                            ModelEnumListType LightCookieMapping[] LightCookieMapping[] List<LightCookieMapping> Pointer
    // 018 UvRects                                  ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    public partial class WorkMemory : DataModel
    {
        public List<LightCookieMapping>?                LightMappings                           { get; set; }
        public List<Vector4>?                           UvRects                                 { get; set; }

        public static WorkMemory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WorkMemory() { Pointer= p0 };

            value.LightMappings                             = GetEnumList<LightCookieMapping>(new IntPtr(p + 0x010)); // 0x10 LightMappings               ( ModelEnumListType LightCookieMapping[] LightCookieMapping[] List<LightCookieMapping> Pointer )
            value.UvRects                                   = GetEnumList<Vector4>(new IntPtr(p + 0x018)); // 0x18 UvRects                     ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )

            return value;
        }
    }
}
