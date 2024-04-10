using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Visible                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 000 Yes                                      DesignTimeVisibleAttribute IL2CPP_TYPE_CLASS
    // 008 No                                       DesignTimeVisibleAttribute IL2CPP_TYPE_CLASS
    // 010 Default                                  0001866C7420 ModelClassType DesignTimeVisibleAttribute DesignTimeVisibleAttribute DesignTimeVisibleAttribute Pointer
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

            value.Visible                                   = GetBool(new IntPtr(p + 0x010)); // 024667B83CD0 0x10 Visible                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Default                                   = GetObject<DesignTimeVisibleAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.DesignTimeVisibleAttribute.FromPointer); // 024667B83D30 0x10 Default                     ( 0001866C7420 ModelClassType DesignTimeVisibleAttribute DesignTimeVisibleAttribute DesignTimeVisibleAttribute Pointer )

            return value;
        }
    }
}
