using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 IsRead                                   ModelPrimitiveType bool bool bool Bool
    // 059 Apm                                      ModelPrimitiveType bool bool bool Bool
    // 060 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 068 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 Offset                                   ModelPrimitiveType int int int Int32
    // 074 Count                                    ModelPrimitiveType int int int Int32
    // 078 Callback                                 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 080 Context                                  ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 000 s_invokeAsyncCallback                    ContextCallback IL2CPP_TYPE_CLASS
    public partial class ReadWriteTask : DataModel
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
            var value   = new ReadWriteTask() { Pointer= p0 };

            value.IsRead                                    = GetBool(new IntPtr(p + 0x058)); // 0x58 IsRead                      ( ModelPrimitiveType bool bool bool Bool )
            value.Apm                                       = GetBool(new IntPtr(p + 0x059)); // 0x59 Apm                         ( ModelPrimitiveType bool bool bool Bool )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x060), ReversePrism.DataModels.Stream.FromPointer); // 0x60 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x068)); // 0x68 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x070)); // 0x70 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x074)); // 0x74 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Callback                                  = GetObject<AsyncCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0x78 Callback                    ( ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.Context                                   = GetObject<ExecutionContext>(new IntPtr(p + 0x080), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0x80 Context                     ( ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )

            return value;
        }
    }
}
