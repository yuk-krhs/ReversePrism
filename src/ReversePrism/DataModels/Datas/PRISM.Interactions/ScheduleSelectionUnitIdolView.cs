using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitIdolContentList                      ModelClassListType List`1<UnitIdolContent> List`1<UnitIdolContent> List<UnitIdolContent> Pointer
    // 028 ScheduleSelectionUnitIdolViewModel       ModelClassType ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel Pointer
    public partial class ScheduleSelectionUnitIdolView : DataModel
    {
        public List<UnitIdolContent>?                   UnitIdolContentList                     { get; set; }
        public ScheduleSelectionUnitIdolViewModel?      ScheduleSelectionUnitIdolViewModel      { get; set; }

        public static ScheduleSelectionUnitIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionUnitIdolView() { Pointer= p0 };

            value.UnitIdolContentList                       = GetObjectList<UnitIdolContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdolContent.FromPointer); // 0x20 UnitIdolContentList         ( ModelClassListType List`1<UnitIdolContent> List`1<UnitIdolContent> List<UnitIdolContent> Pointer )
            value.ScheduleSelectionUnitIdolViewModel        = GetObject<ScheduleSelectionUnitIdolViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleSelectionUnitIdolViewModel.FromPointer); // 0x28 ScheduleSelectionUnitIdolViewModel ( ModelClassType ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel Pointer )

            return value;
        }
    }
}
