using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PropertyName                             000186672F10 ModelPrimitiveType string string string String
    public partial class PropertyChangedEventArgs
    {
        public string                                   PropertyName                            { get; set; }

        public static PropertyChangedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyChangedEventArgs();

            value.PropertyName                              = GetString(new IntPtr(p + 0x010)); // 0270D7B3AE78 0x10 PropertyName                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
