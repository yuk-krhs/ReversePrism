using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleSelectionView                    0001866E22A0 ModelClassType ScheduleSelectionView ScheduleSelectionView ScheduleSelectionView Pointer
    // 028 PIdolDetailPopupViewFactory              00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer
    public partial class ScheduleSelectionBuilder
    {
        public ScheduleSelectionView?                   ScheduleSelectionView                   { get; set; }
        public PIdolDetailPopupViewFactory?             PIdolDetailPopupViewFactory             { get; set; }

        public static ScheduleSelectionBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionBuilder();

            value.ScheduleSelectionView                     = GetObject<ScheduleSelectionView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleSelectionView.FromPointer); // 0270DB61F408 0x20 ScheduleSelectionView       ( 0001866E22A0 ModelClassType ScheduleSelectionView ScheduleSelectionView ScheduleSelectionView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<PIdolDetailPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.PIdolDetailPopupViewFactory.FromPointer); // 0270DB61F428 0x28 PIdolDetailPopupViewFactory ( 00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
