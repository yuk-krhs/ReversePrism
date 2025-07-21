using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolStoryStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Story                                    ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 024 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseIdolBaseDearnessFieldNumber int IL2CPP_TYPE_I4
    // 028 UnlockPremiseIdolBaseDearness            ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseMstIdolStoryIdFieldNumber   int IL2CPP_TYPE_I4
    // 02C UnlockPremiseMstIdolStoryId              ModelPrimitiveType int int int Int32
    public partial class IdolStoryStatus : DataModel
    {
        public StoryStatus?                             Story                                   { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      UnlockPremiseIdolBaseDearness           { get; set; }
        public int                                      UnlockPremiseMstIdolStoryId             { get; set; }

        public static IdolStoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryStatus() { Pointer= p0 };

            value.Story                                     = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0x18 Story                       ( ModelClassType StoryStatus StoryStatus StoryStatus Pointer )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseIdolBaseDearness             = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnlockPremiseIdolBaseDearness ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseMstIdolStoryId               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C UnlockPremiseMstIdolStoryId ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
