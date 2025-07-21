using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResourceVersion                          ModelPrimitiveType string string string String
    // 018 ServerDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class ResponseHeader : DataModel
    {
        public string                                   ResourceVersion                         { get; set; }
        public DateTime                                 ServerDate                              { get; set; }

        public static ResponseHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseHeader() { Pointer= p0 };

            value.ResourceVersion                           = GetString(new IntPtr(p + 0x010)); // 0x10 ResourceVersion             ( ModelPrimitiveType string string string String )
            value.ServerDate                                = GetDateTime(new IntPtr(p + 0x018)); // 0x18 ServerDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
