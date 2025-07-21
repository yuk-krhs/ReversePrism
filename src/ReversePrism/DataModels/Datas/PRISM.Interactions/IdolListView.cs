using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LabelTabGroupView                        ModelClassType LabelTabGroupView LabelTabGroupView LabelTabGroupView Pointer
    // 028 CurrentTabTye                            ModelEnumType IdolListTabType IdolListTabType IdolListTabType Int32
    // 030 switchDisplay                            Subject`1<IdolListTabType> IL2CPP_TYPE_GENERICINST
    public partial class IdolListView : DataModel
    {
        public LabelTabGroupView?                       LabelTabGroupView                       { get; set; }
        public IdolListTabType                          CurrentTabTye                           { get; set; }

        public static IdolListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListView() { Pointer= p0 };

            value.LabelTabGroupView                         = GetObject<LabelTabGroupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LabelTabGroupView.FromPointer); // 0x20 LabelTabGroupView           ( ModelClassType LabelTabGroupView LabelTabGroupView LabelTabGroupView Pointer )
            value.CurrentTabTye                             = (IdolListTabType)GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentTabTye               ( ModelEnumType IdolListTabType IdolListTabType IdolListTabType Int32 )

            return value;
        }
    }
}
