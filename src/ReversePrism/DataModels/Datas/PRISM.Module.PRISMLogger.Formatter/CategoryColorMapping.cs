using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Md5                                      ModelClassType MD5 MD5 MD5 Pointer
    // 018 categoryMap                              Dictionary`2<Category, string> IL2CPP_TYPE_GENERICINST
    public partial class CategoryColorMapping : DataModel
    {
        public MD5?                                     Md5                                     { get; set; }

        public static CategoryColorMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CategoryColorMapping() { Pointer= p0 };

            value.Md5                                       = GetObject<MD5>(new IntPtr(p + 0x010), ReversePrism.DataModels.MD5.FromPointer); // 0x10 Md5                         ( ModelClassType MD5 MD5 MD5 Pointer )

            return value;
        }
    }
}
