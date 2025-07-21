using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VarintList                               ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer
    // 018 Fixed32List                              ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 020 Fixed64List                              ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer
    // 028 LengthDelimitedList                      ModelClassListType List`1<ByteString> List`1<ByteString> List<ByteString> Pointer
    // 030 GroupList                                ModelClassListType List`1<UnknownFieldSet> List`1<UnknownFieldSet> List<UnknownFieldSet> Pointer
    public partial class UnknownField : DataModel
    {
        public List<ulong>?                             VarintList                              { get; set; }
        public List<uint>?                              Fixed32List                             { get; set; }
        public List<ulong>?                             Fixed64List                             { get; set; }
        public List<ByteString>?                        LengthDelimitedList                     { get; set; }
        public List<UnknownFieldSet>?                   GroupList                               { get; set; }

        public static UnknownField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnknownField() { Pointer= p0 };

            value.VarintList                                = GetUInt64List(new IntPtr(p + 0x010)); // 0x10 VarintList                  ( ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer )
            value.Fixed32List                               = GetUInt32List(new IntPtr(p + 0x018)); // 0x18 Fixed32List                 ( ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.Fixed64List                               = GetUInt64List(new IntPtr(p + 0x020)); // 0x20 Fixed64List                 ( ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer )
            value.LengthDelimitedList                       = GetObjectList<ByteString>(new IntPtr(p + 0x028), ReversePrism.DataModels.ByteString.FromPointer); // 0x28 LengthDelimitedList         ( ModelClassListType List`1<ByteString> List`1<ByteString> List<ByteString> Pointer )
            value.GroupList                                 = GetObjectList<UnknownFieldSet>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnknownFieldSet.FromPointer); // 0x30 GroupList                   ( ModelClassListType List`1<UnknownFieldSet> List`1<UnknownFieldSet> List<UnknownFieldSet> Pointer )

            return value;
        }
    }
}
