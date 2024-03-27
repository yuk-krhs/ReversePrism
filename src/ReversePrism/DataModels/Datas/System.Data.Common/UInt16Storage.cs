using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           ushort IL2CPP_TYPE_U2
    // 050 Values                                   000185CAEB28 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    public partial class UInt16Storage
    {
        public List<ushort>?                            Values                                  { get; set; }

        public static UInt16Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt16Storage();

            value.Values                                    = GetUInt16List(new IntPtr(p + 0x050)); // 0270D8A059C0 0x50 Values                      ( 000185CAEB28 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )

            return value;
        }
    }
}
