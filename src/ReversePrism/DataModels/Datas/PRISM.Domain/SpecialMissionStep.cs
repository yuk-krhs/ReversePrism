using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSpecialMissionStepId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 LastDisplayDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 MissionList                              000185D0BB08 ModelClassListType IReadOnlyList`1<ISpecialMissionMissionStatus> IReadOnlyList`1<ISpecialMissionMissionStatus> List<ISpecialMissionMissionStatus> Pointer
    // 030 StepNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 ReceivableCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 CompleteCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 RewardList                               000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 048 IsUnlocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C State                                    000186606520 ModelEnumType MissionState MissionState MissionState Int32
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

            value.MstSpecialMissionStepId                   = GetInt32(new IntPtr(p + 0x010)); // 0246656909A0 0x10 MstSpecialMissionStepId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x018)); // 0246656909C0 0x18 LastDisplayDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MissionList                               = GetObjectList<ISpecialMissionMissionStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISpecialMissionMissionStatus.FromPointer); // 0246656909E0 0x28 MissionList                 ( 000185D0BB08 ModelClassListType IReadOnlyList`1<ISpecialMissionMissionStatus> IReadOnlyList`1<ISpecialMissionMissionStatus> List<ISpecialMissionMissionStatus> Pointer )
            value.StepNumber                                = GetInt32(new IntPtr(p + 0x030)); // 024665690A00 0x30 StepNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x034)); // 024665690A20 0x34 ReceivableCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CompleteCount                             = GetInt32(new IntPtr(p + 0x038)); // 024665690A40 0x38 CompleteCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x03C)); // 024665690A60 0x3C IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RewardList                                = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024665690A80 0x40 RewardList                  ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x048)); // 024665690AA0 0x48 IsUnlocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.State                                     = (MissionState)GetInt32(new IntPtr(p + 0x04C)); // 024665690AC0 0x4C State                       ( 000186606520 ModelEnumType MissionState MissionState MissionState Int32 )

            return value;
        }
    }
}
