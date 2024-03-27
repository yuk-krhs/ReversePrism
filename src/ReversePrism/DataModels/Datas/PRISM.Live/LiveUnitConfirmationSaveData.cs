using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 IsAutoLiveOn                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 04C LBUsageCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 050 IsLBAlwaysMaxUsage                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 054 SkipLiveLBUsageCount                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 058 IsSkipLiveLBAlwaysMaxUsage               000186595960 ModelPrimitiveType bool bool bool Bool
    // 05C SelectedUnitEditTabType                  00018658B1A0 ModelEnumType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType Int32
    public partial class LiveUnitConfirmationSaveData
    {
        public bool                                     IsAutoLiveOn                            { get; set; }
        public int                                      LBUsageCount                            { get; set; }
        public bool                                     IsLBAlwaysMaxUsage                      { get; set; }
        public int                                      SkipLiveLBUsageCount                    { get; set; }
        public bool                                     IsSkipLiveLBAlwaysMaxUsage              { get; set; }
        public LiveUnitConfirmationUnitEditTabType      SelectedUnitEditTabType                 { get; set; }

        public static LiveUnitConfirmationSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationSaveData();

            value.IsAutoLiveOn                              = GetBool(new IntPtr(p + 0x048)); // 027003A72DA0 0x48 IsAutoLiveOn                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LBUsageCount                              = GetInt32(new IntPtr(p + 0x04C)); // 027003A72DC0 0x4C LBUsageCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsLBAlwaysMaxUsage                        = GetBool(new IntPtr(p + 0x050)); // 027003A72DE0 0x50 IsLBAlwaysMaxUsage          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SkipLiveLBUsageCount                      = GetInt32(new IntPtr(p + 0x054)); // 027003A72E00 0x54 SkipLiveLBUsageCount        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsSkipLiveLBAlwaysMaxUsage                = GetBool(new IntPtr(p + 0x058)); // 027003A72E20 0x58 IsSkipLiveLBAlwaysMaxUsage  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SelectedUnitEditTabType                   = (LiveUnitConfirmationUnitEditTabType)GetInt32(new IntPtr(p + 0x05C)); // 027003A72E40 0x5C SelectedUnitEditTabType     ( 00018658B1A0 ModelEnumType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType Int32 )

            return value;
        }
    }
}
