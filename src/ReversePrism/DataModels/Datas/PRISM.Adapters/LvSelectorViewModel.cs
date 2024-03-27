using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 014 CurrentLv                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MaxLv                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C LvRange                                  0001865C1F60 ModelEnumType LvRange LvRange LvRange Int32
    public partial class LvSelectorViewModel
    {
        public int                                      TargetLv                                { get; set; }
        public int                                      CurrentLv                               { get; set; }
        public int                                      MaxLv                                   { get; set; }
        public LvRange                                  LvRange                                 { get; set; }

        public static LvSelectorViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LvSelectorViewModel();

            value.TargetLv                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D6118DB8 0x10 TargetLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrentLv                                 = GetInt32(new IntPtr(p + 0x014)); // 0270D6118DD8 0x14 CurrentLv                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxLv                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D6118DF8 0x18 MaxLv                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LvRange                                   = (LvRange)GetInt32(new IntPtr(p + 0x01C)); // 0270D6118E18 0x1C LvRange                     ( 0001865C1F60 ModelEnumType LvRange LvRange LvRange Int32 )

            return value;
        }
    }
}
