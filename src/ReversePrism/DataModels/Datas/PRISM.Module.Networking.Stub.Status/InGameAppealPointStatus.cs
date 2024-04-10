using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InGameAppealPointStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AppealPointFieldNumber                   int IL2CPP_TYPE_I4
    // 018 AppealPoint                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VocalPointFieldNumber                    int IL2CPP_TYPE_I4
    // 01C VocalPoint                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DancePointFieldNumber                    int IL2CPP_TYPE_I4
    // 020 DancePoint                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VisualPointFieldNumber                   int IL2CPP_TYPE_I4
    // 024 VisualPoint                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class InGameAppealPointStatus : DataModel
    {
        public int                                      AppealPoint                             { get; set; }
        public int                                      VocalPoint                              { get; set; }
        public int                                      DancePoint                              { get; set; }
        public int                                      VisualPoint                             { get; set; }

        public static InGameAppealPointStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameAppealPointStatus() { Pointer= p0 };

            value.AppealPoint                               = GetInt32(new IntPtr(p + 0x018)); // 024661059A80 0x18 AppealPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VocalPoint                                = GetInt32(new IntPtr(p + 0x01C)); // 024661059AC0 0x1C VocalPoint                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DancePoint                                = GetInt32(new IntPtr(p + 0x020)); // 024661059B00 0x20 DancePoint                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualPoint                               = GetInt32(new IntPtr(p + 0x024)); // 024661059B40 0x24 VisualPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
