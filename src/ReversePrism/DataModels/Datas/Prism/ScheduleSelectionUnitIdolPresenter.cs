using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186627280 ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer
    // 018 PIdolDetailPopupViewFactory              0001865CFB80 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    public partial class ScheduleSelectionUnitIdolPresenter : DataModel
    {
        public IScheduleSelectionUnitIdolView?          View                                    { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }

        public static ScheduleSelectionUnitIdolPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionUnitIdolPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IScheduleSelectionUnitIdolView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduleSelectionUnitIdolView.FromPointer); // 024665EB2D38 0x10 View                        ( 000186627280 ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 024665EB2D58 0x18 PIdolDetailPopupViewFactory ( 0001865CFB80 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
