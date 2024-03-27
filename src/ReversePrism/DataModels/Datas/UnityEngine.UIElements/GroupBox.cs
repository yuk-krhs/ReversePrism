using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 3D8 M_TitleLabel                             000186774D80 ModelClassType Label Label Label Pointer
    public partial class GroupBox
    {
        public Label?                                   M_TitleLabel                            { get; set; }

        public static GroupBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupBox();

            value.M_TitleLabel                              = GetObject<Label>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.Label.FromPointer); // 027006712080 0x3D8 M_TitleLabel                ( 000186774D80 ModelClassType Label Label Label Pointer )

            return value;
        }
    }
}
