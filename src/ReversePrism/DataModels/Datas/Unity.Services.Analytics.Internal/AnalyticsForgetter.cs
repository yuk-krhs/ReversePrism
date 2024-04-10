using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ForgottenStatusKey                     string IL2CPP_TYPE_STRING
    // 010 M_CollectUrl                             000186672F10 ModelPrimitiveType string string string String
    // 018 M_Persistence                            0001865D4970 ModelClassType IPersistence IPersistence IPersistence Pointer
    // 020 M_WebRequestHelper                       00018669BE50 ModelClassType IWebRequestHelper IWebRequestHelper IWebRequestHelper Pointer
    // 028 M_Event                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 M_Callback                               0001866792B0 ModelClassType Action Action Action Pointer
    // 038 M_DeletionStatus                         00018669CD30 ModelEnumType DataDeletionStatus DataDeletionStatus DataDeletionStatus Int32
    // 040 M_Request                                00018669B4D0 ModelClassType IWebRequest IWebRequest IWebRequest Pointer
    public partial class AnalyticsForgetter : DataModel
    {
        public string                                   M_CollectUrl                            { get; set; }
        public IPersistence?                            M_Persistence                           { get; set; }
        public IWebRequestHelper?                       M_WebRequestHelper                      { get; set; }
        public List<sbyte>?                             M_Event                                 { get; set; }
        public Action?                                  M_Callback                              { get; set; }
        public DataDeletionStatus                       M_DeletionStatus                        { get; set; }
        public IWebRequest?                             M_Request                               { get; set; }

        public static AnalyticsForgetter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsForgetter() { Pointer= p0 };

            value.M_CollectUrl                              = GetString(new IntPtr(p + 0x010)); // 0245A667E8A8 0x10 M_CollectUrl                ( 000186672F10 ModelPrimitiveType string string string String )
            value.M_Persistence                             = GetObject<IPersistence>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPersistence.FromPointer); // 0245A667E8C8 0x18 M_Persistence               ( 0001865D4970 ModelClassType IPersistence IPersistence IPersistence Pointer )
            value.M_WebRequestHelper                        = GetObject<IWebRequestHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.IWebRequestHelper.FromPointer); // 0245A667E8E8 0x20 M_WebRequestHelper          ( 00018669BE50 ModelClassType IWebRequestHelper IWebRequestHelper IWebRequestHelper Pointer )
            value.M_Event                                   = GetSByteList(new IntPtr(p + 0x028)); // 0245A667E908 0x28 M_Event                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_Callback                                = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0245A667E928 0x30 M_Callback                  ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_DeletionStatus                          = (DataDeletionStatus)GetInt32(new IntPtr(p + 0x038)); // 0245A667E948 0x38 M_DeletionStatus            ( 00018669CD30 ModelEnumType DataDeletionStatus DataDeletionStatus DataDeletionStatus Int32 )
            value.M_Request                                 = GetObject<IWebRequest>(new IntPtr(p + 0x040), ReversePrism.DataModels.IWebRequest.FromPointer); // 0245A667E968 0x40 M_Request                   ( 00018669B4D0 ModelClassType IWebRequest IWebRequest IWebRequest Pointer )

            return value;
        }
    }
}
