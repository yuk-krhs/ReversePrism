using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PropertyName                             000186672F10 ModelPrimitiveType string string string String
    // 018 ReceiverTypeName                         000186672F10 ModelPrimitiveType string string string String
    public partial class ProvidePropertyAttribute : DataModel
    {
        public string                                   PropertyName                            { get; set; }
        public string                                   ReceiverTypeName                        { get; set; }

        public static ProvidePropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProvidePropertyAttribute() { Pointer= p0 };

            value.PropertyName                              = GetString(new IntPtr(p + 0x010)); // 024667BA0E68 0x10 PropertyName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.ReceiverTypeName                          = GetString(new IntPtr(p + 0x018)); // 024667BA0E88 0x18 ReceiverTypeName            ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
