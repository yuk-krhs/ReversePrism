using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Visible                                  ModelPrimitiveType bool bool bool Bool
    // 000 Yes                                      DesignTimeVisibleAttribute IL2CPP_TYPE_CLASS
    // 008 No                                       DesignTimeVisibleAttribute IL2CPP_TYPE_CLASS
    // 010 Default                                  ModelClassType DesignTimeVisibleAttribute DesignTimeVisibleAttribute DesignTimeVisibleAttribute Pointer
    public partial class DesignTimeVisibleAttribute : DataModel
    {
        public bool                                     Visible                                 { get; set; }
        public DesignTimeVisibleAttribute?              Default                                 { get; set; }

        public static DesignTimeVisibleAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DesignTimeVisibleAttribute() { Pointer= p0 };

            value.Visible                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 Visible                     ( ModelPrimitiveType bool bool bool Bool )
            value.Default                                   = GetObject<DesignTimeVisibleAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.DesignTimeVisibleAttribute.FromPointer); // 0x10 Default                     ( ModelClassType DesignTimeVisibleAttribute DesignTimeVisibleAttribute DesignTimeVisibleAttribute Pointer )

            return value;
        }
    }
}
