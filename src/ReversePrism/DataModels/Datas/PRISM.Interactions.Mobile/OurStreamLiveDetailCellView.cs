using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 LiveViewingButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 LiveViewingButtonText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 LiveStatusObjects                        000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0A0 BeginTimeDisposable                      0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0A8 onRefreshSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
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

            value.LiveViewingButton                         = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 02466B1B6480 0x88 LiveViewingButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveViewingButtonText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1B64A0 0x90 LiveViewingButtonText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LiveStatusObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1B64C0 0x98 LiveStatusObjects           ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BeginTimeDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B1B64E0 0xA0 BeginTimeDisposable         ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
