using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ClearLabel                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 LockObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 SelectObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 SelectedDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProduceEpisodeEpisodeSelectDifficultyButton
    {
        public UIButton?                                Button                                  { get; set; }
        public GameObject?                              ClearLabel                              { get; set; }
        public GameObject?                              LockObject                              { get; set; }
        public GameObject?                              SelectObject                            { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public IDisposable?                             SelectedDisposable                      { get; set; }

        public static ProduceEpisodeEpisodeSelectDifficultyButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceEpisodeEpisodeSelectDifficultyButton();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270D4CF2168 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ClearLabel                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CF2188 0x28 ClearLabel                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CF21A8 0x30 LockObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectObject                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4CF21C8 0x38 SelectObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D4CF21E8 0x40 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.SelectedDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D4CF2208 0x48 SelectedDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
