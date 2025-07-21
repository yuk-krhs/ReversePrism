using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SupportBonusRate                         float IL2CPP_TYPE_R4
    // 000 ScheduleSelectionTypeRate                float IL2CPP_TYPE_R4
    // 000 SystemTypeRate                           float IL2CPP_TYPE_R4
    // 000 LvRate                                   float IL2CPP_TYPE_R4
    // 010 ScheduleList                             ModelClassListType List`1<IScheduleStatus> List`1<IScheduleStatus> List<IScheduleStatus> Pointer
    // 018 Data                                     ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    // 020 DeleteCardNum                            ModelPrimitiveType int int int Int32
    // 028 Rnd                                      ModelClassType Random Random Random Pointer
    // 030 CalcDetalList                            ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer
    // 038 BestScheduleList                         ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer
    public partial class ScheduleSelectionAIModel : DataModel
    {
        public List<IScheduleStatus>?                   ScheduleList                            { get; set; }
        public ProduceAutoSettingModel?                 Data                                    { get; set; }
        public int                                      DeleteCardNum                           { get; set; }
        public Random?                                  Rnd                                     { get; set; }
        public List<IScheduleDetailStatus>?             CalcDetalList                           { get; set; }
        public List<IScheduleDetailStatus>?             BestScheduleList                        { get; set; }

        public static ScheduleSelectionAIModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionAIModel() { Pointer= p0 };

            value.ScheduleList                              = GetObjectList<IScheduleStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 0x10 ScheduleList                ( ModelClassListType List`1<IScheduleStatus> List`1<IScheduleStatus> List<IScheduleStatus> Pointer )
            value.Data                                      = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0x18 Data                        ( ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )
            value.DeleteCardNum                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 DeleteCardNum               ( ModelPrimitiveType int int int Int32 )
            value.Rnd                                       = GetObject<Random>(new IntPtr(p + 0x028), ReversePrism.DataModels.Random.FromPointer); // 0x28 Rnd                         ( ModelClassType Random Random Random Pointer )
            value.CalcDetalList                             = GetObjectList<IScheduleDetailStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IScheduleDetailStatus.FromPointer); // 0x30 CalcDetalList               ( ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer )
            value.BestScheduleList                          = GetObjectList<IScheduleDetailStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IScheduleDetailStatus.FromPointer); // 0x38 BestScheduleList            ( ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer )

            return value;
        }
    }
}
