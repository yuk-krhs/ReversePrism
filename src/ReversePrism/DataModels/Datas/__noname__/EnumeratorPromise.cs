using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<EnumeratorPromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 ModelClassType EnumeratorPromise EnumeratorPromise EnumeratorPromise Pointer
    // 018 InnerEnumerator                          ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 020 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 InitialFrame                             ModelPrimitiveType int int int Int32
    // 02C LoopRunning                              ModelPrimitiveType bool bool bool Bool
    // 02D CalledGetResult                          ModelPrimitiveType bool bool bool Bool
    // 030 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 WaitForSeconds_Seconds                   ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    public partial class EnumeratorPromise : DataModel
    {
        public EnumeratorPromise?                       NextNode                                { get; set; }
        public IEnumerator?                             InnerEnumerator                         { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public bool                                     LoopRunning                             { get; set; }
        public bool                                     CalledGetResult                         { get; set; }
        public FieldInfo?                               WaitForSeconds_Seconds                  { get; set; }

        public static EnumeratorPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumeratorPromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<EnumeratorPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.EnumeratorPromise.FromPointer); // 0x10 NextNode                    ( ModelClassType EnumeratorPromise EnumeratorPromise EnumeratorPromise Pointer )
            value.InnerEnumerator                           = GetObject<IEnumerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEnumerator.FromPointer); // 0x18 InnerEnumerator             ( ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 InitialFrame                ( ModelPrimitiveType int int int Int32 )
            value.LoopRunning                               = GetBool(new IntPtr(p + 0x02C)); // 0x2C LoopRunning                 ( ModelPrimitiveType bool bool bool Bool )
            value.CalledGetResult                           = GetBool(new IntPtr(p + 0x02D)); // 0x2D CalledGetResult             ( ModelPrimitiveType bool bool bool Bool )
            value.WaitForSeconds_Seconds                    = GetObject<FieldInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.FieldInfo.FromPointer); // 0x10 WaitForSeconds_Seconds      ( ModelClassType FieldInfo FieldInfo FieldInfo Pointer )

            return value;
        }
    }
}
