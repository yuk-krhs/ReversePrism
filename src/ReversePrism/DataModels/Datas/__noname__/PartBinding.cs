using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Part                                     ModelPrimitiveType int int int Int32
    // 018 Control                                  ModelClassType InputControl InputControl InputControl Pointer
    public partial class PartBinding : DataModel
    {
        public int                                      Part                                    { get; set; }
        public InputControl?                            Control                                 { get; set; }

        public static PartBinding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PartBinding() { Pointer= p0 };

            value.Part                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Part                        ( ModelPrimitiveType int int int Int32 )
            value.Control                                   = GetObject<InputControl>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputControl.FromPointer); // 0x18 Control                     ( ModelClassType InputControl InputControl InputControl Pointer )

            return value;
        }
    }
}
