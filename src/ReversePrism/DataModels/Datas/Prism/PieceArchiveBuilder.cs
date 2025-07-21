using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType PieceArchiveView PieceArchiveView PieceArchiveView Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    public partial class PieceArchiveBuilder : DataModel
    {
        public PieceArchiveView?                        View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }

        public static PieceArchiveBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchiveBuilder() { Pointer= p0 };

            value.View                                      = GetObject<PieceArchiveView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PieceArchiveView.FromPointer); // 0x20 View                        ( ModelClassType PieceArchiveView PieceArchiveView PieceArchiveView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )

            return value;
        }
    }
}
