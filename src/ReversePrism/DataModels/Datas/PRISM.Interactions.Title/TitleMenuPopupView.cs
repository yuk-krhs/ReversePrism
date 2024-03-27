using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleMenuContent                         000186679460 ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer
    // 028 CacheClearContent                        0001865210E0 ModelClassType CacheClearContent CacheClearContent CacheClearContent Pointer
    // 030 transferContactPopupFactory              PopupViewFactory`1<ITransferContactPopupView> IL2CPP_TYPE_GENERICINST
    // 038 PlayerDataDeleteContent                  000186750D00 ModelClassType PlayerDataDeleteContent PlayerDataDeleteContent PlayerDataDeleteContent Pointer
    // 040 CacheCleaerProgressFactory               0001866058B0 ModelClassType SystemCacheClearProgressViewFactory SystemCacheClearProgressViewFactory SystemCacheClearProgressViewFactory Pointer
    // 048 MessagePopup                             000186734520 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer
    // 050 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 058 MenuContent                              000186679460 ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer
    public partial class TitleMenuPopupView
    {
        public TitleMenuContent?                        TitleMenuContent                        { get; set; }
        public CacheClearContent?                       CacheClearContent                       { get; set; }
        public PlayerDataDeleteContent?                 PlayerDataDeleteContent                 { get; set; }
        public SystemCacheClearProgressViewFactory?     CacheCleaerProgressFactory              { get; set; }
        public ICommonSequencerContainer?               MessagePopup                            { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public TitleMenuContent?                        MenuContent                             { get; set; }

        public static TitleMenuPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleMenuPopupView();

            value.TitleMenuContent                          = GetObject<TitleMenuContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.TitleMenuContent.FromPointer); // 027004371360 0x20 TitleMenuContent            ( 000186679460 ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer )
            value.CacheClearContent                         = GetObject<CacheClearContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.CacheClearContent.FromPointer); // 027004371380 0x28 CacheClearContent           ( 0001865210E0 ModelClassType CacheClearContent CacheClearContent CacheClearContent Pointer )
            value.PlayerDataDeleteContent                   = GetObject<PlayerDataDeleteContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayerDataDeleteContent.FromPointer); // 0270043713C0 0x38 PlayerDataDeleteContent     ( 000186750D00 ModelClassType PlayerDataDeleteContent PlayerDataDeleteContent PlayerDataDeleteContent Pointer )
            value.CacheCleaerProgressFactory                = GetObject<SystemCacheClearProgressViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.SystemCacheClearProgressViewFactory.FromPointer); // 0270043713E0 0x40 CacheCleaerProgressFactory  ( 0001866058B0 ModelClassType SystemCacheClearProgressViewFactory SystemCacheClearProgressViewFactory SystemCacheClearProgressViewFactory Pointer )
            value.MessagePopup                              = GetObject<ICommonSequencerContainer>(new IntPtr(p + 0x048), ReversePrism.DataModels.ICommonSequencerContainer.FromPointer); // 027004371400 0x48 MessagePopup                ( 000186734520 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceTag.FromPointer); // 027004371420 0x50 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.MenuContent                               = GetObject<TitleMenuContent>(new IntPtr(p + 0x058), ReversePrism.DataModels.TitleMenuContent.FromPointer); // 027004371440 0x58 MenuContent                 ( 000186679460 ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer )

            return value;
        }
    }
}
