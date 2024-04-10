using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Order                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Callback                                 000186711FA0 ModelClassType UnityAction UnityAction UnityAction Pointer
    public partial class OrderBlock : DataModel
    {
        public int                                      Order                                   { get; set; }
        public UnityAction?                             Callback                                { get; set; }

        public static OrderBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrderBlock() { Pointer= p0 };

            value.Order                                     = GetInt32(new IntPtr(p + 0x010)); // 024660974818 0x10 Order                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Callback                                  = GetObject<UnityAction>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityAction.FromPointer); // 024660974838 0x18 Callback                    ( 000186711FA0 ModelClassType UnityAction UnityAction UnityAction Pointer )

            return value;
        }
    }
}
