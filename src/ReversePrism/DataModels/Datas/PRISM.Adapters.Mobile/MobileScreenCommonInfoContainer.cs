using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 showHowToPlayOurStream                   Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 Connector                                ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer
    // 020 LoadingScreen                            ModelClassType IMobileLoadingScreen IMobileLoadingScreen IMobileLoadingScreen Pointer
    // 028 TemporaryParameter                       ModelClassType MobileTemporaryParameter MobileTemporaryParameter MobileTemporaryParameter Pointer
    // 030 OurStreamTabGroup                        ModelClassType IOurStreamTabGroup IOurStreamTabGroup IOurStreamTabGroup Pointer
    // 038 TwestaArticleTemporaryCacheContainer     ModelClassType TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer Pointer
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

            value.Connector                                 = GetObject<IMobileScreenConnector>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMobileScreenConnector.FromPointer); // 0x18 Connector                   ( ModelClassType IMobileScreenConnector IMobileScreenConnector IMobileScreenConnector Pointer )
            value.LoadingScreen                             = GetObject<IMobileLoadingScreen>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMobileLoadingScreen.FromPointer); // 0x20 LoadingScreen               ( ModelClassType IMobileLoadingScreen IMobileLoadingScreen IMobileLoadingScreen Pointer )
            value.TemporaryParameter                        = GetObject<MobileTemporaryParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileTemporaryParameter.FromPointer); // 0x28 TemporaryParameter          ( ModelClassType MobileTemporaryParameter MobileTemporaryParameter MobileTemporaryParameter Pointer )
            value.OurStreamTabGroup                         = GetObject<IOurStreamTabGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.IOurStreamTabGroup.FromPointer); // 0x30 OurStreamTabGroup           ( ModelClassType IOurStreamTabGroup IOurStreamTabGroup IOurStreamTabGroup Pointer )
            value.TwestaArticleTemporaryCacheContainer      = GetObject<TwestaArticleTemporaryCacheContainer>(new IntPtr(p + 0x038), ReversePrism.DataModels.TwestaArticleTemporaryCacheContainer.FromPointer); // 0x38 TwestaArticleTemporaryCacheContainer ( ModelClassType TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer TwestaArticleTemporaryCacheContainer Pointer )

            return value;
        }
    }
}
