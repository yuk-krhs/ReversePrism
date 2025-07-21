using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TutorialStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CategoryFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Category                                 ModelPrimitiveType int int int Int32
    // 000 PhaseFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Phase                                    ModelPrimitiveType int int int Int32
    public partial class TutorialStatus : DataModel
    {
        public int                                      Category                                { get; set; }
        public int                                      Phase                                   { get; set; }

        public static TutorialStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialStatus() { Pointer= p0 };

            value.Category                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Category                    ( ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Phase                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
