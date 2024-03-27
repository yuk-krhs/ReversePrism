using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           ulong IL2CPP_TYPE_U8
    // 050 Values                                   000185B84460 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    public partial class UInt64Storage
    {
        public List<ulong>?                             Values                                  { get; set; }

        public static UInt64Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt64Storage();

            value.Values                                    = GetUInt64List(new IntPtr(p + 0x050)); // 0270D8A06630 0x50 Values                      ( 000185B84460 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )

            return value;
        }
    }
}
