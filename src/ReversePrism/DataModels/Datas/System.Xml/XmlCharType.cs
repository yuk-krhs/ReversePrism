using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Lock                                   <object> IL2CPP_TYPE_OBJECT
    // 008 s_CharProperties                         sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 CharProperties                           000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class XmlCharType
    {
        public List<sbyte>?                             CharProperties                          { get; set; }

        public static XmlCharType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlCharType();

            value.CharProperties                            = GetSByteList(new IntPtr(p + 0x010)); // 027004CC0290 0x10 CharProperties              ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
