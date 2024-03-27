using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Format                                   000186672F10 ModelPrimitiveType string string string String
    // 018 _arguments                               <object>[] IL2CPP_TYPE_SZARRAY
    public partial class ConcreteFormattableString
    {
        public string                                   Format                                  { get; set; }

        public static ConcreteFormattableString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConcreteFormattableString();

            value.Format                                    = GetString(new IntPtr(p + 0x010)); // 0270D6CA6FA8 0x10 Format                      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
