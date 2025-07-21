using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 EventListView                            ModelClassType MissionEventListView MissionEventListView MissionEventListView Pointer
    // 030 HeaderTitleText                          ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 ListView                                 ModelClassType MissionListView MissionListView MissionListView Pointer
    // 040 ReceiveLimitedRootObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ReceiveLimitedText                       ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 AllReceiveButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 058 EventListRoot                            ModelClassType GameObject GameObject GameObject Pointer
    // 060 MissionListRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 068 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 070 onClickEventList                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 TimerDisposable                          ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class MissionEventContentPanelView : DataModel
    {
        public GameObject?                              RootObject                              { get; set; }
        public MissionEventListView?                    EventListView                           { get; set; }
        public TextMeshProUGUI?                         HeaderTitleText                         { get; set; }
        public MissionListView?                         ListView                                { get; set; }
        public GameObject?                              ReceiveLimitedRootObject                { get; set; }
        public TextMeshProUGUI?                         ReceiveLimitedText                      { get; set; }
        public UIButton?                                AllReceiveButton                        { get; set; }
        public GameObject?                              EventListRoot                           { get; set; }
        public GameObject?                              MissionListRoot                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IDisposable?                             TimerDisposable                         { get; set; }

        public static MissionEventContentPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionEventContentPanelView() { Pointer= p0 };

            value.RootObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 RootObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EventListView                             = GetObject<MissionEventListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionEventListView.FromPointer); // 0x28 EventListView               ( ModelClassType MissionEventListView MissionEventListView MissionEventListView Pointer )
            value.HeaderTitleText                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 HeaderTitleText             ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ListView                                  = GetObject<MissionListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MissionListView.FromPointer); // 0x38 ListView                    ( ModelClassType MissionListView MissionListView MissionListView Pointer )
            value.ReceiveLimitedRootObject                  = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ReceiveLimitedRootObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReceiveLimitedText                        = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x48 ReceiveLimitedText          ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.AllReceiveButton                          = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 AllReceiveButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EventListRoot                             = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 EventListRoot               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionListRoot                           = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 MissionListRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x68 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.TimerDisposable                           = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0x78 TimerDisposable             ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
