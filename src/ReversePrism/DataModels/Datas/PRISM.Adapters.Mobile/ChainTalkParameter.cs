using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainGroupId                             0001865F4260 ModelPrimitiveType int int int Int32
    // 014 <ChainTalkId>k__BackingField             Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 01C NeedsShowMenuButton                      0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 ScrollPosition                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class ChainTalkParameter
    {
        public int                                      ChainGroupId                            { get; set; }
        public bool                                     NeedsShowMenuButton                     { get; set; }
        public float                                    ScrollPosition                          { get; set; }

        public static ChainTalkParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkParameter();

            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x010)); // 0270D6869A90 0x10 ChainGroupId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NeedsShowMenuButton                       = GetBool(new IntPtr(p + 0x01C)); // 0270D6869AD0 0x1C NeedsShowMenuButton         ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x020)); // 0270D6869AF0 0x20 ScrollPosition              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
