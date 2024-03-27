using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelectedIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 <OnCellClicked>k__BackingField           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 030 <OnCellLongPressed>k__BackingField       Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CommonListViewContext
    {
        public int                                      SelectedIndex                           { get; set; }

        public static CommonListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonListViewContext();

            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x020)); // 027004F748E0 0x20 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
