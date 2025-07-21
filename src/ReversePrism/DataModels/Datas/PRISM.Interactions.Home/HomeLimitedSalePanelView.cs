using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PanelObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 028 TitleObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 030 EndtitleObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 038 EndPanelObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 040 TimeText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 050 AnimeObject                              ModelClassType GameObject GameObject GameObject Pointer
    public partial class HomeLimitedSalePanelView : DataModel
    {
        public GameObject?                              PanelObject                             { get; set; }
        public GameObject?                              TitleObject                             { get; set; }
        public GameObject?                              EndtitleObject                          { get; set; }
        public GameObject?                              EndPanelObject                          { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }
        public Animator?                                Animator                                { get; set; }
        public GameObject?                              AnimeObject                             { get; set; }

        public static HomeLimitedSalePanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLimitedSalePanelView() { Pointer= p0 };

            value.PanelObject                               = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 PanelObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TitleObject                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 TitleObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EndtitleObject                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EndtitleObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EndPanelObject                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 EndPanelObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TimeText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.AnimeObject                               = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 AnimeObject                 ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
