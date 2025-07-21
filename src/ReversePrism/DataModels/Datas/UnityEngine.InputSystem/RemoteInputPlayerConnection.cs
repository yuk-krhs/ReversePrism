using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kNewDeviceMsg                            Guid IL2CPP_TYPE_VALUETYPE
    // 010 KNewLayoutMsg                            ModelEnumType Guid Guid Guid Int32
    // 020 KNewEventsMsg                            ModelEnumType Guid Guid Guid Int32
    // 030 KRemoveDeviceMsg                         ModelEnumType Guid Guid Guid Int32
    // 040 KChangeUsagesMsg                         ModelEnumType Guid Guid Guid Int32
    // 050 KStartSendingMsg                         ModelEnumType Guid Guid Guid Int32
    // 060 KStopSendingMsg                          ModelEnumType Guid Guid Guid Int32
    // 018 M_Connection                             ModelClassType IEditorPlayerConnection IEditorPlayerConnection IEditorPlayerConnection Pointer
    // 020 M_Subscribers                            ModelClassListType Subscriber[] Subscriber[] List<Subscriber> Pointer
    // 028 M_ConnectedIds                           ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class RemoteInputPlayerConnection : DataModel
    {
        public Guid                                     KNewLayoutMsg                           { get; set; }
        public Guid                                     KNewEventsMsg                           { get; set; }
        public Guid                                     KRemoveDeviceMsg                        { get; set; }
        public Guid                                     KChangeUsagesMsg                        { get; set; }
        public Guid                                     KStartSendingMsg                        { get; set; }
        public Guid                                     KStopSendingMsg                         { get; set; }
        public IEditorPlayerConnection?                 M_Connection                            { get; set; }
        public List<Subscriber>?                        M_Subscribers                           { get; set; }
        public List<int>?                               M_ConnectedIds                          { get; set; }

        public static RemoteInputPlayerConnection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoteInputPlayerConnection() { Pointer= p0 };

            value.KNewLayoutMsg                             = (Guid)GetInt32(new IntPtr(p + 0x010)); // 0x10 KNewLayoutMsg               ( ModelEnumType Guid Guid Guid Int32 )
            value.KNewEventsMsg                             = (Guid)GetInt32(new IntPtr(p + 0x020)); // 0x20 KNewEventsMsg               ( ModelEnumType Guid Guid Guid Int32 )
            value.KRemoveDeviceMsg                          = (Guid)GetInt32(new IntPtr(p + 0x030)); // 0x30 KRemoveDeviceMsg            ( ModelEnumType Guid Guid Guid Int32 )
            value.KChangeUsagesMsg                          = (Guid)GetInt32(new IntPtr(p + 0x040)); // 0x40 KChangeUsagesMsg            ( ModelEnumType Guid Guid Guid Int32 )
            value.KStartSendingMsg                          = (Guid)GetInt32(new IntPtr(p + 0x050)); // 0x50 KStartSendingMsg            ( ModelEnumType Guid Guid Guid Int32 )
            value.KStopSendingMsg                           = (Guid)GetInt32(new IntPtr(p + 0x060)); // 0x60 KStopSendingMsg             ( ModelEnumType Guid Guid Guid Int32 )
            value.M_Connection                              = GetObject<IEditorPlayerConnection>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEditorPlayerConnection.FromPointer); // 0x18 M_Connection                ( ModelClassType IEditorPlayerConnection IEditorPlayerConnection IEditorPlayerConnection Pointer )
            value.M_Subscribers                             = GetObjectList<Subscriber>(new IntPtr(p + 0x020), ReversePrism.DataModels.Subscriber.FromPointer); // 0x20 M_Subscribers               ( ModelClassListType Subscriber[] Subscriber[] List<Subscriber> Pointer )
            value.M_ConnectedIds                            = GetInt32List(new IntPtr(p + 0x028)); // 0x28 M_ConnectedIds              ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
