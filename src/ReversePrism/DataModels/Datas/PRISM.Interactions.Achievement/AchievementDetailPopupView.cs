using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PanelView                                000186673B90 ModelClassType AchievementDetailPanelView AchievementDetailPanelView AchievementDetailPanelView Pointer
    // 028 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 AchievementId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class AchievementDetailPopupView
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
            var value   = new AchievementDetailPopupView();

            value.PanelView                                 = GetObject<AchievementDetailPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementDetailPanelView.FromPointer); // 0270DBEE8640 0x20 PanelView                   ( 000186673B90 ModelClassType AchievementDetailPanelView AchievementDetailPanelView AchievementDetailPanelView Pointer )
            value.AchievementId                             = GetInt32(new IntPtr(p + 0x030)); // 0270DBEE8680 0x30 AchievementId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0270DBEE86A0 0x38 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBEE86C0 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
