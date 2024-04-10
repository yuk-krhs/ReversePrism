using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186674F30 ModelClassType ITitleView ITitleView ITitleView Pointer
    // 018 UserData                                 0001865BC9A0 ModelClassType LoginUserData LoginUserData LoginUserData Pointer
    // 020 DmmGamesViewerId                         0001865F7700 ModelPrimitiveType long long long Int64
    // 028 DmmGamesViewerIdSignature                000186671910 ModelPrimitiveType string string string String
    public partial class TitleSequenceContext : DataModel
    {
        public ITitleView?                              View                                    { get; set; }
        public LoginUserData?                           UserData                                { get; set; }
        public long                                     DmmGamesViewerId                        { get; set; }
        public string                                   DmmGamesViewerIdSignature               { get; set; }

        public static TitleSequenceContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleSequenceContext() { Pointer= p0 };

            value.View                                      = GetObject<ITitleView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITitleView.FromPointer); // 0245A44A9E00 0x10 View                        ( 000186674F30 ModelClassType ITitleView ITitleView ITitleView Pointer )
            value.UserData                                  = GetObject<LoginUserData>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginUserData.FromPointer); // 0245A44A9E20 0x18 UserData                    ( 0001865BC9A0 ModelClassType LoginUserData LoginUserData LoginUserData Pointer )
            value.DmmGamesViewerId                          = GetInt64(new IntPtr(p + 0x020)); // 0245A44A9E40 0x20 DmmGamesViewerId            ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DmmGamesViewerIdSignature                 = GetString(new IntPtr(p + 0x028)); // 0245A44A9E60 0x28 DmmGamesViewerIdSignature   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
