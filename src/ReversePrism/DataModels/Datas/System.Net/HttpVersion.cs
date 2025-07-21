using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Unknown                                  Version IL2CPP_TYPE_CLASS
    // 008 Version10                                Version IL2CPP_TYPE_CLASS
    // 010 Version11                                ModelClassType Version Version Version Pointer
    // 018 Version20                                ModelClassType Version Version Version Pointer
    public partial class HttpVersion : DataModel
    {
        public Version?                                 Version11                               { get; set; }
        public Version?                                 Version20                               { get; set; }

        public static HttpVersion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpVersion() { Pointer= p0 };

            value.Version11                                 = GetObject<Version>(new IntPtr(p + 0x010), ReversePrism.DataModels.Version.FromPointer); // 0x10 Version11                   ( ModelClassType Version Version Version Pointer )
            value.Version20                                 = GetObject<Version>(new IntPtr(p + 0x018), ReversePrism.DataModels.Version.FromPointer); // 0x18 Version20                   ( ModelClassType Version Version Version Pointer )

            return value;
        }
    }
}
