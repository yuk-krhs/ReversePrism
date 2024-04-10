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

            value.NormalCellSize                            = GetSingle(new IntPtr(p + 0x068)); // 02466BE61880 0x68 NormalCellSize              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MoreButtonCellSize                        = GetSingle(new IntPtr(p + 0x06C)); // 02466BE618A0 0x6C MoreButtonCellSize          ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
