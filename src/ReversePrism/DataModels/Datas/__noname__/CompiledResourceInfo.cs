using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Producers                                000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 Consumers                                000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 RefCount                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Imported                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CompiledResourceInfo
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
            var value   = new CompiledResourceInfo();

            value.Producers                                 = GetInt32List(new IntPtr(p + 0x010)); // 0270D9094E70 0x10 Producers                   ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Consumers                                 = GetInt32List(new IntPtr(p + 0x018)); // 0270D9094E90 0x18 Consumers                   ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D9094EB0 0x20 RefCount                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Imported                                  = GetBool(new IntPtr(p + 0x024)); // 0270D9094ED0 0x24 Imported                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
