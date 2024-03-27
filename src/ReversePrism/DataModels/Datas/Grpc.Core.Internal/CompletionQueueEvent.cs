using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Native                                   NativeMethods IL2CPP_TYPE_CLASS
    // 010 Type                                     0001865126A0 ModelEnumType CompletionType CompletionType CompletionType Int32
    // 014 Success                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 tag                                      <int> IL2CPP_TYPE_I
    public partial class CompletionQueueEvent
    {
        public CompletionType                           Type                                    { get; set; }
        public int                                      Success                                 { get; set; }

        public static CompletionQueueEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompletionQueueEvent();

            value.Type                                      = (CompletionType)GetInt32(new IntPtr(p + 0x010)); // 0270D93AB868 0x10 Type                        ( 0001865126A0 ModelEnumType CompletionType CompletionType CompletionType Int32 )
            value.Success                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D93AB888 0x14 Success                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
