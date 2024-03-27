using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 NormalCellSize                           0001866656B0 ModelPrimitiveType float float float Single
    // 06C MoreButtonCellSize                       0001866656B0 ModelPrimitiveType float float float Single
    public partial class AnnounceListView
    {
        public float                                    NormalCellSize                          { get; set; }
        public float                                    MoreButtonCellSize                      { get; set; }

        public static AnnounceListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceListView();

            value.NormalCellSize                            = GetSingle(new IntPtr(p + 0x068)); // 0270DBDD9EE8 0x68 NormalCellSize              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MoreButtonCellSize                        = GetSingle(new IntPtr(p + 0x06C)); // 0270DBDD9F08 0x6C MoreButtonCellSize          ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
