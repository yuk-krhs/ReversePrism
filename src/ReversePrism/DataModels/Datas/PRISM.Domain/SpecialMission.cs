using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSpecialMissionId                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Period                                   0001865D4000 ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer
    // 020 ReceiveEndDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 StepList                                 000185D166B8 ModelClassListType IReadOnlyList`1<SpecialMissionStep> IReadOnlyList`1<SpecialMissionStep> List<SpecialMissionStep> Pointer
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

            value.MstSpecialMissionId                       = GetInt32(new IntPtr(p + 0x010)); // 02466568FB98 0x10 MstSpecialMissionId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Period                                    = GetObject<IPeriodStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPeriodStatus.FromPointer); // 02466568FBB8 0x18 Period                      ( 0001865D4000 ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x020)); // 02466568FBD8 0x20 ReceiveEndDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.StepList                                  = GetObjectList<SpecialMissionStep>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpecialMissionStep.FromPointer); // 02466568FBF8 0x30 StepList                    ( 000185D166B8 ModelClassListType IReadOnlyList`1<SpecialMissionStep> IReadOnlyList`1<SpecialMissionStep> List<SpecialMissionStep> Pointer )

            return value;
        }
    }
}
