using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFlags                                  000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 018 Values                                   000185B848F0 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 020 Names                                    000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 ResolvedNames                            000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class EnumInfo : DataModel
    {
        public bool                                     IsFlags                                 { get; set; }
        public List<ulong>?                             Values                                  { get; set; }
        public List<string>?                            Names                                   { get; set; }
        public List<string>?                            ResolvedNames                           { get; set; }

        public static EnumInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumInfo() { Pointer= p0 };

            value.IsFlags                                   = GetBool(new IntPtr(p + 0x010)); // 0245A665F7D8 0x10 IsFlags                     ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.Values                                    = GetUInt64List(new IntPtr(p + 0x018)); // 0245A665F7F8 0x18 Values                      ( 000185B848F0 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.Names                                     = GetStringList(new IntPtr(p + 0x020)); // 0245A665F818 0x20 Names                       ( 000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ResolvedNames                             = GetStringList(new IntPtr(p + 0x028)); // 0245A665F838 0x28 ResolvedNames               ( 000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
