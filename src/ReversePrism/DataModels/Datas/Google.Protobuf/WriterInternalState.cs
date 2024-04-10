using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Limit                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Position                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 WriteBufferHelper                        0001866B6530 ModelEnumType WriteBufferHelper WriteBufferHelper WriteBufferHelper Int32
    public partial class WriterInternalState : DataModel
    {
        public int                                      Limit                                   { get; set; }
        public int                                      Position                                { get; set; }
        public WriteBufferHelper                        WriteBufferHelper                       { get; set; }

        public static WriterInternalState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriterInternalState() { Pointer= p0 };

            value.Limit                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A15FB318 0x10 Limit                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A15FB338 0x14 Position                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.WriteBufferHelper                         = (WriteBufferHelper)GetInt32(new IntPtr(p + 0x018)); // 0245A15FB358 0x18 WriteBufferHelper           ( 0001866B6530 ModelEnumType WriteBufferHelper WriteBufferHelper WriteBufferHelper Int32 )

            return value;
        }
    }
}
