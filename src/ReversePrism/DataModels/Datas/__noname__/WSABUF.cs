using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Len                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 buf                                      <int> IL2CPP_TYPE_I
    public partial class WSABUF
    {
        public int                                      Len                                     { get; set; }

        public static WSABUF? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WSABUF();

            value.Len                                       = GetInt32(new IntPtr(p + 0x010)); // 0270D7AE7E80 0x10 Len                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
