using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Identifier                               000186671BA0 ModelPrimitiveType string string string String
    // 018 UnityAdsIdentifierProvider               00018668D720 ModelClassType IUserIdentifierProvider IUserIdentifierProvider IUserIdentifierProvider Pointer
    // 020 UnityAnalyticsIdentifierProvider         00018668D720 ModelClassType IUserIdentifierProvider IUserIdentifierProvider IUserIdentifierProvider Pointer
    public partial class InstallationId : DataModel
    {
        public string                                   Identifier                              { get; set; }
        public IUserIdentifierProvider?                 UnityAdsIdentifierProvider              { get; set; }
        public IUserIdentifierProvider?                 UnityAnalyticsIdentifierProvider        { get; set; }

        public static InstallationId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstallationId() { Pointer= p0 };

            value.Identifier                                = GetString(new IntPtr(p + 0x010)); // 0245A65F1498 0x10 Identifier                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.UnityAdsIdentifierProvider                = GetObject<IUserIdentifierProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IUserIdentifierProvider.FromPointer); // 0245A65F14B8 0x18 UnityAdsIdentifierProvider  ( 00018668D720 ModelClassType IUserIdentifierProvider IUserIdentifierProvider IUserIdentifierProvider Pointer )
            value.UnityAnalyticsIdentifierProvider          = GetObject<IUserIdentifierProvider>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUserIdentifierProvider.FromPointer); // 0245A65F14D8 0x20 UnityAnalyticsIdentifierProvider ( 00018668D720 ModelClassType IUserIdentifierProvider IUserIdentifierProvider IUserIdentifierProvider Pointer )

            return value;
        }
    }
}
