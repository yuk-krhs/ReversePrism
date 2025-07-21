using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSpecialMissionStepId                  ModelPrimitiveType int int int Int32
    // 018 LastDisplayDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 MissionList                              ModelClassListType IReadOnlyList`1<ISpecialMissionMissionStatus> IReadOnlyList`1<ISpecialMissionMissionStatus> List<ISpecialMissionMissionStatus> Pointer
    // 030 StepNumber                               ModelPrimitiveType int int int Int32
    // 034 ReceivableCount                          ModelPrimitiveType int int int Int32
    // 038 CompleteCount                            ModelPrimitiveType int int int Int32
    // 03C IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 040 RewardList                               ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 048 IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    // 04C State                                    ModelEnumType MissionState MissionState MissionState Int32
    public partial class SpecialMissionStep : DataModel
    {
        public int                                      MstSpecialMissionStepId                 { get; set; }
        public DateTime                                 LastDisplayDate                         { get; set; }
        public List<ISpecialMissionMissionStatus>?      MissionList                             { get; set; }
        public int                                      StepNumber                              { get; set; }
        public int                                      ReceivableCount                         { get; set; }
        public int                                      CompleteCount                           { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public List<IProductWithAmountStatus>?          RewardList                              { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public MissionState                             State                                   { get; set; }

        public static SpecialMissionStep? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionStep() { Pointer= p0 };

            value.MstSpecialMissionStepId                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSpecialMissionStepId     ( ModelPrimitiveType int int int Int32 )
            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x018)); // 0x18 LastDisplayDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MissionList                               = GetObjectList<ISpecialMissionMissionStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISpecialMissionMissionStatus.FromPointer); // 0x28 MissionList                 ( ModelClassListType IReadOnlyList`1<ISpecialMissionMissionStatus> IReadOnlyList`1<ISpecialMissionMissionStatus> List<ISpecialMissionMissionStatus> Pointer )
            value.StepNumber                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 StepNumber                  ( ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x034)); // 0x34 ReceivableCount             ( ModelPrimitiveType int int int Int32 )
            value.CompleteCount                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 CompleteCount               ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.RewardList                                = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x40 RewardList                  ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x048)); // 0x48 IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.State                                     = (MissionState)GetInt32(new IntPtr(p + 0x04C)); // 0x4C State                       ( ModelEnumType MissionState MissionState MissionState Int32 )

            return value;
        }
    }
}
