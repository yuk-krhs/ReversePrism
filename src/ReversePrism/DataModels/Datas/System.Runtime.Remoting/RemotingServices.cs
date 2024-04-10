using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 uri_hash                                 Hashtable IL2CPP_TYPE_CLASS
    // 008 _serializationFormatter                  BinaryFormatter IL2CPP_TYPE_CLASS
    // 010 DeserializationFormatter                 000186757B80 ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer
    // 018 App_id                                   000186672530 ModelPrimitiveType string string string String
    // 020 app_id_lock                              <object> IL2CPP_TYPE_OBJECT
    // 028 Next_id                                  0001865F38E0 ModelPrimitiveType int int int Int32
    // 030 FieldSetterMethod                        0001866144A0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 FieldGetterMethod                        0001866144A0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class RemotingServices : DataModel
    {
        public BinaryFormatter?                         DeserializationFormatter                { get; set; }
        public string                                   App_id                                  { get; set; }
        public int                                      Next_id                                 { get; set; }
        public MethodInfo?                              FieldSetterMethod                       { get; set; }
        public MethodInfo?                              FieldGetterMethod                       { get; set; }

        public static RemotingServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemotingServices() { Pointer= p0 };

            value.DeserializationFormatter                  = GetObject<BinaryFormatter>(new IntPtr(p + 0x010), ReversePrism.DataModels.BinaryFormatter.FromPointer); // 024666C2DD98 0x10 DeserializationFormatter    ( 000186757B80 ModelClassType BinaryFormatter BinaryFormatter BinaryFormatter Pointer )
            value.App_id                                    = GetString(new IntPtr(p + 0x018)); // 024666C2DDB8 0x18 App_id                      ( 000186672530 ModelPrimitiveType string string string String )
            value.Next_id                                   = GetInt32(new IntPtr(p + 0x028)); // 024666C2DDF8 0x28 Next_id                     ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.FieldSetterMethod                         = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 024666C2DE18 0x30 FieldSetterMethod           ( 0001866144A0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.FieldGetterMethod                         = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 024666C2DE38 0x38 FieldGetterMethod           ( 0001866144A0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
