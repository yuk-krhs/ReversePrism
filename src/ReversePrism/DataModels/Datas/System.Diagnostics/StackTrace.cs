using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 METHODS_TO_SKIP                          int IL2CPP_TYPE_I4
    // 000 prefix                                   string IL2CPP_TYPE_STRING
    // 010 Frames                                   000185CA6A88 ModelClassListType StackFrame[] StackFrame[] List<StackFrame> Pointer
    // 018 Captured_traces                          000185CA6C88 ModelClassListType StackTrace[] StackTrace[] List<StackTrace> Pointer
    // 020 Debug_info                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 isAotidSet                               bool IL2CPP_TYPE_BOOLEAN
    // 008 aotid                                    string IL2CPP_TYPE_STRING
    public partial class StackTrace : DataModel
    {
        public List<StackFrame>?                        Frames                                  { get; set; }
        public List<StackTrace>?                        Captured_traces                         { get; set; }
        public bool                                     Debug_info                              { get; set; }

        public static StackTrace? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackTrace() { Pointer= p0 };

            value.Frames                                    = GetObjectList<StackFrame>(new IntPtr(p + 0x010), ReversePrism.DataModels.StackFrame.FromPointer); // 0245A32DBE68 0x10 Frames                      ( 000185CA6A88 ModelClassListType StackFrame[] StackFrame[] List<StackFrame> Pointer )
            value.Captured_traces                           = GetObjectList<StackTrace>(new IntPtr(p + 0x018), ReversePrism.DataModels.StackTrace.FromPointer); // 0245A32DBE88 0x18 Captured_traces             ( 000185CA6C88 ModelClassListType StackTrace[] StackTrace[] List<StackTrace> Pointer )
            value.Debug_info                                = GetBool(new IntPtr(p + 0x020)); // 0245A32DBEA8 0x20 Debug_info                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
