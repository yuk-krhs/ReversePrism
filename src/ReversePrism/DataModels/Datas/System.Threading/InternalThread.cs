using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lock_thread_id                           ModelPrimitiveType int int int Int32
    // 018 handle                                   <int> IL2CPP_TYPE_I
    // 020 native_handle                            <int> IL2CPP_TYPE_I
    // 028 name_chars                               <int> IL2CPP_TYPE_I
    // 030 Name_free                                ModelPrimitiveType int int int Int32
    // 034 Name_length                              ModelPrimitiveType int int int Int32
    // 038 State                                    ModelEnumType ThreadState ThreadState ThreadState Int32
    // 040 abort_exc                                <object> IL2CPP_TYPE_OBJECT
    // 048 Abort_state_handle                       ModelPrimitiveType int int int Int32
    // 050 Thread_id                                ModelPrimitiveType long long long Int64
    // 058 debugger_thread                          <int> IL2CPP_TYPE_I
    // 060 static_data                              <uint> IL2CPP_TYPE_U
    // 068 runtime_thread_info                      <int> IL2CPP_TYPE_I
    // 070 current_appcontext                       <object> IL2CPP_TYPE_OBJECT
    // 078 root_domain_thread                       <object> IL2CPP_TYPE_OBJECT
    // 080 Serialized_principal                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 088 Serialized_principal_version             ModelPrimitiveType int int int Int32
    // 090 appdomain_refs                           <int> IL2CPP_TYPE_I
    // 098 Interruption_requested                   ModelPrimitiveType int int int Int32
    // 0A0 longlived                                <int> IL2CPP_TYPE_I
    // 0A8 Threadpool_thread                        ModelPrimitiveType bool bool bool Bool
    // 0A9 Thread_interrupt_requested               ModelPrimitiveType bool bool bool Bool
    // 0AC Stack_size                               ModelPrimitiveType int int int Int32
    // 0B0 Apartment_state                          ModelPrimitiveType sbyte sbyte sbyte SByte
    // 0B4 Critical_region_level                    ModelPrimitiveType int int int Int32
    // 0B8 Managed_id                               ModelPrimitiveType int int int Int32
    // 0BC Small_id                                 ModelPrimitiveType int int int Int32
    // 0C0 manage_callback                          <int> IL2CPP_TYPE_I
    // 0C8 flags                                    <int> IL2CPP_TYPE_I
    // 0D0 thread_pinning_ref                       <int> IL2CPP_TYPE_I
    // 0D8 abort_protected_block_count              <int> IL2CPP_TYPE_I
    // 0E0 Priority                                 ModelPrimitiveType int int int Int32
    // 0E8 owned_mutex                              <int> IL2CPP_TYPE_I
    // 0F0 suspended_event                          <int> IL2CPP_TYPE_I
    // 0F8 Self_suspended                           ModelPrimitiveType int int int Int32
    // 100 thread_state                             <int> IL2CPP_TYPE_I
    // 108 netcore0                                 <int> IL2CPP_TYPE_I
    // 110 netcore1                                 <int> IL2CPP_TYPE_I
    // 118 netcore2                                 <int> IL2CPP_TYPE_I
    // 120 last                                     <int> IL2CPP_TYPE_I
    public partial class InternalThread : DataModel
    {
        public int                                      Lock_thread_id                          { get; set; }
        public int                                      Name_free                               { get; set; }
        public int                                      Name_length                             { get; set; }
        public ThreadState                              State                                   { get; set; }
        public int                                      Abort_state_handle                      { get; set; }
        public long                                     Thread_id                               { get; set; }
        public List<sbyte>?                             Serialized_principal                    { get; set; }
        public int                                      Serialized_principal_version            { get; set; }
        public int                                      Interruption_requested                  { get; set; }
        public bool                                     Threadpool_thread                       { get; set; }
        public bool                                     Thread_interrupt_requested              { get; set; }
        public int                                      Stack_size                              { get; set; }
        public sbyte                                    Apartment_state                         { get; set; }
        public int                                      Critical_region_level                   { get; set; }
        public int                                      Managed_id                              { get; set; }
        public int                                      Small_id                                { get; set; }
        public int                                      Priority                                { get; set; }
        public int                                      Self_suspended                          { get; set; }

        public static InternalThread? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalThread() { Pointer= p0 };

            value.Lock_thread_id                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 Lock_thread_id              ( ModelPrimitiveType int int int Int32 )
            value.Name_free                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 Name_free                   ( ModelPrimitiveType int int int Int32 )
            value.Name_length                               = GetInt32(new IntPtr(p + 0x034)); // 0x34 Name_length                 ( ModelPrimitiveType int int int Int32 )
            value.State                                     = (ThreadState)GetInt32(new IntPtr(p + 0x038)); // 0x38 State                       ( ModelEnumType ThreadState ThreadState ThreadState Int32 )
            value.Abort_state_handle                        = GetInt32(new IntPtr(p + 0x048)); // 0x48 Abort_state_handle          ( ModelPrimitiveType int int int Int32 )
            value.Thread_id                                 = GetInt64(new IntPtr(p + 0x050)); // 0x50 Thread_id                   ( ModelPrimitiveType long long long Int64 )
            value.Serialized_principal                      = GetSByteList(new IntPtr(p + 0x080)); // 0x80 Serialized_principal        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Serialized_principal_version              = GetInt32(new IntPtr(p + 0x088)); // 0x88 Serialized_principal_version ( ModelPrimitiveType int int int Int32 )
            value.Interruption_requested                    = GetInt32(new IntPtr(p + 0x098)); // 0x98 Interruption_requested      ( ModelPrimitiveType int int int Int32 )
            value.Threadpool_thread                         = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 Threadpool_thread           ( ModelPrimitiveType bool bool bool Bool )
            value.Thread_interrupt_requested                = GetBool(new IntPtr(p + 0x0A9)); // 0xA9 Thread_interrupt_requested  ( ModelPrimitiveType bool bool bool Bool )
            value.Stack_size                                = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC Stack_size                  ( ModelPrimitiveType int int int Int32 )
            value.Apartment_state                           = GetSByte(new IntPtr(p + 0x0B0)); // 0xB0 Apartment_state             ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Critical_region_level                     = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 Critical_region_level       ( ModelPrimitiveType int int int Int32 )
            value.Managed_id                                = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 Managed_id                  ( ModelPrimitiveType int int int Int32 )
            value.Small_id                                  = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC Small_id                    ( ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 Priority                    ( ModelPrimitiveType int int int Int32 )
            value.Self_suspended                            = GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 Self_suspended              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
