using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Position                                 0001865A5240 ModelEnumType CaretPosition CaretPosition CaretPosition Int32
    public partial class CaretInfo
    {
        public int                                      Index                                   { get; set; }
        public CaretPosition                            Position                                { get; set; }

        public static CaretInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaretInfo();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DA6572A8 0x10 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Position                                  = (CaretPosition)GetInt32(new IntPtr(p + 0x014)); // 0270DA6572C8 0x14 Position                    ( 0001865A5240 ModelEnumType CaretPosition CaretPosition CaretPosition Int32 )

            return value;
        }
    }
}
