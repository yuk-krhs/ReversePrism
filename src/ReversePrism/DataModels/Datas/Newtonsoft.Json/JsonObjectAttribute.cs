using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 MemberSerialization                      0001865F42A0 ModelEnumType MemberSerialization MemberSerialization MemberSerialization Int32
    // 06C _missingMemberHandling                   Nullable`1<MissingMemberHandling> IL2CPP_TYPE_GENERICINST
    // 074 _itemRequired                            Nullable`1<Required> IL2CPP_TYPE_GENERICINST
    // 07C _itemNullValueHandling                   Nullable`1<NullValueHandling> IL2CPP_TYPE_GENERICINST
    public partial class JsonObjectAttribute
    {
        public MemberSerialization                      MemberSerialization                     { get; set; }

        public static JsonObjectAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonObjectAttribute();

            value.MemberSerialization                       = (MemberSerialization)GetInt32(new IntPtr(p + 0x068)); // 027005FE8288 0x68 MemberSerialization         ( 0001865F42A0 ModelEnumType MemberSerialization MemberSerialization MemberSerialization Int32 )

            return value;
        }
    }
}
