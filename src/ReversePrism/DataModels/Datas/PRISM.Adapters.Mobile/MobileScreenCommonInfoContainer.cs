using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Connector                                0001865B7BA0 ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer
    // 018 LoadingScreen                            0001865B56F0 ModelClassType IMobileLoadingScreen IMobileLoadingScreen IMobileLoadingScreen Pointer
    // 020 TemporaryParameter                       000186637350 ModelClassType MobileTemporaryParameter MobileTemporaryParameter MobileTemporaryParameter Pointer
    // 028 OurStreamTabGroup                        0001865CBD90 ModelClassType IOurStreamTabGroup IOurStreamTabGroup IOurStreamTabGroup Pointer
    // 030 TwestaArticleTemporaryCacheContainer     0001866C77B0 ModelClassType TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer Pointer
    public partial class MobileScreenCommonInfoContainer : DataModel
    {
        public IMobileScreenConnector?                  Connector                               { get; set; }
        public IMobileLoadingScreen?                    LoadingScreen                           { get; set; }
        public MobileTemporaryParameter?                TemporaryParameter                      { get; set; }
        public IOurStreamTabGroup?                      OurStreamTabGroup                       { get; set; }
        public TwestaArticleTemporaryCacheContainer?    TwestaArticleTemporaryCacheContainer    { get; set; }

        public static MobileScreenCommonInfoContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileScreenCommonInfoContainer() { Pointer= p0 };

            value.Connector                                 = GetObject<IMobileScreenConnector>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMobileScreenConnector.FromPointer); // 0246668ECCE0 0x10 Connector                   ( 0001865B7BA0 ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer )
            value.LoadingScreen                             = GetObject<IMobileLoadingScreen>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMobileLoadingScreen.FromPointer); // 0246668ECD00 0x18 LoadingScreen               ( 0001865B56F0 ModelClassType IMobileLoadingScreen IMobileLoadingScreen IMobileLoadingScreen Pointer )
            value.TemporaryParameter                        = GetObject<MobileTemporaryParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileTemporaryParameter.FromPointer); // 0246668ECD20 0x20 TemporaryParameter          ( 000186637350 ModelClassType MobileTemporaryParameter MobileTemporaryParameter MobileTemporaryParameter Pointer )
            value.OurStreamTabGroup                         = GetObject<IOurStreamTabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.IOurStreamTabGroup.FromPointer); // 0246668ECD40 0x28 OurStreamTabGroup           ( 0001865CBD90 ModelClassType IOurStreamTabGroup IOurStreamTabGroup IOurStreamTabGroup Pointer )
            value.TwestaArticleTemporaryCacheContainer      = GetObject<TwestaArticleTemporaryCacheContainer>(new IntPtr(p + 0x030), ReversePrism.DataModels.TwestaArticleTemporaryCacheContainer.FromPointer); // 0246668ECD60 0x30 TwestaArticleTemporaryCacheContainer ( 0001866C77B0 ModelClassType TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer Pointer )

            return value;
        }
    }
}
