using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleViewModels                       000185CFB788 ModelClassListType List`1<ProduceAutoOneWeekScheduleViewModel> List`1<ProduceAutoOneWeekScheduleViewModel> List<ProduceAutoOneWeekScheduleViewModel> Pointer
    // 018 Season                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 01C SubSeasonID                              0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ProduceAutoOneSeasonViewModel : DataModel
    {
        public List<ProduceAutoOneWeekScheduleViewModel>? ScheduleViewModels                      { get; set; }
        public int                                      Season                                  { get; set; }
        public int                                      SubSeasonID                             { get; set; }

        public static ProduceAutoOneSeasonViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneSeasonViewModel() { Pointer= p0 };

            value.ScheduleViewModels                        = GetObjectList<ProduceAutoOneWeekScheduleViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceAutoOneWeekScheduleViewModel.FromPointer); // 0246664B8900 0x10 ScheduleViewModels          ( 000185CFB788 ModelClassListType List`1<ProduceAutoOneWeekScheduleViewModel> List`1<ProduceAutoOneWeekScheduleViewModel> List<ProduceAutoOneWeekScheduleViewModel> Pointer )
            value.Season                                    = GetInt32(new IntPtr(p + 0x018)); // 0246664B8920 0x18 Season                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.SubSeasonID                               = GetInt32(new IntPtr(p + 0x01C)); // 0246664B8940 0x1C SubSeasonID                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
