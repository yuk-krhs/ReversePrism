using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleList                             000185CE86C8 ModelClassListType List`1<IScheduleStatus> List`1<IScheduleStatus> List<IScheduleStatus> Pointer
    // 018 Data                                     000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    // 020 DeleteCardNum                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Rnd                                      0001866093D0 ModelClassType Random Random Random Pointer
    // 030 CalcDetalList                            000185CE8228 ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer
    public partial class ScheduleSelectionAIModel : DataModel
    {
        public List<IScheduleStatus>?                   ScheduleList                            { get; set; }
        public ProduceAutoSettingModel?                 Data                                    { get; set; }
        public int                                      DeleteCardNum                           { get; set; }
        public Random?                                  Rnd                                     { get; set; }
        public List<IScheduleDetailStatus>?             CalcDetalList                           { get; set; }

        public static ScheduleSelectionAIModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionAIModel() { Pointer= p0 };

            value.ScheduleList                              = GetObjectList<IScheduleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 0246664C6EE0 0x10 ScheduleList                ( 000185CE86C8 ModelClassListType List`1<IScheduleStatus> List`1<IScheduleStatus> List<IScheduleStatus> Pointer )
            value.Data                                      = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0246664C6F00 0x18 Data                        ( 000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )
            value.DeleteCardNum                             = GetInt32(new IntPtr(p + 0x020)); // 0246664C6F20 0x20 DeleteCardNum               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rnd                                       = GetObject<Random>(new IntPtr(p + 0x028), ReversePrism.DataModels.Random.FromPointer); // 0246664C6F40 0x28 Rnd                         ( 0001866093D0 ModelClassType Random Random Random Pointer )
            value.CalcDetalList                             = GetObjectList<IScheduleDetailStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IScheduleDetailStatus.FromPointer); // 0246664C6F60 0x30 CalcDetalList               ( 000185CE8228 ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer )

            return value;
        }
    }
}
