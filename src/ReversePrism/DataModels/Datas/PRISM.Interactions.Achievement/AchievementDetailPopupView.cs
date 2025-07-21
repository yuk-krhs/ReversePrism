using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PanelView                                ModelClassType AchievementDetailPanelView AchievementDetailPanelView AchievementDetailPanelView Pointer
    // 028 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 AchievementId                            ModelPrimitiveType int int int Int32
    // 038 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class AchievementDetailPopupView : DataModel
    {
        public AchievementDetailPanelView?              PanelView                               { get; set; }
        public int                                      AchievementId                           { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static AchievementDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementDetailPopupView() { Pointer= p0 };

            value.PanelView                                 = GetObject<AchievementDetailPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementDetailPanelView.FromPointer); // 0x20 PanelView                   ( ModelClassType AchievementDetailPanelView AchievementDetailPanelView AchievementDetailPanelView Pointer )
            value.AchievementId                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 AchievementId               ( ModelPrimitiveType int int int Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x38 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
