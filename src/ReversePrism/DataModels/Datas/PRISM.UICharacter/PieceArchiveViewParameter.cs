using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TabType                                  00018673E510 ModelEnumType PieceArchiveTabType PieceArchiveTabType PieceArchiveTabType Int32
    public partial class PieceArchiveViewParameter : DataModel
    {
        public PieceArchiveTabType                      TabType                                 { get; set; }

        public static PieceArchiveViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchiveViewParameter() { Pointer= p0 };

            value.TabType                                   = (PieceArchiveTabType)GetInt32(new IntPtr(p + 0x010)); // 024665E218D0 0x10 TabType                     ( 00018673E510 ModelEnumType PieceArchiveTabType PieceArchiveTabType PieceArchiveTabType Int32 )

            return value;
        }
    }
}
