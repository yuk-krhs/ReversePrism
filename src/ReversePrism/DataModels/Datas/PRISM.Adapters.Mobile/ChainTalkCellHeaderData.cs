using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainUserId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 ChainGroupId                             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 TalkerName                               000186672F10 ModelPrimitiveType string string string String
    // 020 IconAssetKey                             000186672F10 ModelPrimitiveType string string string String
    // 028 IsIconClickable                          0001865965D0 ModelPrimitiveType bool bool bool Bool
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

            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x010)); // 0246668C6BD8 0x10 ChainUserId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x014)); // 0246668C6BF8 0x14 ChainGroupId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TalkerName                                = GetString(new IntPtr(p + 0x018)); // 0246668C6C18 0x18 TalkerName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.IconAssetKey                              = GetString(new IntPtr(p + 0x020)); // 0246668C6C38 0x20 IconAssetKey                ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsIconClickable                           = GetBool(new IntPtr(p + 0x028)); // 0246668C6C58 0x28 IsIconClickable             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
