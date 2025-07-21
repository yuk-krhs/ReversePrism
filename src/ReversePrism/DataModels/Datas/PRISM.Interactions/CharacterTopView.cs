using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TopGroup                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 BtnUpgrading                             ModelClassType UIButton UIButton UIButton Pointer
    // 030 BtnParty                                 ModelClassType UIButton UIButton UIButton Pointer
    // 038 BtnIdolList                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 BtnIdol                                  ModelClassType UIButton UIButton UIButton Pointer
    // 048 UpgradingGroup                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 BtnPIUpgrading                           ModelClassType UIButton UIButton UIButton Pointer
    // 058 BtnSCUpgrading                           ModelClassType UIButton UIButton UIButton Pointer
    // 060 BtnPieceArchive                          ModelClassType UIButton UIButton UIButton Pointer
    // 068 PartyGroup                               ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 070 BtnProduceUnit                           ModelClassType UIButton UIButton UIButton Pointer
    // 078 BtnLiveUnit                              ModelClassType UIButton UIButton UIButton Pointer
    // 080 BtnDressUpRoom                           ModelClassType UIButton UIButton UIButton Pointer
    // 088 BtnBack                                  ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer
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

            value.TopGroup                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 TopGroup                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnUpgrading                              = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnUpgrading                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnParty                                  = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BtnParty                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnIdolList                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnIdolList                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnIdol                                   = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnIdol                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UpgradingGroup                            = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x48 UpgradingGroup              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnPIUpgrading                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 BtnPIUpgrading              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnSCUpgrading                            = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BtnSCUpgrading              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnPieceArchive                           = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 BtnPieceArchive             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PartyGroup                                = GetObject<CanvasGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x68 PartyGroup                  ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnProduceUnit                            = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 BtnProduceUnit              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLiveUnit                               = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 BtnLiveUnit                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDressUpRoom                            = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 BtnDressUpRoom              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnBack                                   = GetObject<ViewBackButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.ViewBackButton.FromPointer); // 0x88 BtnBack                     ( ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer )

            return value;
        }
    }
}
