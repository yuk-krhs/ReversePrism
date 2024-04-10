using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RequestTimeoutInSeconds                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 RedirectLimit                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class HttpOptions : DataModel
    {
        public int                                      RequestTimeoutInSeconds                 { get; set; }
        public int                                      RedirectLimit                           { get; set; }

        public static HttpOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpOptions() { Pointer= p0 };

            value.RequestTimeoutInSeconds                   = GetInt32(new IntPtr(p + 0x010)); // 02466BAE3868 0x10 RequestTimeoutInSeconds     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RedirectLimit                             = GetInt32(new IntPtr(p + 0x014)); // 02466BAE3888 0x14 RedirectLimit               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
