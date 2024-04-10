using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 _currentElement                          <object> IL2CPP_TYPE_OBJECT
    // 028 IsArrayList                              000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0245A4D40FE0 0x10 List                        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A4D41000 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x01C)); // 0245A4D41020 0x1C Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsArrayList                               = GetBool(new IntPtr(p + 0x028)); // 0245A4D41060 0x28 IsArrayList                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
