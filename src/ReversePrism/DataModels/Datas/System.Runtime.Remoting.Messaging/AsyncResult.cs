using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 async_state                              <object> IL2CPP_TYPE_OBJECT
    // 018 Handle                                   ModelClassType WaitHandle WaitHandle WaitHandle Pointer
    // 020 async_delegate                           <object> IL2CPP_TYPE_OBJECT
    // 028 data                                     <int> IL2CPP_TYPE_I
    // 030 object_data                              <object> IL2CPP_TYPE_OBJECT
    // 038 Sync_completed                           ModelPrimitiveType bool bool bool Bool
    // 039 Completed                                ModelPrimitiveType bool bool bool Bool
    // 03A Endinvoke_called                         ModelPrimitiveType bool bool bool Bool
    // 040 async_callback                           <object> IL2CPP_TYPE_OBJECT
    // 048 Current                                  ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 050 Original                                 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 058 Add_time                                 ModelPrimitiveType long long long Int64
    // 060 Call_message                             ModelClassType MonoMethodMessage MonoMethodMessage MonoMethodMessage Pointer
    // 068 Message_ctrl                             ModelClassType IMessageCtrl IMessageCtrl IMessageCtrl Pointer
    // 070 Reply_message                            ModelClassType IMessage IMessage IMessage Pointer
    // 078 Orig_cb                                  ModelClassType WaitCallback WaitCallback WaitCallback Pointer
    public partial class AsyncResult : DataModel
    {
        public WaitHandle?                              Handle                                  { get; set; }
        public bool                                     Sync_completed                          { get; set; }
        public bool                                     Completed                               { get; set; }
        public bool                                     Endinvoke_called                        { get; set; }
        public ExecutionContext?                        Current                                 { get; set; }
        public ExecutionContext?                        Original                                { get; set; }
        public long                                     Add_time                                { get; set; }
        public MonoMethodMessage?                       Call_message                            { get; set; }
        public IMessageCtrl?                            Message_ctrl                            { get; set; }
        public IMessage?                                Reply_message                           { get; set; }
        public WaitCallback?                            Orig_cb                                 { get; set; }

        public static AsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncResult() { Pointer= p0 };

            value.Handle                                    = GetObject<WaitHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.WaitHandle.FromPointer); // 0x18 Handle                      ( ModelClassType WaitHandle WaitHandle WaitHandle Pointer )
            value.Sync_completed                            = GetBool(new IntPtr(p + 0x038)); // 0x38 Sync_completed              ( ModelPrimitiveType bool bool bool Bool )
            value.Completed                                 = GetBool(new IntPtr(p + 0x039)); // 0x39 Completed                   ( ModelPrimitiveType bool bool bool Bool )
            value.Endinvoke_called                          = GetBool(new IntPtr(p + 0x03A)); // 0x3A Endinvoke_called            ( ModelPrimitiveType bool bool bool Bool )
            value.Current                                   = GetObject<ExecutionContext>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0x48 Current                     ( ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.Original                                  = GetObject<ExecutionContext>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0x50 Original                    ( ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.Add_time                                  = GetInt64(new IntPtr(p + 0x058)); // 0x58 Add_time                    ( ModelPrimitiveType long long long Int64 )
            value.Call_message                              = GetObject<MonoMethodMessage>(new IntPtr(p + 0x060), ReversePrism.DataModels.MonoMethodMessage.FromPointer); // 0x60 Call_message                ( ModelClassType MonoMethodMessage MonoMethodMessage MonoMethodMessage Pointer )
            value.Message_ctrl                              = GetObject<IMessageCtrl>(new IntPtr(p + 0x068), ReversePrism.DataModels.IMessageCtrl.FromPointer); // 0x68 Message_ctrl                ( ModelClassType IMessageCtrl IMessageCtrl IMessageCtrl Pointer )
            value.Reply_message                             = GetObject<IMessage>(new IntPtr(p + 0x070), ReversePrism.DataModels.IMessage.FromPointer); // 0x70 Reply_message               ( ModelClassType IMessage IMessage IMessage Pointer )
            value.Orig_cb                                   = GetObject<WaitCallback>(new IntPtr(p + 0x078), ReversePrism.DataModels.WaitCallback.FromPointer); // 0x78 Orig_cb                     ( ModelClassType WaitCallback WaitCallback WaitCallback Pointer )

            return value;
        }
    }
}
