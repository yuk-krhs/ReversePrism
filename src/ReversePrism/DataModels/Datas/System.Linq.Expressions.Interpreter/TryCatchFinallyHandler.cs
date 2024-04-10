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
    // 020 GotoEndTargetIndex                       0001865F44E0 ModelPrimitiveType int int int Int32
    // 028 Handlers                                 000185B7CF50 ModelClassListType ExceptionHandler[] ExceptionHandler[] List<ExceptionHandler> Pointer
    public partial class TryCatchFinallyHandler : DataModel
    {
        public int                                      TryStartIndex                           { get; set; }
        public int                                      TryEndIndex                             { get; set; }
        public int                                      FinallyStartIndex                       { get; set; }
        public int                                      FinallyEndIndex                         { get; set; }
        public int                                      GotoEndTargetIndex                      { get; set; }
        public List<ExceptionHandler>?                  Handlers                                { get; set; }

        public static TryCatchFinallyHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TryCatchFinallyHandler() { Pointer= p0 };

            value.TryStartIndex                             = GetInt32(new IntPtr(p + 0x010)); // 02466A010468 0x10 TryStartIndex               ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.TryEndIndex                               = GetInt32(new IntPtr(p + 0x014)); // 02466A010488 0x14 TryEndIndex                 ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.FinallyStartIndex                         = GetInt32(new IntPtr(p + 0x018)); // 02466A0104A8 0x18 FinallyStartIndex           ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.FinallyEndIndex                           = GetInt32(new IntPtr(p + 0x01C)); // 02466A0104C8 0x1C FinallyEndIndex             ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.GotoEndTargetIndex                        = GetInt32(new IntPtr(p + 0x020)); // 02466A0104E8 0x20 GotoEndTargetIndex          ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.Handlers                                  = GetObjectList<ExceptionHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExceptionHandler.FromPointer); // 02466A010508 0x28 Handlers                    ( 000185B7CF50 ModelClassListType ExceptionHandler[] ExceptionHandler[] List<ExceptionHandler> Pointer )

            return value;
        }
    }
}
