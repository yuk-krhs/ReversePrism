using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeEmpty                              ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer
    // 028 BeforeIcon                               ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 030 AfterEmpty                               ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer
    // 038 AfterIcon                                ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 040 AfterIconCanceller                       ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveIdolChangePreview : DataModel
    {
        public PFIdolIconRectEmptyView?                 BeforeEmpty                             { get; set; }
        public PFIdolIconRectView?                      BeforeIcon                              { get; set; }
        public PFIdolIconRectEmptyView?                 AfterEmpty                              { get; set; }
        public PFIdolIconRectView?                      AfterIcon                               { get; set; }
        public AutoCancellationTokenSource              AfterIconCanceller                      { get; set; }

        public static LiveIdolChangePreview? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolChangePreview() { Pointer= p0 };

            value.BeforeEmpty                               = GetObject<PFIdolIconRectEmptyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectEmptyView.FromPointer); // 0x20 BeforeEmpty                 ( ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer )
            value.BeforeIcon                                = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x28 BeforeIcon                  ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.AfterEmpty                                = GetObject<PFIdolIconRectEmptyView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconRectEmptyView.FromPointer); // 0x30 AfterEmpty                  ( ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer )
            value.AfterIcon                                 = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x38 AfterIcon                   ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.AfterIconCanceller                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x040)); // 0x40 AfterIconCanceller          ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
