using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018673EBF0 ModelClassType PieceArchiveView PieceArchiveView PieceArchiveView Pointer
    // 028 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 PieceConversionConfirmedPopupViewFactory 0001867416F0 ModelClassType PieceConversionConfirmedPopupViewFactory PieceConversionConfirmedPopupViewFactory PieceConversionConfirmedPopupViewFactory Pointer
    // 038 PieceConversionCompletedPopupViewFactory 000186740180 ModelClassType PieceConversionCompletedPopupViewFactory PieceConversionCompletedPopupViewFactory PieceConversionCompletedPopupViewFactory Pointer
    public partial class PieceArchiveBuilder : DataModel
    {
        public PieceArchiveView?                        View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public PieceConversionConfirmedPopupViewFactory? PieceConversionConfirmedPopupViewFactory { get; set; }
        public PieceConversionCompletedPopupViewFactory? PieceConversionCompletedPopupViewFactory { get; set; }

        public static PieceArchiveBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchiveBuilder() { Pointer= p0 };

            value.View                                      = GetObject<PieceArchiveView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PieceArchiveView.FromPointer); // 02466B67BAE8 0x20 View                        ( 00018673EBF0 ModelClassType PieceArchiveView PieceArchiveView PieceArchiveView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B67BB08 0x28 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PieceConversionConfirmedPopupViewFactory  = GetObject<PieceConversionConfirmedPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.PieceConversionConfirmedPopupViewFactory.FromPointer); // 02466B67BB28 0x30 PieceConversionConfirmedPopupViewFactory ( 0001867416F0 ModelClassType PieceConversionConfirmedPopupViewFactory PieceConversionConfirmedPopupViewFactory PieceConversionConfirmedPopupViewFactory Pointer )
            value.PieceConversionCompletedPopupViewFactory  = GetObject<PieceConversionCompletedPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.PieceConversionCompletedPopupViewFactory.FromPointer); // 02466B67BB48 0x38 PieceConversionCompletedPopupViewFactory ( 000186740180 ModelClassType PieceConversionCompletedPopupViewFactory PieceConversionCompletedPopupViewFactory PieceConversionCompletedPopupViewFactory Pointer )

            return value;
        }
    }
}
