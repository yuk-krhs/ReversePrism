using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderPanel                              0001865E4990 ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer
    // 028 PlayerPanel                              0001865EEFD0 ModelClassType PvpPlayerPanelView PvpPlayerPanelView PvpPlayerPanelView Pointer
    // 030 UserListPanel                            0001865F9AB0 ModelClassType PvpUserListPanelView PvpUserListPanelView PvpUserListPanelView Pointer
    // 038 UnitSetupButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 DefenceUnitSetupButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 RankingButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 UpdateButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 IconAtlas                                00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
    // 060 pvpConfirmPoppuFactory                   PopupViewFactory`1<IPvpConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 068 fesUnitDetailPopupViewFactory            PopupViewFactory`1<IFUnitDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 070 pIdolUnitDetailPopupViewFactory          IPopupViewFactory`1<IChallengeTourPIdolUnitDetailPopupView> IL2CPP_TYPE_GENERICINST
    public partial class PvpTopView
    {
        public PvpHeaderPanelView?                      HeaderPanel                             { get; set; }
        public PvpPlayerPanelView?                      PlayerPanel                             { get; set; }
        public PvpUserListPanelView?                    UserListPanel                           { get; set; }
        public UIButton?                                UnitSetupButton                         { get; set; }
        public UIButton?                                DefenceUnitSetupButton                  { get; set; }
        public UIButton?                                RankingButton                           { get; set; }
        public UIButton?                                UpdateButton                            { get; set; }
        public SpriteAtlas?                             IconAtlas                               { get; set; }

        public static PvpTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpTopView();

            value.HeaderPanel                               = GetObject<PvpHeaderPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpHeaderPanelView.FromPointer); // 0270DA14A0C8 0x20 HeaderPanel                 ( 0001865E4990 ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer )
            value.PlayerPanel                               = GetObject<PvpPlayerPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpPlayerPanelView.FromPointer); // 0270DA14A0E8 0x28 PlayerPanel                 ( 0001865EEFD0 ModelClassType PvpPlayerPanelView PvpPlayerPanelView PvpPlayerPanelView Pointer )
            value.UserListPanel                             = GetObject<PvpUserListPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpUserListPanelView.FromPointer); // 0270DA14A108 0x30 UserListPanel               ( 0001865F9AB0 ModelClassType PvpUserListPanelView PvpUserListPanelView PvpUserListPanelView Pointer )
            value.UnitSetupButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA14A128 0x38 UnitSetupButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DefenceUnitSetupButton                    = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA14A148 0x40 DefenceUnitSetupButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RankingButton                             = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA14A168 0x48 RankingButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UpdateButton                              = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA14A188 0x50 UpdateButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconAtlas                                 = GetObject<SpriteAtlas>(new IntPtr(p + 0x058), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 0270DA14A1A8 0x58 IconAtlas                   ( 00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )

            return value;
        }
    }
}
