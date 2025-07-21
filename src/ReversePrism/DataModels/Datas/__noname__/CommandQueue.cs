using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType CommandType CommandType CommandType Int32
    // 014 DelayFrame                               ModelPrimitiveType float float float Single
    // 018 Param1                                   ModelPrimitiveType int int int Int32
    // 01C Param2                                   ModelPrimitiveType int int int Int32
    // 020 Param3                                   ModelPrimitiveType int int int Int32
    // 024 Frame                                    ModelPrimitiveType float float float Single
    public partial class CommandQueue : DataModel
    {
        public CommandType                              Type                                    { get; set; }
        public float                                    DelayFrame                              { get; set; }
        public int                                      Param1                                  { get; set; }
        public int                                      Param2                                  { get; set; }
        public int                                      Param3                                  { get; set; }
        public float                                    Frame                                   { get; set; }

        public static CommandQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommandQueue() { Pointer= p0 };

            value.Type                                      = (CommandType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType CommandType CommandType CommandType Int32 )
            value.DelayFrame                                = GetSingle(new IntPtr(p + 0x014)); // 0x14 DelayFrame                  ( ModelPrimitiveType float float float Single )
            value.Param1                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Param1                      ( ModelPrimitiveType int int int Int32 )
            value.Param2                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Param2                      ( ModelPrimitiveType int int int Int32 )
            value.Param3                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Param3                      ( ModelPrimitiveType int int int Int32 )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x024)); // 0x24 Frame                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
