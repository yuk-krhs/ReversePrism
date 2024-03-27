using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ValueFixupEnum                           000186768300 ModelEnumType ValueFixupEnum ValueFixupEnum ValueFixupEnum Int32
    // 018 ArrayObj                                 000186589620 ModelClassType Array Array Array Pointer
    // 020 IndexMap                                 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 header                                   <object> IL2CPP_TYPE_OBJECT
    // 030 memberObject                             <object> IL2CPP_TYPE_OBJECT
    // 000 valueInfo                                MemberInfo IL2CPP_TYPE_CLASS
    // 038 ObjectInfo                               0001866181E0 ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer
    // 040 MemberName                               000186671BA0 ModelPrimitiveType string string string String
    public partial class ValueFixup
    {
        public ValueFixupEnum                           ValueFixupEnum                          { get; set; }
        public Array?                                   ArrayObj                                { get; set; }
        public List<int>?                               IndexMap                                { get; set; }
        public ReadObjectInfo?                          ObjectInfo                              { get; set; }
        public string                                   MemberName                              { get; set; }

        public static ValueFixup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueFixup();

            value.ValueFixupEnum                            = (ValueFixupEnum)GetInt32(new IntPtr(p + 0x010)); // 0270D6C595D0 0x10 ValueFixupEnum              ( 000186768300 ModelEnumType ValueFixupEnum ValueFixupEnum ValueFixupEnum Int32 )
            value.ArrayObj                                  = GetObject<Array>(new IntPtr(p + 0x018), ReversePrism.DataModels.Array.FromPointer); // 0270D6C595F0 0x18 ArrayObj                    ( 000186589620 ModelClassType Array Array Array Pointer )
            value.IndexMap                                  = GetInt32List(new IntPtr(p + 0x020)); // 0270D6C59610 0x20 IndexMap                    ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ObjectInfo                                = GetObject<ReadObjectInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.ReadObjectInfo.FromPointer); // 0270D6C59690 0x38 ObjectInfo                  ( 0001866181E0 ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer )
            value.MemberName                                = GetString(new IntPtr(p + 0x040)); // 0270D6C596B0 0x40 MemberName                  ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
