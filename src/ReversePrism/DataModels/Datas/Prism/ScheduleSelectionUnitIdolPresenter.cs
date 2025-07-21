using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer
    public partial class ScheduleSelectionUnitIdolPresenter : DataModel
    {
        public IScheduleSelectionUnitIdolView?          View                                    { get; set; }

        public static ScheduleSelectionUnitIdolPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionUnitIdolPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IScheduleSelectionUnitIdolView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduleSelectionUnitIdolView.FromPointer); // 0x10 View                        ( ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer )

            return value;
        }
    }
}
