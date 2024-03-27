using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourInGameStageStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StageIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 StageId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StageNumberFieldNumber                   int IL2CPP_TYPE_I4
    // 01C StageNumber                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StageTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StageType                                000186585040 ModelEnumType ChallengeTourStageType ChallengeTourStageType ChallengeTourStageType Int32
    public partial class ChallengeTourInGameStageStatus
    {
        public int                                      StageId                                 { get; set; }
        public int                                      StageNumber                             { get; set; }
        public ChallengeTourStageType                   StageType                               { get; set; }

        public static ChallengeTourInGameStageStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameStageStatus();

            value.StageId                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D0F300A0 0x18 StageId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StageNumber                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D0F300E0 0x1C StageNumber                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StageType                                 = (ChallengeTourStageType)GetInt32(new IntPtr(p + 0x020)); // 0270D0F30120 0x20 StageType                   ( 000186585040 ModelEnumType ChallengeTourStageType ChallengeTourStageType ChallengeTourStageType Int32 )

            return value;
        }
    }
}
