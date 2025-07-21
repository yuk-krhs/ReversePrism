using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortedList                               ModelClassType SortedList SortedList SortedList Pointer
    // 018 _key                                     <object> IL2CPP_TYPE_OBJECT
    // 020 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 028 Index                                    ModelPrimitiveType int int int Int32
    // 02C StartIndex                               ModelPrimitiveType int int int Int32
    // 030 EndIndex                                 ModelPrimitiveType int int int Int32
    // 034 Version                                  ModelPrimitiveType int int int Int32
    // 038 Current                                  ModelPrimitiveType bool bool bool Bool
    // 03C GetObjectRetType                         ModelPrimitiveType int int int Int32
    public partial class SortedListEnumerator : DataModel
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
            var value   = new SortedListEnumerator() { Pointer= p0 };

            value.SortedList                                = GetObject<SortedList>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortedList.FromPointer); // 0x10 SortedList                  ( ModelClassType SortedList SortedList SortedList Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Index                       ( ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x02C)); // 0x2C StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 EndIndex                    ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x034)); // 0x34 Version                     ( ModelPrimitiveType int int int Int32 )
            value.Current                                   = GetBool(new IntPtr(p + 0x038)); // 0x38 Current                     ( ModelPrimitiveType bool bool bool Bool )
            value.GetObjectRetType                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C GetObjectRetType            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
