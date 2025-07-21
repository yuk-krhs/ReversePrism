using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InitialSize                              int IL2CPP_TYPE_I4
    // 010 runningAndQueueLock                      <object> IL2CPP_TYPE_OBJECT
    // 018 arrayLock                                <object> IL2CPP_TYPE_OBJECT
    // 020 unhandledExceptionCallback               Action`1<Exception> IL2CPP_TYPE_GENERICINST
    // 028 Tail                                     ModelPrimitiveType int int int Int32
    // 02C Running                                  ModelPrimitiveType bool bool bool Bool
    // 030 Coroutines                               ModelClassListType IEnumerator[] IEnumerator[] List<IEnumerator> Pointer
    // 038 waitQueue                                Queue`1<IEnumerator> IL2CPP_TYPE_GENERICINST
    public partial class MicroCoroutine : DataModel
    {
        public int                                      Tail                                    { get; set; }
        public bool                                     Running                                 { get; set; }
        public List<IEnumerator>?                       Coroutines                              { get; set; }

        public static MicroCoroutine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MicroCoroutine() { Pointer= p0 };

            value.Tail                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Tail                        ( ModelPrimitiveType int int int Int32 )
            value.Running                                   = GetBool(new IntPtr(p + 0x02C)); // 0x2C Running                     ( ModelPrimitiveType bool bool bool Bool )
            value.Coroutines                                = GetObjectList<IEnumerator>(new IntPtr(p + 0x030), ReversePrism.DataModels.IEnumerator.FromPointer); // 0x30 Coroutines                  ( ModelClassListType IEnumerator[] IEnumerator[] List<IEnumerator> Pointer )

            return value;
        }
    }
}
