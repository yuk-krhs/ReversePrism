using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    ModelPrimitiveType string string string String
    // 018 <CellViewModels>k__BackingField          IEnumerable`1<AdvTextLogTalkCellViewModel> IL2CPP_TYPE_GENERICINST
    public partial class AdvTextLogOverlayViewModel : DataModel
    {
        public string                                   Title                                   { get; set; }

        public static AdvTextLogOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvTextLogOverlayViewModel() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Title                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
