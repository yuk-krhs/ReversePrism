using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C Version                                  ModelPrimitiveType int int int Int32
    // 020 _currentElement                          <object> IL2CPP_TYPE_OBJECT
    // 028 IsArrayList                              ModelPrimitiveType bool bool bool Bool
    // 000 s_dummyObject                            <object> IL2CPP_TYPE_OBJECT
    public partial class ArrayListEnumeratorSimple : DataModel
    {
        public ArrayList?                               List                                    { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Version                                 { get; set; }
        public bool                                     IsArrayList                             { get; set; }

        public static ArrayListEnumeratorSimple? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayListEnumeratorSimple() { Pointer= p0 };

            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0x10 List                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Version                     ( ModelPrimitiveType int int int Int32 )
            value.IsArrayList                               = GetBool(new IntPtr(p + 0x028)); // 0x28 IsArrayList                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
