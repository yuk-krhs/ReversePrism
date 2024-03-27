using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Yes                                      ReadOnlyAttribute IL2CPP_TYPE_CLASS
    // 008 No                                       ReadOnlyAttribute IL2CPP_TYPE_CLASS
    // 010 Default                                  000186618DB0 ModelClassType ReadOnlyAttribute ReadOnlyAttribute ReadOnlyAttribute Pointer
    // 010 IsReadOnly                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ReadOnlyAttribute
    {
        public ReadOnlyAttribute?                       Default                                 { get; set; }
        public bool                                     IsReadOnly                              { get; set; }

        public static ReadOnlyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadOnlyAttribute();

            value.Default                                   = GetObject<ReadOnlyAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.ReadOnlyAttribute.FromPointer); // 0270D7B14928 0x10 Default                     ( 000186618DB0 ModelClassType ReadOnlyAttribute ReadOnlyAttribute ReadOnlyAttribute Pointer )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x010)); // 0270D7B14948 0x10 IsReadOnly                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
