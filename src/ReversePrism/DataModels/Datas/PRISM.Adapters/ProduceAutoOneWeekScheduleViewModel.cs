using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsExecuted                               ModelPrimitiveType bool bool bool Bool
    // 011 IsFailure                                ModelPrimitiveType bool bool bool Bool
    // 014 ScheduleType                             ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 018 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 01C IsSupportBonus                           ModelPrimitiveType bool bool bool Bool
    // 020 SupportCharacterIcons                    ModelClassListType IReadOnlyList`1<ISupportCharacterIconStatus> IReadOnlyList`1<ISupportCharacterIconStatus> List<ISupportCharacterIconStatus> Pointer
    // 028 IsAppearance                             ModelPrimitiveType bool bool bool Bool
    // 029 IsRecommend                              ModelPrimitiveType bool bool bool Bool
    // 02C Season                                   ModelPrimitiveType int int int Int32
    public partial class ProduceAutoOneWeekScheduleViewModel : DataModel
    {
        public bool                                     IsExecuted                              { get; set; }
        public bool                                     IsFailure                               { get; set; }
        public ScheduleType                             ScheduleType                            { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public List<ISupportCharacterIconStatus>?       SupportCharacterIcons                   { get; set; }
        public bool                                     IsAppearance                            { get; set; }
        public bool                                     IsRecommend                             { get; set; }
        public int                                      Season                                  { get; set; }

        public static ProduceAutoOneWeekScheduleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneWeekScheduleViewModel() { Pointer= p0 };

            value.IsExecuted                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsExecuted                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsFailure                                 = GetBool(new IntPtr(p + 0x011)); // 0x11 IsFailure                   ( ModelPrimitiveType bool bool bool Bool )
            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ScheduleType                ( ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsSupportBonus              ( ModelPrimitiveType bool bool bool Bool )
            value.SupportCharacterIcons                     = GetObjectList<ISupportCharacterIconStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterIconStatus.FromPointer); // 0x20 SupportCharacterIcons       ( ModelClassListType IReadOnlyList`1<ISupportCharacterIconStatus> IReadOnlyList`1<ISupportCharacterIconStatus> List<ISupportCharacterIconStatus> Pointer )
            value.IsAppearance                              = GetBool(new IntPtr(p + 0x028)); // 0x28 IsAppearance                ( ModelPrimitiveType bool bool bool Bool )
            value.IsRecommend                               = GetBool(new IntPtr(p + 0x029)); // 0x29 IsRecommend                 ( ModelPrimitiveType bool bool bool Bool )
            value.Season                                    = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Season                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
