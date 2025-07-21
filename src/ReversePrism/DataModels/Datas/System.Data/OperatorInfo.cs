using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType Nodes Nodes Nodes Int32
    // 014 Op                                       ModelPrimitiveType int int int Int32
    // 018 Priority                                 ModelPrimitiveType int int int Int32
    public partial class OperatorInfo : DataModel
    {
        public Nodes                                    Type                                    { get; set; }
        public int                                      Op                                      { get; set; }
        public int                                      Priority                                { get; set; }

        public static OperatorInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OperatorInfo() { Pointer= p0 };

            value.Type                                      = (Nodes)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType Nodes Nodes Nodes Int32 )
            value.Op                                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 Op                          ( ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Priority                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
