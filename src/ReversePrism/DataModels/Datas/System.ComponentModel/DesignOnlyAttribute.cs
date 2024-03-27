using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDesignOnly                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 000 Yes                                      DesignOnlyAttribute IL2CPP_TYPE_CLASS
    // 008 No                                       DesignOnlyAttribute IL2CPP_TYPE_CLASS
    // 010 Default                                  0001866C6F20 ModelClassType DesignOnlyAttribute DesignOnlyAttribute DesignOnlyAttribute Pointer
    public partial class DesignOnlyAttribute
    {
        public bool                                     IsDesignOnly                            { get; set; }
        public DesignOnlyAttribute?                     Default                                 { get; set; }

        public static DesignOnlyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DesignOnlyAttribute();

            value.IsDesignOnly                              = GetBool(new IntPtr(p + 0x010)); // 0270D7B13A00 0x10 IsDesignOnly                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Default                                   = GetObject<DesignOnlyAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.DesignOnlyAttribute.FromPointer); // 0270D7B13A60 0x10 Default                     ( 0001866C6F20 ModelClassType DesignOnlyAttribute DesignOnlyAttribute DesignOnlyAttribute Pointer )

            return value;
        }
    }
}
