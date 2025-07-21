using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 SelectedIndex                            ModelPrimitiveType int int int Int32
    // 050 <OnCellClicked>k__BackingField           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 058 <OnCellLongPressed>k__BackingField       Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CommonGridViewContext : DataModel
    {
        public int                                      SelectedIndex                           { get; set; }

        public static CommonGridViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonGridViewContext() { Pointer= p0 };

            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x048)); // 0x48 SelectedIndex               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
