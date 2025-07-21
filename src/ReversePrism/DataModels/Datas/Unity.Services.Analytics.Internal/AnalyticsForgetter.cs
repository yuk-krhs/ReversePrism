using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ForgottenStatusKey                     string IL2CPP_TYPE_STRING
    // 010 M_CollectUrl                             ModelPrimitiveType string string string String
    // 018 M_Persistence                            ModelClassType IPersistence IPersistence IPersistence Pointer
    // 020 M_WebRequestHelper                       ModelClassType IWebRequestHelper IWebRequestHelper IWebRequestHelper Pointer
    // 028 M_Event                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 M_Callback                               ModelClassType Action Action Action Pointer
    // 038 M_DeletionStatus                         ModelEnumType DataDeletionStatus DataDeletionStatus DataDeletionStatus Int32
    // 040 M_Request                                ModelClassType IWebRequest IWebRequest IWebRequest Pointer
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

            value.M_CollectUrl                              = GetString(new IntPtr(p + 0x010)); // 0x10 M_CollectUrl                ( ModelPrimitiveType string string string String )
            value.M_Persistence                             = GetObject<IPersistence>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPersistence.FromPointer); // 0x18 M_Persistence               ( ModelClassType IPersistence IPersistence IPersistence Pointer )
            value.M_WebRequestHelper                        = GetObject<IWebRequestHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.IWebRequestHelper.FromPointer); // 0x20 M_WebRequestHelper          ( ModelClassType IWebRequestHelper IWebRequestHelper IWebRequestHelper Pointer )
            value.M_Event                                   = GetSByteList(new IntPtr(p + 0x028)); // 0x28 M_Event                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_Callback                                = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0x30 M_Callback                  ( ModelClassType Action Action Action Pointer )
            value.M_DeletionStatus                          = (DataDeletionStatus)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_DeletionStatus            ( ModelEnumType DataDeletionStatus DataDeletionStatus DataDeletionStatus Int32 )
            value.M_Request                                 = GetObject<IWebRequest>(new IntPtr(p + 0x040), ReversePrism.DataModels.IWebRequest.FromPointer); // 0x40 M_Request                   ( ModelClassType IWebRequest IWebRequest IWebRequest Pointer )

            return value;
        }
    }
}
