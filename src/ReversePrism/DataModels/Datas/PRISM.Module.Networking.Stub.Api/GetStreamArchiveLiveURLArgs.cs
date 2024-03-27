using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStreamArchiveLiveURLArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStreamProgramIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstStreamProgramId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetStreamArchiveLiveURLArgs
    {
        public int                                      MstStreamProgramId                      { get; set; }

        public static GetStreamArchiveLiveURLArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStreamArchiveLiveURLArgs();

            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x018)); // 0270D2ABD840 0x18 MstStreamProgramId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
