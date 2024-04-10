using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitIdolContentList                      000185D19C88 ModelClassListType List`1<UnitIdolContent> List`1<UnitIdolContent> List<UnitIdolContent> Pointer
    // 028 ScheduleSelectionUnitIdolViewModel       0001866E1B50 ModelClassType ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel Pointer
    // 030 PIdolDetailPopupViewFactory              0001865CFB80 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    public partial class ScheduleSelectionUnitIdolView : DataModel
    {
        public List<UnitIdolContent>?                   UnitIdolContentList                     { get; set; }
        public ScheduleSelectionUnitIdolViewModel?      ScheduleSelectionUnitIdolViewModel      { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }

        public static ScheduleSelectionUnitIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionUnitIdolView() { Pointer= p0 };

            value.UnitIdolContentList                       = GetObjectList<UnitIdolContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdolContent.FromPointer); // 02466A1E8DE0 0x20 UnitIdolContentList         ( 000185D19C88 ModelClassListType List`1<UnitIdolContent> List`1<UnitIdolContent> List<UnitIdolContent> Pointer )
            value.ScheduleSelectionUnitIdolViewModel        = GetObject<ScheduleSelectionUnitIdolViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleSelectionUnitIdolViewModel.FromPointer); // 02466A1E8E00 0x28 ScheduleSelectionUnitIdolViewModel ( 0001866E1B50 ModelClassType ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 02466A1E8E20 0x30 PIdolDetailPopupViewFactory ( 0001865CFB80 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
