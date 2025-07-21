using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 InitialSelectedIndex                     ModelPrimitiveType int int int Int32
    // 068 <OnCellLongClicked>k__BackingField       Action`2<int, GameObject> IL2CPP_TYPE_GENERICINST
    public partial class ProfilePIdolSelectGridContext : DataModel
    {
        public int                                      InitialSelectedIndex                    { get; set; }

        public static ProfilePIdolSelectGridContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolSelectGridContext() { Pointer= p0 };

            value.InitialSelectedIndex                      = GetInt32(new IntPtr(p + 0x060)); // 0x60 InitialSelectedIndex        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
