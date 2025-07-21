using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 IsAutoLiveOn                             ModelPrimitiveType bool bool bool Bool
    // 054 LBUsageCount                             ModelPrimitiveType int int int Int32
    // 058 IsLBAlwaysMaxUsage                       ModelPrimitiveType bool bool bool Bool
    // 05C SkipLiveLBUsageCount                     ModelPrimitiveType int int int Int32
    // 060 IsSkipLiveLBAlwaysMaxUsage               ModelPrimitiveType bool bool bool Bool
    // 064 SelectedUnitEditTabType                  ModelEnumType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType Int32
    public partial class LiveUnitConfirmationSaveData : DataModel
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
            var value   = new LiveUnitConfirmationSaveData() { Pointer= p0 };

            value.IsAutoLiveOn                              = GetBool(new IntPtr(p + 0x050)); // 0x50 IsAutoLiveOn                ( ModelPrimitiveType bool bool bool Bool )
            value.LBUsageCount                              = GetInt32(new IntPtr(p + 0x054)); // 0x54 LBUsageCount                ( ModelPrimitiveType int int int Int32 )
            value.IsLBAlwaysMaxUsage                        = GetBool(new IntPtr(p + 0x058)); // 0x58 IsLBAlwaysMaxUsage          ( ModelPrimitiveType bool bool bool Bool )
            value.SkipLiveLBUsageCount                      = GetInt32(new IntPtr(p + 0x05C)); // 0x5C SkipLiveLBUsageCount        ( ModelPrimitiveType int int int Int32 )
            value.IsSkipLiveLBAlwaysMaxUsage                = GetBool(new IntPtr(p + 0x060)); // 0x60 IsSkipLiveLBAlwaysMaxUsage  ( ModelPrimitiveType bool bool bool Bool )
            value.SelectedUnitEditTabType                   = (LiveUnitConfirmationUnitEditTabType)GetInt32(new IntPtr(p + 0x064)); // 0x64 SelectedUnitEditTabType     ( ModelEnumType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType LiveUnitConfirmationUnitEditTabType Int32 )

            return value;
        }
    }
}
