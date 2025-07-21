using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 LockObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 068 UnlockObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 070 HowToPlayButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 078 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    public partial class MusicRateRewardListUnlockShinyCell : DataModel
    {
        public GameObject?                              LockObject                              { get; set; }
        public GameObject?                              UnlockObject                            { get; set; }
        public UIButton?                                HowToPlayButton                         { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }

        public static MusicRateRewardListUnlockShinyCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListUnlockShinyCell() { Pointer= p0 };

            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 LockObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UnlockObject                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 UnlockObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HowToPlayButton                           = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 HowToPlayButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x078), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x78 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )

            return value;
        }
    }
}
