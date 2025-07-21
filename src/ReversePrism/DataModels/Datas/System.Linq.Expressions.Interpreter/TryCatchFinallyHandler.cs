using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TryStartIndex                            ModelPrimitiveType int int int Int32
    // 014 TryEndIndex                              ModelPrimitiveType int int int Int32
    // 018 FinallyStartIndex                        ModelPrimitiveType int int int Int32
    // 01C FinallyEndIndex                          ModelPrimitiveType int int int Int32
    // 020 GotoEndTargetIndex                       ModelPrimitiveType int int int Int32
    // 028 Handlers                                 ModelClassListType ExceptionHandler[] ExceptionHandler[] List<ExceptionHandler> Pointer
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

            value.TryStartIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 TryStartIndex               ( ModelPrimitiveType int int int Int32 )
            value.TryEndIndex                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 TryEndIndex                 ( ModelPrimitiveType int int int Int32 )
            value.FinallyStartIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 FinallyStartIndex           ( ModelPrimitiveType int int int Int32 )
            value.FinallyEndIndex                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C FinallyEndIndex             ( ModelPrimitiveType int int int Int32 )
            value.GotoEndTargetIndex                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 GotoEndTargetIndex          ( ModelPrimitiveType int int int Int32 )
            value.Handlers                                  = GetObjectList<ExceptionHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExceptionHandler.FromPointer); // 0x28 Handlers                    ( ModelClassListType ExceptionHandler[] ExceptionHandler[] List<ExceptionHandler> Pointer )

            return value;
        }
    }
}
