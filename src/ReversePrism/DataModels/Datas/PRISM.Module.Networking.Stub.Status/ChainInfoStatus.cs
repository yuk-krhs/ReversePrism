using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ChainInfoStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ReadDateFieldNumber                      int IL2CPP_TYPE_I4
    // 028 _ReadDate                                ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstChainTalkIdFieldNumber                int IL2CPP_TYPE_I4
    // 030 MstChainTalkId                           ModelPrimitiveType int int int Int32
    // 000 MstChainTalkGroupIdFieldNumber           int IL2CPP_TYPE_I4
    // 034 MstChainTalkGroupId                      ModelPrimitiveType int int int Int32
    // 000 ChainTalkFieldNumber                     int IL2CPP_TYPE_I4
    // 038 ChainTalk                                ModelClassType ChainTalkStatus ChainTalkStatus ChainTalkStatus Pointer
    public partial class ChainInfoStatus : DataModel
    {
        public DateTime                                 ReadDate                                { get; set; }
        public Timestamp?                               _ReadDate                               { get; set; }
        public int                                      MstChainTalkId                          { get; set; }
        public int                                      MstChainTalkGroupId                     { get; set; }
        public ChainTalkStatus?                         ChainTalk                               { get; set; }

        public static ChainInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainInfoStatus() { Pointer= p0 };

            value.ReadDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 ReadDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value._ReadDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x028), ReversePrism.DataModels.Timestamp.FromPointer); // 0x28 _ReadDate                   ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstChainTalkId                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstChainTalkId              ( ModelPrimitiveType int int int Int32 )
            value.MstChainTalkGroupId                       = GetInt32(new IntPtr(p + 0x034)); // 0x34 MstChainTalkGroupId         ( ModelPrimitiveType int int int Int32 )
            value.ChainTalk                                 = GetObject<ChainTalkStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkStatus.FromPointer); // 0x38 ChainTalk                   ( ModelClassType ChainTalkStatus ChainTalkStatus ChainTalkStatus Pointer )
            value.ReadDate                      = ToDateTime(value._ReadDate);

            return value;
        }
    }
}
