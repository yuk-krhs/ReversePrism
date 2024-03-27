using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RowRect                                  000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 OnClickDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 030 OnLongPressDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 038 RowIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C StartItemIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 Items                                    000185CF0B88 ModelClassListType IReadOnlyList`1<GameObject> IReadOnlyList`1<GameObject> List<GameObject> Pointer
    public partial class UIRotatedGridRowView
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
            var value   = new UIRotatedGridRowView();

            value.RowRect                                   = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D54A89F8 0x20 RowRect                     ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OnClickDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D54A8A18 0x28 OnClickDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnLongPressDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D54A8A38 0x30 OnLongPressDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.RowIndex                                  = GetInt32(new IntPtr(p + 0x038)); // 0270D54A8A58 0x38 RowIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StartItemIndex                            = GetInt32(new IntPtr(p + 0x03C)); // 0270D54A8A78 0x3C StartItemIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Items                                     = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D54A8A98 0x40 Items                       ( 000185CF0B88 ModelClassListType IReadOnlyList`1<GameObject> IReadOnlyList`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
