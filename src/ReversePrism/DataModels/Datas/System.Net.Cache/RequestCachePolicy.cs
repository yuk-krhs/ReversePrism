using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Level                                  ModelEnumType RequestCacheLevel RequestCacheLevel RequestCacheLevel Int32
    public partial class RequestCachePolicy : DataModel
    {
        public RequestCacheLevel                        M_Level                                 { get; set; }

        public static RequestCachePolicy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestCachePolicy() { Pointer= p0 };

            value.M_Level                                   = (RequestCacheLevel)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Level                     ( ModelEnumType RequestCacheLevel RequestCacheLevel RequestCacheLevel Int32 )

            return value;
        }
    }
}
