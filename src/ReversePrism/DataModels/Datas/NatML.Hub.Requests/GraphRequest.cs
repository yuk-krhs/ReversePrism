using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Query                                    ModelPrimitiveType string string string String
    public partial class GraphRequest : DataModel
    {
        public string                                   Query                                   { get; set; }

        public static GraphRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphRequest() { Pointer= p0 };

            value.Query                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Query                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
