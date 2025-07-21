using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 HeaderTitleText                          ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 ListView                                 ModelClassType MissionListView MissionListView MissionListView Pointer
    // 038 ReceiveLimitedRootObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ReceiveLimitedText                       ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 AllReceiveButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 058 TimerDisposable                          ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class MissionLimitedContentPanelView : DataModel
    {
        public GameObject?                              RootObject                              { get; set; }
        public TextMeshProUGUI?                         HeaderTitleText                         { get; set; }
        public MissionListView?                         ListView                                { get; set; }
        public GameObject?                              ReceiveLimitedRootObject                { get; set; }
        public TextMeshProUGUI?                         ReceiveLimitedText                      { get; set; }
        public UIButton?                                AllReceiveButton                        { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IDisposable?                             TimerDisposable                         { get; set; }

        public static MissionLimitedContentPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionLimitedContentPanelView() { Pointer= p0 };

            value.RootObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 RootObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HeaderTitleText                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 HeaderTitleText             ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ListView                                  = GetObject<MissionListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MissionListView.FromPointer); // 0x30 ListView                    ( ModelClassType MissionListView MissionListView MissionListView Pointer )
            value.ReceiveLimitedRootObject                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ReceiveLimitedRootObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReceiveLimitedText                        = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x40 ReceiveLimitedText          ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.AllReceiveButton                          = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 AllReceiveButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.TimerDisposable                           = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 TimerDisposable             ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
