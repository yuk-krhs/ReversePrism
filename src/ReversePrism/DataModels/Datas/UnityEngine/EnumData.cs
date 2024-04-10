using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Values                                   000185B7BBB0 ModelClassListType Enum[] Enum[] List<Enum> Pointer
    // 018 FlagValues                               000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 DisplayNames                             000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Names                                    000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Tooltip                                  000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 Flags                                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 UnderlyingType                           000186692F60 ModelClassType Type Type Type Pointer
    // 048 Unsigned                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 049 Serializable                             000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class EnumData : DataModel
    {
        public List<Enum>?                              Values                                  { get; set; }
        public List<int>?                               FlagValues                              { get; set; }
        public List<string>?                            DisplayNames                            { get; set; }
        public List<string>?                            Names                                   { get; set; }
        public List<string>?                            Tooltip                                 { get; set; }
        public bool                                     Flags                                   { get; set; }
        public Type?                                    UnderlyingType                          { get; set; }
        public bool                                     Unsigned                                { get; set; }
        public bool                                     Serializable                            { get; set; }

        public static EnumData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumData() { Pointer= p0 };

            value.Values                                    = GetObjectList<Enum>(new IntPtr(p + 0x010), ReversePrism.DataModels.Enum.FromPointer); // 0245A50AEC78 0x10 Values                      ( 000185B7BBB0 ModelClassListType Enum[] Enum[] List<Enum> Pointer )
            value.FlagValues                                = GetInt32List(new IntPtr(p + 0x018)); // 0245A50AEC98 0x18 FlagValues                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.DisplayNames                              = GetStringList(new IntPtr(p + 0x020)); // 0245A50AECB8 0x20 DisplayNames                ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Names                                     = GetStringList(new IntPtr(p + 0x028)); // 0245A50AECD8 0x28 Names                       ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Tooltip                                   = GetStringList(new IntPtr(p + 0x030)); // 0245A50AECF8 0x30 Tooltip                     ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Flags                                     = GetBool(new IntPtr(p + 0x038)); // 0245A50AED18 0x38 Flags                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UnderlyingType                            = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0245A50AED38 0x40 UnderlyingType              ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Unsigned                                  = GetBool(new IntPtr(p + 0x048)); // 0245A50AED58 0x48 Unsigned                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Serializable                              = GetBool(new IntPtr(p + 0x049)); // 0245A50AED78 0x49 Serializable                ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
