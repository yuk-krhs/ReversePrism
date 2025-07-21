using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSpecialMissionId                      ModelPrimitiveType int int int Int32
    // 018 Period                                   ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer
    // 020 ReceiveEndDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 StepList                                 ModelClassListType IReadOnlyList`1<SpecialMissionStep> IReadOnlyList`1<SpecialMissionStep> List<SpecialMissionStep> Pointer
    public partial class SpecialMission : DataModel
    {
        public int                                      MstSpecialMissionId                     { get; set; }
        public IPeriodStatus?                           Period                                  { get; set; }
        public DateTime                                 ReceiveEndDate                          { get; set; }
        public List<SpecialMissionStep>?                StepList                                { get; set; }

        public static SpecialMission? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMission() { Pointer= p0 };

            value.MstSpecialMissionId                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSpecialMissionId         ( ModelPrimitiveType int int int Int32 )
            value.Period                                    = GetObject<IPeriodStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPeriodStatus.FromPointer); // 0x18 Period                      ( ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ReceiveEndDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.StepList                                  = GetObjectList<SpecialMissionStep>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpecialMissionStep.FromPointer); // 0x30 StepList                    ( ModelClassListType IReadOnlyList`1<SpecialMissionStep> IReadOnlyList`1<SpecialMissionStep> List<SpecialMissionStep> Pointer )

            return value;
        }
    }
}
