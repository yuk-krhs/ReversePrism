using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisableSuccess                           ModelPrimitiveType bool bool bool Bool
    // 014 OldMode                                  ModelPrimitiveType uint uint uint UInt32
    // 000 useUWPFallback                           bool IL2CPP_TYPE_BOOLEAN
    public partial class DisableMediaInsertionPrompt : DataModel
    {
        public bool                                     DisableSuccess                          { get; set; }
        public uint                                     OldMode                                 { get; set; }

        public static DisableMediaInsertionPrompt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisableMediaInsertionPrompt() { Pointer= p0 };

            value.DisableSuccess                            = GetBool(new IntPtr(p + 0x010)); // 0x10 DisableSuccess              ( ModelPrimitiveType bool bool bool Bool )
            value.OldMode                                   = GetUInt32(new IntPtr(p + 0x014)); // 0x14 OldMode                     ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
