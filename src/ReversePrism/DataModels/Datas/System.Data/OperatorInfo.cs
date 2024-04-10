using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866A5A50 ModelEnumType Nodes Nodes Nodes Int32
    // 014 Op                                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Priority                                 0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.Type                                      = (Nodes)GetInt32(new IntPtr(p + 0x010)); // 024668996A48 0x10 Type                        ( 0001866A5A50 ModelEnumType Nodes Nodes Nodes Int32 )
            value.Op                                        = GetInt32(new IntPtr(p + 0x014)); // 024668996A68 0x14 Op                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x018)); // 024668996A88 0x18 Priority                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
