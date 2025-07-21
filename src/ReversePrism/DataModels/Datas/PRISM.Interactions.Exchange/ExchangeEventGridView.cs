using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 CellPrefab                               ModelClassType ExchangeEventViewCell ExchangeEventViewCell ExchangeEventViewCell Pointer
    // 0A0 EmptyViewText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ExchangeEventGridView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ExchangeEventViewCell?                   CellPrefab                              { get; set; }
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }

        public static ExchangeEventGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventGridView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x90 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CellPrefab                                = GetObject<ExchangeEventViewCell>(new IntPtr(p + 0x098), ReversePrism.DataModels.ExchangeEventViewCell.FromPointer); // 0x98 CellPrefab                  ( ModelClassType ExchangeEventViewCell ExchangeEventViewCell ExchangeEventViewCell Pointer )
            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 EmptyViewText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
