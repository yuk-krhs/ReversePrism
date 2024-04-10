using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TopGroup                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 BtnUpgrading                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 BtnParty                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 BtnIdolList                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 BtnIdol                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 UpgradingGroup                           000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 BtnPIUpgrading                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 BtnSCUpgrading                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 BtnPieceArchive                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 PartyGroup                               000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 070 BtnProduceUnit                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 BtnLiveUnit                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 BtnDressUpRoom                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 088 BtnBack                                  00018651A320 ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer
    // 090 selectViewSubject                        Subject`1<SelectBtnType> IL2CPP_TYPE_GENERICINST
    public partial class CharacterTopView : DataModel
    {
        public CanvasGroup?                             TopGroup                                { get; set; }
        public UIButton?                                BtnUpgrading                            { get; set; }
        public UIButton?                                BtnParty                                { get; set; }
        public UIButton?                                BtnIdolList                             { get; set; }
        public UIButton?                                BtnIdol                                 { get; set; }
        public CanvasGroup?                             UpgradingGroup                          { get; set; }
        public UIButton?                                BtnPIUpgrading                          { get; set; }
        public UIButton?                                BtnSCUpgrading                          { get; set; }
        public UIButton?                                BtnPieceArchive                         { get; set; }
        public CanvasGroup?                             PartyGroup                              { get; set; }
        public UIButton?                                BtnProduceUnit                          { get; set; }
        public UIButton?                                BtnLiveUnit                             { get; set; }
        public UIButton?                                BtnDressUpRoom                          { get; set; }
        public ViewBackButton?                          BtnBack                                 { get; set; }

        public static CharacterTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTopView() { Pointer= p0 };

            value.TopGroup                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3EF7D0 0x20 TopGroup                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnUpgrading                              = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF7F0 0x28 BtnUpgrading                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnParty                                  = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF810 0x30 BtnParty                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnIdolList                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF830 0x38 BtnIdolList                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnIdol                                   = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF850 0x40 BtnIdol                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UpgradingGroup                            = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3EF870 0x48 UpgradingGroup              ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnPIUpgrading                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF890 0x50 BtnPIUpgrading              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSCUpgrading                            = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF8B0 0x58 BtnSCUpgrading              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnPieceArchive                           = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF8D0 0x60 BtnPieceArchive             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PartyGroup                                = GetObject<CanvasGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3EF8F0 0x68 PartyGroup                  ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnProduceUnit                            = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF910 0x70 BtnProduceUnit              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLiveUnit                               = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF930 0x78 BtnLiveUnit                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDressUpRoom                            = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3EF950 0x80 BtnDressUpRoom              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnBack                                   = GetObject<ViewBackButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.ViewBackButton.FromPointer); // 02466A3EF970 0x88 BtnBack                     ( 00018651A320 ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer )

            return value;
        }
    }
}
