using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<PresentHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PresentHistoryIdFieldNumber              int IL2CPP_TYPE_I4
    // 028 PresentHistoryId                         ModelPrimitiveType string string string String
    // 000 PresentFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Present                                  ModelClassType PresentStatus PresentStatus PresentStatus Pointer
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 038 _CreateDate                              ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class PresentHistoryStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public string                                   PresentHistoryId                        { get; set; }
        public PresentStatus?                           Present                                 { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }

        public static PresentHistoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentHistoryStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PresentHistoryId                          = GetString(new IntPtr(p + 0x028)); // 0x28 PresentHistoryId            ( ModelPrimitiveType string string string String )
            value.Present                                   = GetObject<PresentStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PresentStatus.FromPointer); // 0x30 Present                     ( ModelClassType PresentStatus PresentStatus PresentStatus Pointer )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _CreateDate                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
