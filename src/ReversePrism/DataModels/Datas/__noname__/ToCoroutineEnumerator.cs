using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Completed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Task                                     00018669FD00 ModelEnumType UniTask UniTask UniTask Int32
    // 028 exceptionHandler                         Action`1<Exception> IL2CPP_TYPE_GENERICINST
    // 030 IsStarted                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Exception                                0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    public partial class ToCoroutineEnumerator : DataModel
    {
        public bool                                     Completed                               { get; set; }
        public UniTask                                  Task                                    { get; set; }
        public bool                                     IsStarted                               { get; set; }
        public ExceptionDispatchInfo?                   Exception                               { get; set; }

        public static ToCoroutineEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToCoroutineEnumerator() { Pointer= p0 };

            value.Completed                                 = GetBool(new IntPtr(p + 0x010)); // 024668EFC790 0x10 Completed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Task                                      = (UniTask)GetInt32(new IntPtr(p + 0x018)); // 024668EFC7B0 0x18 Task                        ( 00018669FD00 ModelEnumType UniTask UniTask UniTask Int32 )
            value.IsStarted                                 = GetBool(new IntPtr(p + 0x030)); // 024668EFC7F0 0x30 IsStarted                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Exception                                 = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 024668EFC810 0x38 Exception                   ( 0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )

            return value;
        }
    }
}
