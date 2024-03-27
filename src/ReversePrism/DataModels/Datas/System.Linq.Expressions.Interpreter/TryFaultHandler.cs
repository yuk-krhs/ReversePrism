using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TryStartIndex                            0001865F44E0 ModelPrimitiveType int int int Int32
    // 014 TryEndIndex                              0001865F44E0 ModelPrimitiveType int int int Int32
    // 018 FinallyStartIndex                        0001865F44E0 ModelPrimitiveType int int int Int32
    // 01C FinallyEndIndex                          0001865F44E0 ModelPrimitiveType int int int Int32
    public partial class TryFaultHandler
    {
        public int                                      TryStartIndex                           { get; set; }
        public int                                      TryEndIndex                             { get; set; }
        public int                                      FinallyStartIndex                       { get; set; }
        public int                                      FinallyEndIndex                         { get; set; }

        public static TryFaultHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TryFaultHandler();

            value.TryStartIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0270D9FA4F30 0x10 TryStartIndex               ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.TryEndIndex                               = GetInt32(new IntPtr(p + 0x014)); // 0270D9FA4F50 0x14 TryEndIndex                 ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.FinallyStartIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0270D9FA4F70 0x18 FinallyStartIndex           ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.FinallyEndIndex                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D9FA4F90 0x1C FinallyEndIndex             ( 0001865F44E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
