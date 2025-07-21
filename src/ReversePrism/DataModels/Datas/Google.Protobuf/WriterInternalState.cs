using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Limit                                    ModelPrimitiveType int int int Int32
    // 014 Position                                 ModelPrimitiveType int int int Int32
    // 018 WriteBufferHelper                        ModelEnumType WriteBufferHelper WriteBufferHelper WriteBufferHelper Int32
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

            value.Limit                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Limit                       ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 Position                    ( ModelPrimitiveType int int int Int32 )
            value.WriteBufferHelper                         = (WriteBufferHelper)GetInt32(new IntPtr(p + 0x018)); // 0x18 WriteBufferHelper           ( ModelEnumType WriteBufferHelper WriteBufferHelper WriteBufferHelper Int32 )

            return value;
        }
    }
}
