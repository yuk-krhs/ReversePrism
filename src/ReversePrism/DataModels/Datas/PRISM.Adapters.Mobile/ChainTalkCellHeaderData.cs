using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainUserId                              ModelPrimitiveType int int int Int32
    // 014 ChainGroupId                             ModelPrimitiveType int int int Int32
    // 018 TalkerName                               ModelPrimitiveType string string string String
    // 020 IconAssetKey                             ModelPrimitiveType string string string String
    // 028 IsIconClickable                          ModelPrimitiveType bool bool bool Bool
    public partial class ChainTalkCellHeaderData : DataModel
    {
        public int                                      ChainUserId                             { get; set; }
        public int                                      ChainGroupId                            { get; set; }
        public string                                   TalkerName                              { get; set; }
        public string                                   IconAssetKey                            { get; set; }
        public bool                                     IsIconClickable                         { get; set; }

        public static ChainTalkCellHeaderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellHeaderData() { Pointer= p0 };

            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 ChainUserId                 ( ModelPrimitiveType int int int Int32 )
            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 ChainGroupId                ( ModelPrimitiveType int int int Int32 )
            value.TalkerName                                = GetString(new IntPtr(p + 0x018)); // 0x18 TalkerName                  ( ModelPrimitiveType string string string String )
            value.IconAssetKey                              = GetString(new IntPtr(p + 0x020)); // 0x20 IconAssetKey                ( ModelPrimitiveType string string string String )
            value.IsIconClickable                           = GetBool(new IntPtr(p + 0x028)); // 0x28 IsIconClickable             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
