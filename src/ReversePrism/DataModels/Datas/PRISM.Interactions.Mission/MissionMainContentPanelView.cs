using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 ListView                                 ModelClassType MissionListView MissionListView MissionListView Pointer
    // 030 ReceiveLimitedRootObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ReceiveLimitedText                       ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 040 AllReceiveButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 048 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class MissionMainContentPanelView : DataModel
    {
        public GameObject?                              RootObject                              { get; set; }
        public MissionListView?                         ListView                                { get; set; }
        public GameObject?                              ReceiveLimitedRootObject                { get; set; }
        public TextMeshProUGUI?                         ReceiveLimitedText                      { get; set; }
        public UIButton?                                AllReceiveButton                        { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static MissionMainContentPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionMainContentPanelView() { Pointer= p0 };

            value.RootObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 RootObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ListView                                  = GetObject<MissionListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionListView.FromPointer); // 0x28 ListView                    ( ModelClassType MissionListView MissionListView MissionListView Pointer )
            value.ReceiveLimitedRootObject                  = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ReceiveLimitedRootObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReceiveLimitedText                        = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x38 ReceiveLimitedText          ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.AllReceiveButton                          = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 AllReceiveButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x48 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
