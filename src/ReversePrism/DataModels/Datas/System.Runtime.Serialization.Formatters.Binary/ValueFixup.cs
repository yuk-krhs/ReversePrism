using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ValueFixupEnum                           ModelEnumType ValueFixupEnum ValueFixupEnum ValueFixupEnum Int32
    // 018 ArrayObj                                 ModelClassType Array Array Array Pointer
    // 020 IndexMap                                 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 header                                   <object> IL2CPP_TYPE_OBJECT
    // 030 memberObject                             <object> IL2CPP_TYPE_OBJECT
    // 000 valueInfo                                MemberInfo IL2CPP_TYPE_CLASS
    // 038 ObjectInfo                               ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer
    // 040 MemberName                               ModelPrimitiveType string string string String
    public partial class ValueFixup : DataModel
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
            var value   = new ValueFixup() { Pointer= p0 };

            value.ValueFixupEnum                            = (ValueFixupEnum)GetInt32(new IntPtr(p + 0x010)); // 0x10 ValueFixupEnum              ( ModelEnumType ValueFixupEnum ValueFixupEnum ValueFixupEnum Int32 )
            value.ArrayObj                                  = GetObject<Array>(new IntPtr(p + 0x018), ReversePrism.DataModels.Array.FromPointer); // 0x18 ArrayObj                    ( ModelClassType Array Array Array Pointer )
            value.IndexMap                                  = GetInt32List(new IntPtr(p + 0x020)); // 0x20 IndexMap                    ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ObjectInfo                                = GetObject<ReadObjectInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.ReadObjectInfo.FromPointer); // 0x38 ObjectInfo                  ( ModelClassType ReadObjectInfo ReadObjectInfo ReadObjectInfo Pointer )
            value.MemberName                                = GetString(new IntPtr(p + 0x040)); // 0x40 MemberName                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
