using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 018 TypeName                                 000186671910 ModelPrimitiveType string string string String
    // 020 args                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 028 callContext                              <object> IL2CPP_TYPE_OBJECT
    // 030 ArgTypes                                 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 038 BArgsPrimitive                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C MessageEnum                              000186607C50 ModelEnumType MessageEnum MessageEnum MessageEnum Int32
    public partial class BinaryMethodCall : DataModel
    {
        public string                                   MethodName                              { get; set; }
        public string                                   TypeName                                { get; set; }
        public List<Type>?                              ArgTypes                                { get; set; }
        public bool                                     BArgsPrimitive                          { get; set; }
        public MessageEnum                              MessageEnum                             { get; set; }

        public static BinaryMethodCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryMethodCall() { Pointer= p0 };

            value.MethodName                                = GetString(new IntPtr(p + 0x010)); // 024666CA17D8 0x10 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 024666CA17F8 0x18 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ArgTypes                                  = GetObjectList<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 024666CA1858 0x30 ArgTypes                    ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.BArgsPrimitive                            = GetBool(new IntPtr(p + 0x038)); // 024666CA1878 0x38 BArgsPrimitive              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MessageEnum                               = (MessageEnum)GetInt32(new IntPtr(p + 0x03C)); // 024666CA1898 0x3C MessageEnum                 ( 000186607C50 ModelEnumType MessageEnum MessageEnum MessageEnum Int32 )

            return value;
        }
    }
}
