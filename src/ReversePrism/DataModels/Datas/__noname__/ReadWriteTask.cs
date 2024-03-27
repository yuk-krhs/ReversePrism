using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 IsRead                                   000186596860 ModelPrimitiveType bool bool bool Bool
    // 059 Apm                                      000186596860 ModelPrimitiveType bool bool bool Bool
    // 060 Stream                                   000186670490 ModelClassType Stream Stream Stream Pointer
    // 068 Buffer                                   000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 Offset                                   0001865F44E0 ModelPrimitiveType int int int Int32
    // 074 Count                                    0001865F44E0 ModelPrimitiveType int int int Int32
    // 078 Callback                                 0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 080 Context                                  0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 000 s_invokeAsyncCallback                    ContextCallback IL2CPP_TYPE_CLASS
    public partial class ReadWriteTask
    {
        public bool                                     IsRead                                  { get; set; }
        public bool                                     Apm                                     { get; set; }
        public Stream?                                  Stream                                  { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public AsyncCallback?                           Callback                                { get; set; }
        public ExecutionContext?                        Context                                 { get; set; }

        public static ReadWriteTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadWriteTask();

            value.IsRead                                    = GetBool(new IntPtr(p + 0x058)); // 0270D6E3BE10 0x58 IsRead                      ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.Apm                                       = GetBool(new IntPtr(p + 0x059)); // 0270D6E3BE30 0x59 Apm                         ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x060), ReversePrism.DataModels.Stream.FromPointer); // 0270D6E3BE50 0x60 Stream                      ( 000186670490 ModelClassType Stream Stream Stream Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x068)); // 0270D6E3BE70 0x68 Buffer                      ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x070)); // 0270D6E3BE90 0x70 Offset                      ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x074)); // 0270D6E3BEB0 0x74 Count                       ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.Callback                                  = GetObject<AsyncCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0270D6E3BED0 0x78 Callback                    ( 0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.Context                                   = GetObject<ExecutionContext>(new IntPtr(p + 0x080), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0270D6E3BEF0 0x80 Context                     ( 0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )

            return value;
        }
    }
}
