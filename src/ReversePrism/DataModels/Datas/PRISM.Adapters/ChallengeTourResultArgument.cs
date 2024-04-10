using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FinishReply                              00018650D490 ModelClassType IFinishChallengeTourStageReply IFinishChallengeTourStageReply IFinishChallengeTourStageReply Pointer
    // 018 UnitIdols                                000185CAF268 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 UnitIndex                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 StageIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 UnitId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourResultArgument : DataModel
    {
        public IFinishChallengeTourStageReply?          FinishReply                             { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public int                                      StageIndex                              { get; set; }
        public int                                      UnitId                                  { get; set; }

        public static ChallengeTourResultArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultArgument() { Pointer= p0 };

            value.FinishReply                               = GetObject<IFinishChallengeTourStageReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishChallengeTourStageReply.FromPointer); // 0246664D3798 0x10 FinishReply                 ( 00018650D490 ModelClassType IFinishChallengeTourStageReply IFinishChallengeTourStageReply IFinishChallengeTourStageReply Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0246664D37B8 0x18 UnitIdols                   ( 000185CAF268 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x020)); // 0246664D37D8 0x20 UnitIndex                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StageIndex                                = GetInt32(new IntPtr(p + 0x024)); // 0246664D37F8 0x24 StageIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 0246664D3818 0x28 UnitId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
