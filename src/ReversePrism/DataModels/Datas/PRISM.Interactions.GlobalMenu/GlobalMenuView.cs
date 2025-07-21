using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LeftMenu                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 MenuPanelView                            ModelClassType GlobalMenuPanelView GlobalMenuPanelView GlobalMenuPanelView Pointer
    // 030 FooterPanelView                          ModelClassType GlobalMenuFooterPanelView GlobalMenuFooterPanelView GlobalMenuFooterPanelView Pointer
    // 038 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 OptionPopupPrefab                        ModelClassType OptionPopupContent OptionPopupContent OptionPopupContent Pointer
    // 050 ProduceResumeConfirmPopupPrefab          ModelClassType ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent Pointer
    // 058 TransferAccount                          ModelClassType TransferAccount TransferAccount TransferAccount Pointer
    // 060 EventListButtonView                      ModelClassType EventListButtonView EventListButtonView EventListButtonView Pointer
    // 068 ViewModel                                ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer
    // 070 onMenuClicked                            Subject`1<MenuType> IL2CPP_TYPE_GENERICINST
    // 078 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 080 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class GlobalMenuView : DataModel
    {
        public RectTransform?                           LeftMenu                                { get; set; }
        public GlobalMenuPanelView?                     MenuPanelView                           { get; set; }
        public GlobalMenuFooterPanelView?               FooterPanelView                         { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public OptionPopupContent?                      OptionPopupPrefab                       { get; set; }
        public ProduceResumeConfirmPopupContent?        ProduceResumeConfirmPopupPrefab         { get; set; }
        public TransferAccount?                         TransferAccount                         { get; set; }
        public EventListButtonView?                     EventListButtonView                     { get; set; }
        public GlobalMenuViewModel?                     ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static GlobalMenuView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuView() { Pointer= p0 };

            value.LeftMenu                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 LeftMenu                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.MenuPanelView                             = GetObject<GlobalMenuPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.GlobalMenuPanelView.FromPointer); // 0x28 MenuPanelView               ( ModelClassType GlobalMenuPanelView GlobalMenuPanelView GlobalMenuPanelView Pointer )
            value.FooterPanelView                           = GetObject<GlobalMenuFooterPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.GlobalMenuFooterPanelView.FromPointer); // 0x30 FooterPanelView             ( ModelClassType GlobalMenuFooterPanelView GlobalMenuFooterPanelView GlobalMenuFooterPanelView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.OptionPopupPrefab                         = GetObject<OptionPopupContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.OptionPopupContent.FromPointer); // 0x48 OptionPopupPrefab           ( ModelClassType OptionPopupContent OptionPopupContent OptionPopupContent Pointer )
            value.ProduceResumeConfirmPopupPrefab           = GetObject<ProduceResumeConfirmPopupContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceResumeConfirmPopupContent.FromPointer); // 0x50 ProduceResumeConfirmPopupPrefab ( ModelClassType ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent Pointer )
            value.TransferAccount                           = GetObject<TransferAccount>(new IntPtr(p + 0x058), ReversePrism.DataModels.TransferAccount.FromPointer); // 0x58 TransferAccount             ( ModelClassType TransferAccount TransferAccount TransferAccount Pointer )
            value.EventListButtonView                       = GetObject<EventListButtonView>(new IntPtr(p + 0x060), ReversePrism.DataModels.EventListButtonView.FromPointer); // 0x60 EventListButtonView         ( ModelClassType EventListButtonView EventListButtonView EventListButtonView Pointer )
            value.ViewModel                                 = GetObject<GlobalMenuViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.GlobalMenuViewModel.FromPointer); // 0x68 ViewModel                   ( ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0x78 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x80 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
