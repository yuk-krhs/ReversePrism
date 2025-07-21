using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 ClearLabel                               ModelClassType GameObject GameObject GameObject Pointer
    // 030 LockObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 038 SelectObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 040 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 048 SelectedDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProduceEpisodeEpisodeSelectDifficultyButton : DataModel
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
            var value   = new ProduceEpisodeEpisodeSelectDifficultyButton() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ClearLabel                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ClearLabel                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LockObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectObject                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SelectObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x40 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.SelectedDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 SelectedDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
