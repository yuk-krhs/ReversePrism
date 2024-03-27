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
    public partial class InGameAppealPointStatus
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
            var value   = new InGameAppealPointStatus();

            value.AppealPoint                               = GetInt32(new IntPtr(p + 0x018)); // 0270D10CC208 0x18 AppealPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VocalPoint                                = GetInt32(new IntPtr(p + 0x01C)); // 0270D10CC248 0x1C VocalPoint                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DancePoint                                = GetInt32(new IntPtr(p + 0x020)); // 0270D10CC288 0x20 DancePoint                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualPoint                               = GetInt32(new IntPtr(p + 0x024)); // 0270D10CC2C8 0x24 VisualPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
