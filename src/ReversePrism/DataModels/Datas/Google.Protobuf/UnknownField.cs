using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VarintList                               000185D19418 ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer
    // 018 Fixed32List                              000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer
    // 020 Fixed64List                              000185D19418 ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer
    // 028 LengthDelimitedList                      000185CD0C68 ModelClassListType List`1<ByteString> List`1<ByteString> List<ByteString> Pointer
    // 030 GroupList                                000185D1A098 ModelClassListType List`1<UnknownFieldSet> List`1<UnknownFieldSet> List<UnknownFieldSet> Pointer
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

            value.VarintList                                = GetUInt64List(new IntPtr(p + 0x010)); // 02466A48C7F0 0x10 VarintList                  ( 000185D19418 ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer )
            value.Fixed32List                               = GetUInt32List(new IntPtr(p + 0x018)); // 02466A48C810 0x18 Fixed32List                 ( 000185D191C8 ModelPrimitiveListType List`1<uint> List`1<uint> List<uint> Pointer )
            value.Fixed64List                               = GetUInt64List(new IntPtr(p + 0x020)); // 02466A48C830 0x20 Fixed64List                 ( 000185D19418 ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer )
            value.LengthDelimitedList                       = GetObjectList<ByteString>(new IntPtr(p + 0x028), ReversePrism.DataModels.ByteString.FromPointer); // 02466A48C850 0x28 LengthDelimitedList         ( 000185CD0C68 ModelClassListType List`1<ByteString> List`1<ByteString> List<ByteString> Pointer )
            value.GroupList                                 = GetObjectList<UnknownFieldSet>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnknownFieldSet.FromPointer); // 02466A48C870 0x30 GroupList                   ( 000185D1A098 ModelClassListType List`1<UnknownFieldSet> List`1<UnknownFieldSet> List<UnknownFieldSet> Pointer )

            return value;
        }
    }
}
