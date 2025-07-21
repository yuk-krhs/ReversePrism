using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Domain_id                                ModelPrimitiveType int int int Int32
    // 014 Context_id                               ModelPrimitiveType int int int Int32
    // 018 static_data                              <uint> IL2CPP_TYPE_U
    // 020 data                                     <uint> IL2CPP_TYPE_U
    // 000 local_slots                              <object>[] IL2CPP_TYPE_SZARRAY
    // 008 default_server_context_sink              IMessageSink IL2CPP_TYPE_CLASS
    // 028 Server_context_sink_chain                ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 030 Client_context_sink_chain                ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 038 Context_properties                       ModelClassListType List`1<IContextProperty> List`1<IContextProperty> List<IContextProperty> Pointer
    // 010 Global_count                             ModelPrimitiveType int int int Int32
    // 040 LocalDataStore                           ModelClassType LocalDataStoreHolder LocalDataStoreHolder LocalDataStoreHolder Pointer
    // 018 LocalDataStoreMgr                        ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer
    // 020 Global_dynamic_properties                ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer
    // 048 Context_dynamic_properties               ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer
    // 050 Callback_object                          ModelClassType ContextCallbackObject ContextCallbackObject ContextCallbackObject Pointer
    public partial class Context : DataModel
    {
        public int                                      Domain_id                               { get; set; }
        public int                                      Context_id                              { get; set; }
        public IMessageSink?                            Server_context_sink_chain               { get; set; }
        public IMessageSink?                            Client_context_sink_chain               { get; set; }
        public List<IContextProperty>?                  Context_properties                      { get; set; }
        public int                                      Global_count                            { get; set; }
        public LocalDataStoreHolder?                    LocalDataStore                          { get; set; }
        public LocalDataStoreMgr?                       LocalDataStoreMgr                       { get; set; }
        public DynamicPropertyCollection?               Global_dynamic_properties               { get; set; }
        public DynamicPropertyCollection?               Context_dynamic_properties              { get; set; }
        public ContextCallbackObject?                   Callback_object                         { get; set; }

        public static Context? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Context() { Pointer= p0 };

            value.Domain_id                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 Domain_id                   ( ModelPrimitiveType int int int Int32 )
            value.Context_id                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 Context_id                  ( ModelPrimitiveType int int int Int32 )
            value.Server_context_sink_chain                 = GetObject<IMessageSink>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x28 Server_context_sink_chain   ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Client_context_sink_chain                 = GetObject<IMessageSink>(new IntPtr(p + 0x030), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x30 Client_context_sink_chain   ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Context_properties                        = GetObjectList<IContextProperty>(new IntPtr(p + 0x038), ReversePrism.DataModels.IContextProperty.FromPointer); // 0x38 Context_properties          ( ModelClassListType List`1<IContextProperty> List`1<IContextProperty> List<IContextProperty> Pointer )
            value.Global_count                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 Global_count                ( ModelPrimitiveType int int int Int32 )
            value.LocalDataStore                            = GetObject<LocalDataStoreHolder>(new IntPtr(p + 0x040), ReversePrism.DataModels.LocalDataStoreHolder.FromPointer); // 0x40 LocalDataStore              ( ModelClassType LocalDataStoreHolder LocalDataStoreHolder LocalDataStoreHolder Pointer )
            value.LocalDataStoreMgr                         = GetObject<LocalDataStoreMgr>(new IntPtr(p + 0x018), ReversePrism.DataModels.LocalDataStoreMgr.FromPointer); // 0x18 LocalDataStoreMgr           ( ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer )
            value.Global_dynamic_properties                 = GetObject<DynamicPropertyCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.DynamicPropertyCollection.FromPointer); // 0x20 Global_dynamic_properties   ( ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer )
            value.Context_dynamic_properties                = GetObject<DynamicPropertyCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.DynamicPropertyCollection.FromPointer); // 0x48 Context_dynamic_properties  ( ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer )
            value.Callback_object                           = GetObject<ContextCallbackObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.ContextCallbackObject.FromPointer); // 0x50 Callback_object             ( ModelClassType ContextCallbackObject ContextCallbackObject ContextCallbackObject Pointer )

            return value;
        }
    }
}
