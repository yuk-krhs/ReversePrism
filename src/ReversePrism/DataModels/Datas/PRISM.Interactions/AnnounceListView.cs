using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 NormalCellSize                           ModelPrimitiveType float float float Single
    // 05C MoreButtonCellSize                       ModelPrimitiveType float float float Single
    public partial class AnnounceListView : DataModel
    {
        public float                                    NormalCellSize                          { get; set; }
        public float                                    MoreButtonCellSize                      { get; set; }

        public static AnnounceListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceListView() { Pointer= p0 };

            value.NormalCellSize                            = GetSingle(new IntPtr(p + 0x058)); // 0x58 NormalCellSize              ( ModelPrimitiveType float float float Single )
            value.MoreButtonCellSize                        = GetSingle(new IntPtr(p + 0x05C)); // 0x5C MoreButtonCellSize          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
