using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StateMachineType                         0001866936B0 ModelClassType Type Type Type Pointer
    public partial class StateMachineAttribute : DataModel
    {
        public Type?                                    StateMachineType                        { get; set; }

        public static StateMachineAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateMachineAttribute() { Pointer= p0 };

            value.StateMachineType                          = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0245A4D52040 0x10 StateMachineType            ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
