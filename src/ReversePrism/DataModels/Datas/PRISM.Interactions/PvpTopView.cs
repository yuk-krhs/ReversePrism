using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderPanel                              ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer
    // 028 PlayerPanel                              ModelClassType PvpPlayerPanelView PvpPlayerPanelView PvpPlayerPanelView Pointer
    // 030 UserListPanel                            ModelClassType PvpUserListPanelView PvpUserListPanelView PvpUserListPanelView Pointer
    // 038 UnitSetupButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 040 DefenceUnitSetupButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 048 RankingButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 050 UpdateButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 058 IconAtlas                                ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
    // 060 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class PvpTopView : DataModel
    {
        public PvpHeaderPanelView?                      HeaderPanel                             { get; set; }
        public PvpPlayerPanelView?                      PlayerPanel                             { get; set; }
        public PvpUserListPanelView?                    UserListPanel                           { get; set; }
        public UIButton?                                UnitSetupButton                         { get; set; }
        public UIButton?                                DefenceUnitSetupButton                  { get; set; }
        public UIButton?                                RankingButton                           { get; set; }
        public UIButton?                                UpdateButton                            { get; set; }
        public SpriteAtlas?                             IconAtlas                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static PvpTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpTopView() { Pointer= p0 };

            value.HeaderPanel                               = GetObject<PvpHeaderPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpHeaderPanelView.FromPointer); // 0x20 HeaderPanel                 ( ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer )
            value.PlayerPanel                               = GetObject<PvpPlayerPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpPlayerPanelView.FromPointer); // 0x28 PlayerPanel                 ( ModelClassType PvpPlayerPanelView PvpPlayerPanelView PvpPlayerPanelView Pointer )
            value.UserListPanel                             = GetObject<PvpUserListPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpUserListPanelView.FromPointer); // 0x30 UserListPanel               ( ModelClassType PvpUserListPanelView PvpUserListPanelView PvpUserListPanelView Pointer )
            value.UnitSetupButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 UnitSetupButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DefenceUnitSetupButton                    = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 DefenceUnitSetupButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RankingButton                             = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 RankingButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UpdateButton                              = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 UpdateButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IconAtlas                                 = GetObject<SpriteAtlas>(new IntPtr(p + 0x058), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 0x58 IconAtlas                   ( ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x60 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
