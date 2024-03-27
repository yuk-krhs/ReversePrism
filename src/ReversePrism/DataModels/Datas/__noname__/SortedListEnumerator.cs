using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortedList                               000186532E70 ModelClassType SortedList SortedList SortedList Pointer
    // 018 _key                                     <object> IL2CPP_TYPE_OBJECT
    // 020 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 028 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C StartIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 EndIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Current                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C GetObjectRetType                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SortedListEnumerator
    {
        public SortedList?                              SortedList                              { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      StartIndex                              { get; set; }
        public int                                      EndIndex                                { get; set; }
        public int                                      Version                                 { get; set; }
        public bool                                     Current                                 { get; set; }
        public int                                      GetObjectRetType                        { get; set; }

        public static SortedListEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortedListEnumerator();

            value.SortedList                                = GetObject<SortedList>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortedList.FromPointer); // 0270D6D81BE8 0x10 SortedList                  ( 000186532E70 ModelClassType SortedList SortedList SortedList Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x028)); // 0270D6D81C48 0x28 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x02C)); // 0270D6D81C68 0x2C StartIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D6D81C88 0x30 EndIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x034)); // 0270D6D81CA8 0x34 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetBool(new IntPtr(p + 0x038)); // 0270D6D81CC8 0x38 Current                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GetObjectRetType                          = GetInt32(new IntPtr(p + 0x03C)); // 0270D6D81CE8 0x3C GetObjectRetType            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
