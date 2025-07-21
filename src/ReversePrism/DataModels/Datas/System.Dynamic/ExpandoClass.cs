using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Keys                                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 HashCode                                 ModelPrimitiveType int int int Int32
    // 020 _transitions                             Dictionary`2<int, List`1<WeakReference>> IL2CPP_TYPE_GENERICINST
    // 000 Empty                                    ExpandoClass IL2CPP_TYPE_CLASS
    public partial class ExpandoClass : DataModel
    {
        public List<string>?                            Keys                                    { get; set; }
        public int                                      HashCode                                { get; set; }

        public static ExpandoClass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpandoClass() { Pointer= p0 };

            value.Keys                                      = GetStringList(new IntPtr(p + 0x010)); // 0x10 Keys                        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HashCode                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
