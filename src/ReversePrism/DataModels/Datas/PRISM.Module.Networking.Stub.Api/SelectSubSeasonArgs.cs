using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectSubSeasonArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSubSeasonIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstSubSeasonId                           ModelPrimitiveType int int int Int32
    public partial class SelectSubSeasonArgs : DataModel
    {
        public int                                      MstSubSeasonId                          { get; set; }

        public static SelectSubSeasonArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectSubSeasonArgs() { Pointer= p0 };

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSubSeasonId              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
