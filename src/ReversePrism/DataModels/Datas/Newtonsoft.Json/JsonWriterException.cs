using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Path                                     000186672F10 ModelPrimitiveType string string string String
    public partial class JsonWriterException
    {
        public string                                   Path                                    { get; set; }

        public static JsonWriterException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonWriterException();

            value.Path                                      = GetString(new IntPtr(p + 0x090)); // 0270D86E8CE8 0x90 Path                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
