using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourInGameCounterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 VocalCounterReleaseCountFieldNumber      int IL2CPP_TYPE_I4
    // 018 VocalCounterReleaseCount                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DanceCounterReleaseCountFieldNumber      int IL2CPP_TYPE_I4
    // 01C DanceCounterReleaseCount                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VisualCounterReleaseCountFieldNumber     int IL2CPP_TYPE_I4
    // 020 VisualCounterReleaseCount                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourInGameCounterStatus : DataModel
    {
        public int                                      VocalCounterReleaseCount                { get; set; }
        public int                                      DanceCounterReleaseCount                { get; set; }
        public int                                      VisualCounterReleaseCount               { get; set; }

        public static ChallengeTourInGameCounterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameCounterStatus() { Pointer= p0 };

            value.VocalCounterReleaseCount                  = GetInt32(new IntPtr(p + 0x018)); // 024660ED1718 0x18 VocalCounterReleaseCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DanceCounterReleaseCount                  = GetInt32(new IntPtr(p + 0x01C)); // 024660ED1758 0x1C DanceCounterReleaseCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualCounterReleaseCount                 = GetInt32(new IntPtr(p + 0x020)); // 024660ED1798 0x20 VisualCounterReleaseCount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
