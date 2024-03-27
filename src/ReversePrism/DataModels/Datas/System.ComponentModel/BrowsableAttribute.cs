using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Yes                                      BrowsableAttribute IL2CPP_TYPE_CLASS
    // 008 No                                       BrowsableAttribute IL2CPP_TYPE_CLASS
    // 010 Default                                  000186775120 ModelClassType BrowsableAttribute BrowsableAttribute BrowsableAttribute Pointer
    // 010 Browsable                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class BrowsableAttribute
    {
        public BrowsableAttribute?                      Default                                 { get; set; }
        public bool                                     Browsable                               { get; set; }

        public static BrowsableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrowsableAttribute();

            value.Default                                   = GetObject<BrowsableAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.BrowsableAttribute.FromPointer); // 0270D7B13268 0x10 Default                     ( 000186775120 ModelClassType BrowsableAttribute BrowsableAttribute BrowsableAttribute Pointer )
            value.Browsable                                 = GetBool(new IntPtr(p + 0x010)); // 0270D7B13288 0x10 Browsable                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
