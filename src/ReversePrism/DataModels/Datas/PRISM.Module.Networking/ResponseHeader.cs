using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResourceVersion                          000186672F10 ModelPrimitiveType string string string String
    // 018 ServerDate                               0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class ResponseHeader
    {
        public string                                   ResourceVersion                         { get; set; }
        public DateTime                                 ServerDate                              { get; set; }

        public static ResponseHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseHeader();

            value.ResourceVersion                           = GetString(new IntPtr(p + 0x010)); // 027004B35E90 0x10 ResourceVersion             ( 000186672F10 ModelPrimitiveType string string string String )
            value.ServerDate                                = GetDateTime(new IntPtr(p + 0x018)); // 027004B35EB0 0x18 ServerDate                  ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
