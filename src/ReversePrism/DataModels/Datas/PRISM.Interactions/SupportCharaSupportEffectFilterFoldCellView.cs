using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CellHeight                               ModelPrimitiveType float float float Single
    // 040 TxtTitle                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtSelectedEffectType                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtSelectedSchedule                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BtnOpen                                  ModelClassType UIButton UIButton UIButton Pointer
    // 060 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class SupportCharaSupportEffectFilterFoldCellView : DataModel
    {
        public float                                    CellHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }
        public UITextMeshProUGUI?                       TxtSelectedEffectType                   { get; set; }
        public UITextMeshProUGUI?                       TxtSelectedSchedule                     { get; set; }
        public UIButton?                                BtnOpen                                 { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static SupportCharaSupportEffectFilterFoldCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaSupportEffectFilterFoldCellView() { Pointer= p0 };

            value.CellHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 CellHeight                  ( ModelPrimitiveType float float float Single )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtTitle                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedEffectType                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtSelectedEffectType       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedSchedule                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtSelectedSchedule         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnOpen                                   = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BtnOpen                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
