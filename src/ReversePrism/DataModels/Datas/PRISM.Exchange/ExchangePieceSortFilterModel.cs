using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 PieceType                                ModelEnumType ProductType ProductType ProductType Int32
    public partial class ExchangePieceSortFilterModel : DataModel
    {
        public ProductType                              PieceType                               { get; set; }

        public static ExchangePieceSortFilterModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePieceSortFilterModel() { Pointer= p0 };

            value.PieceType                                 = (ProductType)GetInt32(new IntPtr(p + 0x050)); // 0x50 PieceType                   ( ModelEnumType ProductType ProductType ProductType Int32 )

            return value;
        }
    }
}
