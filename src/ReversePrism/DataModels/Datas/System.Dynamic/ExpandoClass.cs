using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Keys                                     000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 HashCode                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 020 _transitions                             Dictionary`2<int, List`1<WeakReference>> IL2CPP_TYPE_GENERICINST
    // 000 Empty                                    ExpandoClass IL2CPP_TYPE_CLASS
    public partial class ExpandoClass
    {
        public List<string>?                            Keys                                    { get; set; }
        public int                                      HashCode                                { get; set; }

        public static ExpandoClass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpandoClass();

            value.Keys                                      = GetStringList(new IntPtr(p + 0x010)); // 0270DA06CAF0 0x10 Keys                        ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x018)); // 0270DA06CB10 0x18 HashCode                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
