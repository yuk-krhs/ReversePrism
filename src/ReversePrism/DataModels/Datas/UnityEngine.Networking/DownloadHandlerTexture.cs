using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 m_NativeData                             NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 028 MNonReadable                             ModelPrimitiveType bool bool bool Bool
    public partial class DownloadHandlerTexture : DataModel
    {
        public bool                                     MNonReadable                            { get; set; }

        public static DownloadHandlerTexture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DownloadHandlerTexture() { Pointer= p0 };

            value.MNonReadable                              = GetBool(new IntPtr(p + 0x028)); // 0x28 MNonReadable                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
