using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Producers                                ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 Consumers                                ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 RefCount                                 ModelPrimitiveType int int int Int32
    // 024 Imported                                 ModelPrimitiveType bool bool bool Bool
    public partial class CompiledResourceInfo : DataModel
    {
        public List<int>?                               Producers                               { get; set; }
        public List<int>?                               Consumers                               { get; set; }
        public int                                      RefCount                                { get; set; }
        public bool                                     Imported                                { get; set; }

        public static CompiledResourceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompiledResourceInfo() { Pointer= p0 };

            value.Producers                                 = GetInt32List(new IntPtr(p + 0x010)); // 0x10 Producers                   ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Consumers                                 = GetInt32List(new IntPtr(p + 0x018)); // 0x18 Consumers                   ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 RefCount                    ( ModelPrimitiveType int int int Int32 )
            value.Imported                                  = GetBool(new IntPtr(p + 0x024)); // 0x24 Imported                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
