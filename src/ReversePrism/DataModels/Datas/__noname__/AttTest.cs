using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LogText                                  ModelClassType Text Text Text Pointer
    // 028 AppTrackingTransparency                  ModelClassType IAppTrackingTransparency IAppTrackingTransparency IAppTrackingTransparency Pointer
    public partial class AttTest : DataModel
    {
        public Text?                                    LogText                                 { get; set; }
        public IAppTrackingTransparency?                AppTrackingTransparency                 { get; set; }

        public static AttTest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttTest() { Pointer= p0 };

            value.LogText                                   = GetObject<Text>(new IntPtr(p + 0x020), ReversePrism.DataModels.Text.FromPointer); // 0x20 LogText                     ( ModelClassType Text Text Text Pointer )
            value.AppTrackingTransparency                   = GetObject<IAppTrackingTransparency>(new IntPtr(p + 0x028), ReversePrism.DataModels.IAppTrackingTransparency.FromPointer); // 0x28 AppTrackingTransparency     ( ModelClassType IAppTrackingTransparency IAppTrackingTransparency IAppTrackingTransparency Pointer )

            return value;
        }
    }
}
