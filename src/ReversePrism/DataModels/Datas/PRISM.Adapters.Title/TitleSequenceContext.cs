using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITitleView ITitleView ITitleView Pointer
    // 018 UserData                                 ModelClassType LoginUserData LoginUserData LoginUserData Pointer
    // 020 DmmGamesViewerId                         ModelPrimitiveType long long long Int64
    // 028 DmmGamesViewerIdSignature                ModelPrimitiveType string string string String
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

            value.View                                      = GetObject<ITitleView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITitleView.FromPointer); // 0x10 View                        ( ModelClassType ITitleView ITitleView ITitleView Pointer )
            value.UserData                                  = GetObject<LoginUserData>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginUserData.FromPointer); // 0x18 UserData                    ( ModelClassType LoginUserData LoginUserData LoginUserData Pointer )
            value.DmmGamesViewerId                          = GetInt64(new IntPtr(p + 0x020)); // 0x20 DmmGamesViewerId            ( ModelPrimitiveType long long long Int64 )
            value.DmmGamesViewerIdSignature                 = GetString(new IntPtr(p + 0x028)); // 0x28 DmmGamesViewerIdSignature   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
