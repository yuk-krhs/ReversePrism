using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RowRect                                  ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 OnClickDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 030 OnLongPressDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    // 038 RowIndex                                 ModelPrimitiveType int int int Int32
    // 03C StartItemIndex                           ModelPrimitiveType int int int Int32
    // 040 Items                                    ModelClassListType IReadOnlyList`1<GameObject> IReadOnlyList`1<GameObject> List<GameObject> Pointer
    public partial class UIRotatedGridRowView : DataModel
    {
        public RectTransform?                           RowRect                                 { get; set; }
        public IDisposable?                             OnClickDisposable                       { get; set; }
        public IDisposable?                             OnLongPressDisposable                   { get; set; }
        public int                                      RowIndex                                { get; set; }
        public int                                      StartItemIndex                          { get; set; }
        public List<GameObject>?                        Items                                   { get; set; }

        public static UIRotatedGridRowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRotatedGridRowView() { Pointer= p0 };

            value.RowRect                                   = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 RowRect                     ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OnClickDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0x28 OnClickDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnLongPressDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0x30 OnLongPressDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.RowIndex                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 RowIndex                    ( ModelPrimitiveType int int int Int32 )
            value.StartItemIndex                            = GetInt32(new IntPtr(p + 0x03C)); // 0x3C StartItemIndex              ( ModelPrimitiveType int int int Int32 )
            value.Items                                     = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 Items                       ( ModelClassListType IReadOnlyList`1<GameObject> IReadOnlyList`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
