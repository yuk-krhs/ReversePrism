using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Panel                                  000186745F20 ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer
    // 018 M_UpdaterArray                           0001866FEB40 ModelClassType UpdaterArray UpdaterArray UpdaterArray Pointer
    public partial class VisualTreeUpdater : DataModel
    {
        public BaseVisualElementPanel?                  M_Panel                                 { get; set; }
        public UpdaterArray?                            M_UpdaterArray                          { get; set; }

        public static VisualTreeUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualTreeUpdater() { Pointer= p0 };

            value.M_Panel                                   = GetObject<BaseVisualElementPanel>(new IntPtr(p + 0x010), ReversePrism.DataModels.BaseVisualElementPanel.FromPointer); // 0245A6820BD0 0x10 M_Panel                     ( 000186745F20 ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer )
            value.M_UpdaterArray                            = GetObject<UpdaterArray>(new IntPtr(p + 0x018), ReversePrism.DataModels.UpdaterArray.FromPointer); // 0245A6820BF0 0x18 M_UpdaterArray              ( 0001866FEB40 ModelClassType UpdaterArray UpdaterArray UpdaterArray Pointer )

            return value;
        }
    }
}
