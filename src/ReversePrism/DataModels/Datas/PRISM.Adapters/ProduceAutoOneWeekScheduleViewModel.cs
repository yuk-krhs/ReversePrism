using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsExecuted                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 IsFailure                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 ScheduleType                             0001866160F0 ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 018 ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IsSupportBonus                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 SupportCharacterIcons                    000185D0D568 ModelClassListType IReadOnlyList`1<ISupportCharacterIconStatus> IReadOnlyList`1<ISupportCharacterIconStatus> List<ISupportCharacterIconStatus> Pointer
    // 028 IsRecommend                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C Season                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceAutoOneWeekScheduleViewModel : DataModel
    {
        public bool                                     IsExecuted                              { get; set; }
        public bool                                     IsFailure                               { get; set; }
        public ScheduleType                             ScheduleType                            { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public List<ISupportCharacterIconStatus>?       SupportCharacterIcons                   { get; set; }
        public bool                                     IsRecommend                             { get; set; }
        public int                                      Season                                  { get; set; }

        public static ProduceAutoOneWeekScheduleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneWeekScheduleViewModel() { Pointer= p0 };

            value.IsExecuted                                = GetBool(new IntPtr(p + 0x010)); // 0246664BB598 0x10 IsExecuted                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFailure                                 = GetBool(new IntPtr(p + 0x011)); // 0246664BB5B8 0x11 IsFailure                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x014)); // 0246664BB5D8 0x14 ScheduleType                ( 0001866160F0 ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0246664BB5F8 0x18 ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x01C)); // 0246664BB618 0x1C IsSupportBonus              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SupportCharacterIcons                     = GetObjectList<ISupportCharacterIconStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterIconStatus.FromPointer); // 0246664BB638 0x20 SupportCharacterIcons       ( 000185D0D568 ModelClassListType IReadOnlyList`1<ISupportCharacterIconStatus> IReadOnlyList`1<ISupportCharacterIconStatus> List<ISupportCharacterIconStatus> Pointer )
            value.IsRecommend                               = GetBool(new IntPtr(p + 0x028)); // 0246664BB658 0x28 IsRecommend                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Season                                    = GetInt32(new IntPtr(p + 0x02C)); // 0246664BB678 0x2C Season                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
