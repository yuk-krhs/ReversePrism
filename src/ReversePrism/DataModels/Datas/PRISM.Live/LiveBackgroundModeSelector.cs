using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 028 ModeViews                                000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 backgroundModes                          IList`1<LiveBackgroundMode> IL2CPP_TYPE_GENERICINST
    // 038 onBackOnModeChanged                      Subject`1<LiveBackgroundMode> IL2CPP_TYPE_GENERICINST
    public partial class LiveBackgroundModeSelector
    {
        public ClickNumberCountedButton?                Button                                  { get; set; }
        public List<GameObject>?                        ModeViews                               { get; set; }

        public static LiveBackgroundModeSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveBackgroundModeSelector();

            value.Button                                    = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0270D50D39F0 0x20 Button                      ( 0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.ModeViews                                 = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D3A10 0x28 ModeViews                   ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
