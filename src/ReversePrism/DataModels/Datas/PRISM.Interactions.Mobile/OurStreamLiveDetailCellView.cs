using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 LiveViewingButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 098 LiveViewingButtonText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 LiveStatusObjects                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0A8 BeginTimeDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0B0 onRefreshSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class OurStreamLiveDetailCellView : DataModel
    {
        public UIButton?                                LiveViewingButton                       { get; set; }
        public UITextMeshProUGUI?                       LiveViewingButtonText                   { get; set; }
        public List<GameObject>?                        LiveStatusObjects                       { get; set; }
        public IDisposable?                             BeginTimeDisposable                     { get; set; }

        public static OurStreamLiveDetailCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveDetailCellView() { Pointer= p0 };

            value.LiveViewingButton                         = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0x90 LiveViewingButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveViewingButtonText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 LiveViewingButtonText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LiveStatusObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 LiveStatusObjects           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BeginTimeDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xA8 BeginTimeDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
