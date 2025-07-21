using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParamMap                                 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 InoutArgCount                            ModelPrimitiveType int int int Int32
    // 020 Method                                   ModelClassType MethodBase MethodBase MethodBase Pointer
    public partial class ArgInfo : DataModel
    {
        public List<int>?                               ParamMap                                { get; set; }
        public int                                      InoutArgCount                           { get; set; }
        public MethodBase?                              Method                                  { get; set; }

        public static ArgInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArgInfo() { Pointer= p0 };

            value.ParamMap                                  = GetInt32List(new IntPtr(p + 0x010)); // 0x10 ParamMap                    ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.InoutArgCount                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 InoutArgCount               ( ModelPrimitiveType int int int Int32 )
            value.Method                                    = GetObject<MethodBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodBase.FromPointer); // 0x20 Method                      ( ModelClassType MethodBase MethodBase MethodBase Pointer )

            return value;
        }
    }
}
