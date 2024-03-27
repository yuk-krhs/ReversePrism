using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentValue                             0001865F4940 ModelPrimitiveType int int int Int32
    // 014 AddValue                                 0001865F4940 ModelPrimitiveType int int int Int32
    public partial class IdolLevelUpParamViewModel
    {
        public int                                      CurrentValue                            { get; set; }
        public int                                      AddValue                                { get; set; }

        public static IdolLevelUpParamViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLevelUpParamViewModel();

            value.CurrentValue                              = GetInt32(new IntPtr(p + 0x010)); // 0270D4C52C70 0x10 CurrentValue                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.AddValue                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D4C52C90 0x14 AddValue                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
