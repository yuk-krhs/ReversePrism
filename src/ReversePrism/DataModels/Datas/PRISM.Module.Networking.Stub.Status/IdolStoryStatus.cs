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
    // 018 Story                                    0001865A4D90 ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 024 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseIdolBaseDearnessFieldNumber int IL2CPP_TYPE_I4
    // 028 UnlockPremiseIdolBaseDearness            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseMstIdolStoryIdFieldNumber   int IL2CPP_TYPE_I4
    // 02C UnlockPremiseMstIdolStoryId              0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Story                                     = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0246629BF538 0x18 Story                       ( 0001865A4D90 ModelClassType StoryStatus StoryStatus StoryStatus Pointer )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 0246629BF578 0x20 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x024)); // 0246629BF5B8 0x24 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseIdolBaseDearness             = GetInt32(new IntPtr(p + 0x028)); // 0246629BF5F8 0x28 UnlockPremiseIdolBaseDearness ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseMstIdolStoryId               = GetInt32(new IntPtr(p + 0x02C)); // 0246629BF638 0x2C UnlockPremiseMstIdolStoryId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
