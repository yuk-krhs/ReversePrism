using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CellHeight                               0001866656B0 ModelPrimitiveType float float float Single
    // 040 TxtTitle                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtSelectedEffectType                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtSelectedSchedule                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BtnOpen                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class SupportCharaSupportEffectFilterFoldCellView
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
            var value   = new SupportCharaSupportEffectFilterFoldCellView();

            value.CellHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0270DA342600 0x38 CellHeight                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA342620 0x40 TxtTitle                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedEffectType                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA342640 0x48 TxtSelectedEffectType       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSelectedSchedule                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA342660 0x50 TxtSelectedSchedule         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnOpen                                   = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA342680 0x58 BtnOpen                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA3426A0 0x60 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
