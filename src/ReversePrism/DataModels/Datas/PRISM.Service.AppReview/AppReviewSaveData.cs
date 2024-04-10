using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppReviewResetTime                       0001865F7700 ModelPrimitiveType long long long Int64
    // 018 IsGashaAppReview                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AppReviewSaveData : DataModel
    {
        public long                                     AppReviewResetTime                      { get; set; }
        public bool                                     IsGashaAppReview                        { get; set; }

        public static AppReviewSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppReviewSaveData() { Pointer= p0 };

            value.AppReviewResetTime                        = GetInt64(new IntPtr(p + 0x010)); // 0245A3A7A078 0x10 AppReviewResetTime          ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IsGashaAppReview                          = GetBool(new IntPtr(p + 0x018)); // 0245A3A7A098 0x18 IsGashaAppReview            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
