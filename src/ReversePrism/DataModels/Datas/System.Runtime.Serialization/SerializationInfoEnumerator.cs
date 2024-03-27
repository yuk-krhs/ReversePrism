using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Members                                  000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 _data                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 020 Types                                    000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer
    // 028 NumItems                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 02C CurrItem                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Current                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SerializationInfoEnumerator
    {
        public List<string>?                            Members                                 { get; set; }
        public List<Type>?                              Types                                   { get; set; }
        public int                                      NumItems                                { get; set; }
        public int                                      CurrItem                                { get; set; }
        public bool                                     Current                                 { get; set; }

        public static SerializationInfoEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationInfoEnumerator();

            value.Members                                   = GetStringList(new IntPtr(p + 0x010)); // 0270D6BED568 0x10 Members                     ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Types                                     = GetObjectList<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D6BED5A8 0x20 Types                       ( 000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.NumItems                                  = GetInt32(new IntPtr(p + 0x028)); // 0270D6BED5C8 0x28 NumItems                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrItem                                  = GetInt32(new IntPtr(p + 0x02C)); // 0270D6BED5E8 0x2C CurrItem                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetBool(new IntPtr(p + 0x030)); // 0270D6BED608 0x30 Current                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
