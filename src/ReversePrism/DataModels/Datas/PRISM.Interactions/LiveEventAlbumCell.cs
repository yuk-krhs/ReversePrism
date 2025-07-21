using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 UnlockedObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 LockedObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 038 LockedText                               ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    public partial class LiveEventAlbumCell : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public GameObject?                              UnlockedObject                          { get; set; }
        public GameObject?                              LockedObject                            { get; set; }
        public TextMeshProUGUI?                         LockedText                              { get; set; }

        public static LiveEventAlbumCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAlbumCell() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UnlockedObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 UnlockedObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedObject                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LockedObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedText                                = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x38 LockedText                  ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )

            return value;
        }
    }
}
