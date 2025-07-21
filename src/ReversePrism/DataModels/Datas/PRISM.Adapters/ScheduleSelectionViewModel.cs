using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Display3DColor                           ModelEnumType Color Color Color Int32
    // 020 NotDisplay3DColor                        ModelEnumType Color Color Color Int32
    // 030 ProduceBaseInfoViewModel                 ModelClassType ProduceBaseInfoViewModel ProduceBaseInfoViewModel ProduceBaseInfoViewModel Pointer
    // 038 WeekScheduleListViewModel                ModelClassType WeekScheduleListViewModel WeekScheduleListViewModel WeekScheduleListViewModel Pointer
    // 040 ScheduleSelectionUnitIdolViewModel       ModelClassType ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel Pointer
    // 048 ScheduleSelectionUnitParameterViewModel  ModelClassType ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel Pointer
    // 050 ScheduleSelectionLeftWeekViewModel       ModelClassType ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel Pointer
    // 058 ScheduleSelectionScheduleDisplayViewModel ModelClassType ScheduleSelectionScheduleDisplayViewModel ScheduleSelectionScheduleDisplayViewModel ScheduleSelectionScheduleDisplayViewModel Pointer
    // 060 ScheduleSelectionScheduleDetailViewModel ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer
    public partial class ScheduleSelectionViewModel : DataModel
    {
        public Color                                    Display3DColor                          { get; set; }
        public Color                                    NotDisplay3DColor                       { get; set; }
        public ProduceBaseInfoViewModel?                ProduceBaseInfoViewModel                { get; set; }
        public WeekScheduleListViewModel?               WeekScheduleListViewModel               { get; set; }
        public ScheduleSelectionUnitIdolViewModel?      ScheduleSelectionUnitIdolViewModel      { get; set; }
        public ScheduleSelectionLeftBottomAreaViewModel? ScheduleSelectionUnitParameterViewModel { get; set; }
        public ScheduleSelectionLeftWeekViewModel?      ScheduleSelectionLeftWeekViewModel      { get; set; }
        public ScheduleSelectionScheduleDisplayViewModel? ScheduleSelectionScheduleDisplayViewModel { get; set; }
        public ScheduleSelectionScheduleDetailViewModel? ScheduleSelectionScheduleDetailViewModel { get; set; }

        public static ScheduleSelectionViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionViewModel() { Pointer= p0 };

            value.Display3DColor                            = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 Display3DColor              ( ModelEnumType Color Color Color Int32 )
            value.NotDisplay3DColor                         = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 NotDisplay3DColor           ( ModelEnumType Color Color Color Int32 )
            value.ProduceBaseInfoViewModel                  = GetObject<ProduceBaseInfoViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceBaseInfoViewModel.FromPointer); // 0x30 ProduceBaseInfoViewModel    ( ModelClassType ProduceBaseInfoViewModel ProduceBaseInfoViewModel ProduceBaseInfoViewModel Pointer )
            value.WeekScheduleListViewModel                 = GetObject<WeekScheduleListViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.WeekScheduleListViewModel.FromPointer); // 0x38 WeekScheduleListViewModel   ( ModelClassType WeekScheduleListViewModel WeekScheduleListViewModel WeekScheduleListViewModel Pointer )
            value.ScheduleSelectionUnitIdolViewModel        = GetObject<ScheduleSelectionUnitIdolViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleSelectionUnitIdolViewModel.FromPointer); // 0x40 ScheduleSelectionUnitIdolViewModel ( ModelClassType ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel ScheduleSelectionUnitIdolViewModel Pointer )
            value.ScheduleSelectionUnitParameterViewModel   = GetObject<ScheduleSelectionLeftBottomAreaViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScheduleSelectionLeftBottomAreaViewModel.FromPointer); // 0x48 ScheduleSelectionUnitParameterViewModel ( ModelClassType ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel ScheduleSelectionLeftBottomAreaViewModel Pointer )
            value.ScheduleSelectionLeftWeekViewModel        = GetObject<ScheduleSelectionLeftWeekViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScheduleSelectionLeftWeekViewModel.FromPointer); // 0x50 ScheduleSelectionLeftWeekViewModel ( ModelClassType ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel ScheduleSelectionLeftWeekViewModel Pointer )
            value.ScheduleSelectionScheduleDisplayViewModel = GetObject<ScheduleSelectionScheduleDisplayViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScheduleSelectionScheduleDisplayViewModel.FromPointer); // 0x58 ScheduleSelectionScheduleDisplayViewModel ( ModelClassType ScheduleSelectionScheduleDisplayViewModel ScheduleSelectionScheduleDisplayViewModel ScheduleSelectionScheduleDisplayViewModel Pointer )
            value.ScheduleSelectionScheduleDetailViewModel  = GetObject<ScheduleSelectionScheduleDetailViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScheduleSelectionScheduleDetailViewModel.FromPointer); // 0x60 ScheduleSelectionScheduleDetailViewModel ( ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer )

            return value;
        }
    }
}
